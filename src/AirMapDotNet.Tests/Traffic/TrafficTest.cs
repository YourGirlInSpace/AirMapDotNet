using System;
using System.Text;
using System.Threading;
using AirMapDotNet.Tests.Mocks;
using AirMapDotNet.Traffic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AirMapDotNet.Tests.Traffic
{
    using Traffic = AirMapDotNet.Entities.TrafficAPI.Traffic;

    [TestClass]
    public class TrafficTest
    {
        private const string SAMPLE_DATA = "{\"traffic\":[{\"id\":\"SAS940-1492320347-airline-0016\",\"direction\":164.50648383691384,\"altitude\":\"13700\",\"latitude\":\"34.01129\",\"longitude\":\"-118.29383\",\"recorded_time\":\"1492551878\",\"ground_speed_kts\":\"373\",\"true_heading\":\"55\",\"properties\":{\"aircraft_id\":\"SAS940\"},\"timestamp\":1492551892694}]}";
        
        private (TrafficAPI, IMqttTestClient) InitializeTFA(string flightId)
        {
            MockMQTTClient client = new MockMQTTClient();
            return (new TrafficAPI(client, flightId), client);
        }

        [TestMethod]
        public void TestTrafficConnector()
        {
            const string FLIGHTID = "flight|abcdefg";

            (TrafficAPI api, IMqttTestClient _) = InitializeTFA(FLIGHTID);

            bool connected = api.Connect().GetAwaiter().GetResult();

            Assert.IsTrue(connected);
        }

        [TestMethod]
        public void TestTrafficRawData()
        {
            // ========== ARRANGE ==========
            const string FLIGHTID = "flight|abcdefg";
            const string TOPIC = "uav/traffic/alert/" + FLIGHTID;

            var are = new AutoResetEvent(false);

            (TrafficAPI api, IMqttTestClient client) = InitializeTFA(FLIGHTID);

            bool connected = api.Connect().GetAwaiter().GetResult();

            Assert.IsTrue(connected);

            string receivedTopic = string.Empty;
            string receivedData = string.Empty;

            // ========== ACT ==========
            client.MessageReceived += (sender, args) =>
            {
                receivedTopic = args.Topic;
                receivedData = Encoding.UTF8.GetString(args.Payload);

                are.Set();
            };

            byte[] payload = Encoding.UTF8.GetBytes(SAMPLE_DATA);
            client.TriggerDiagnosticMessage(TOPIC, payload);

            // ========== ASSERT ==========
            // Wait until the event finishes
            bool wasSignaled = are.WaitOne(TimeSpan.FromSeconds(5));
            Assert.IsTrue(wasSignaled);
            Assert.AreEqual(SAMPLE_DATA, receivedData);
            Assert.AreEqual(TOPIC, receivedTopic);

            // ========== FINALIZE ==========
            api.Disconnect();
        }

        [TestMethod]
        public void TestTrafficData_SituationalAwareness()
        {
            // ========== ARRANGE ==========
            const string FLIGHTID = "flight|abcdefg";
            const string TOPIC = "uav/traffic/sa/" + FLIGHTID;

            var are = new AutoResetEvent(false);

            (TrafficAPI api, IMqttTestClient client) = InitializeTFA(FLIGHTID);

            bool connected = api.Connect().GetAwaiter().GetResult();

            Assert.IsTrue(connected);

            Traffic[] traffic = new Traffic[0];
            // ========== ACT ==========
            api.SituationalAwarenessReceived += (sender, args) =>
            {
                traffic = args.Traffic;
                are.Set();
            };

            api.AlertReceived += (sender, args) =>
            {
                Assert.Fail("Wrong event called!");
            };

            byte[] payload = Encoding.UTF8.GetBytes(SAMPLE_DATA);
            client.TriggerDiagnosticMessage(TOPIC, payload);

            // ========== ASSERT ==========
            // Wait until the event finishes
            bool wasSignaled = are.WaitOne(TimeSpan.FromSeconds(5));
            Assert.IsTrue(wasSignaled);

            Assert.AreEqual(1, traffic.Length);

            Traffic plane = traffic[0];
            Assert.AreEqual("SAS940-1492320347-airline-0016", plane.ID);
            Assert.AreEqual(13700, plane.Altitude, 100);

            // ========== FINALIZE ==========
            api.Disconnect();
        }

        [TestMethod]
        public void TestTrafficData_Alert()
        {
            // ========== ARRANGE ==========
            const string FLIGHTID = "flight|abcdefg";
            const string TOPIC = "uav/traffic/alert/" + FLIGHTID;

            var are = new AutoResetEvent(false);

            (TrafficAPI api, IMqttTestClient client) = InitializeTFA(FLIGHTID);

            bool connected = api.Connect().GetAwaiter().GetResult();

            Assert.IsTrue(connected);

            Traffic[] traffic = new Traffic[0];
            // ========== ACT ==========
            api.AlertReceived += (sender, args) =>
            {
                traffic = args.Traffic;
                are.Set();
            };

            api.SituationalAwarenessReceived += (sender, args) =>
            {
                Assert.Fail("Wrong event called!");
            };

            byte[] payload = Encoding.UTF8.GetBytes(SAMPLE_DATA);
            client.TriggerDiagnosticMessage(TOPIC, payload);

            // ========== ASSERT ==========
            // Wait until the event finishes
            bool wasSignaled = are.WaitOne(TimeSpan.FromSeconds(5));
            Assert.IsTrue(wasSignaled);

            Assert.AreEqual(1, traffic.Length);

            Traffic plane = traffic[0];
            Assert.AreEqual("SAS940-1492320347-airline-0016", plane.ID);
            Assert.AreEqual(13700, plane.Altitude, 100);

            // ========== FINALIZE ==========
            api.Disconnect();
        }
    }
}
