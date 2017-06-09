using System;
using AirMapDotNet.Entities.TrafficAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace AirMapDotNet.Tests.Entities.TrafficAPI
{
    [TestClass]
    public class TrafficCollectionTest
    {
        private const string SAMPLE_DATA = "{\"traffic\":[{\"id\":\"SAS940-1492320347-airline-0016\",\"direction\":164.50648383691384,\"altitude\":\"13700\",\"latitude\":\"34.01129\",\"longitude\":\"-118.29383\",\"recorded_time\":\"1492551878\",\"ground_speed_kts\":\"373\",\"true_heading\":\"55\",\"properties\":{\"aircraft_id\":\"SAS940\"},\"timestamp\":1492551892694}]}";

        [TestMethod]
        public void DeserializeTest()
        {
            TrafficCollection coll = JsonConvert.DeserializeObject<TrafficCollection>(SAMPLE_DATA);

            Assert.IsNotNull(coll);
        }
    }
}
