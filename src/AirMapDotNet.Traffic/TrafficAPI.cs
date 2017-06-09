
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AirMapDotNet.Entities.TrafficAPI;
using Newtonsoft.Json;

[assembly: InternalsVisibleTo("AirMapDotNet.Traffic.NetCore"),
           InternalsVisibleTo("AirMapDotNet.Traffic.NetFramework"),
           InternalsVisibleTo("AirMapDotNet.Traffic"),
           InternalsVisibleTo("AirMapDotNet.Explorables"),
           InternalsVisibleTo("AirMapDotNet.Tests")]
namespace AirMapDotNet.Traffic
{
    [SuppressMessage("ReSharper", "EventNeverSubscribedTo.Global")]
    public class TrafficAPI
    {
        /// <summary>
        /// Traffic Alert SDK base MQTT URL.
        /// </summary>
        internal const string AirMap_Traffic_MQTTBaseUrl = "ssl://mqtt-prod.airmap.io";
        /// <summary>
        /// Alert channel for a particular flight.  {0} = Flight ID.
        /// </summary>
        internal const string AirMap_Traffic_AlertChannel = "uav/traffic/alert/{0}";
        /// <summary>
        /// Situational awareness channel for a particular flight.  {0} = Flight ID.
        /// </summary>
        internal const string AirMap_Traffic_SituationalAwarenessChannel = "uav/traffic/sa/{0}";

        public static TrafficAPI FromInstance(IMqttClient client, string flightId)
        {
            return new TrafficAPI(client, flightId);
        }

        public event EventHandler Connected;
        public event EventHandler Disconnected;

        public event EventHandler<TrafficEventArgs> SituationalAwarenessReceived;
        public event EventHandler<TrafficEventArgs> AlertReceived;

        private readonly string _flightId;
        private readonly IMqttClient _client;

        internal TrafficAPI(IMqttClient client, string flightId)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _flightId = flightId ?? throw new ArgumentNullException(nameof(flightId));

            _client.Connected += TfcSvc_OnConnected;
            _client.Disconnected += TfcSvc_OnDisconnected;
            _client.MessageReceived += TfcSvc_OnMsgReceived;
        }

        public Task<bool> Connect()
            => _client.Connect();

        public Task Disconnect()
            => _client.Disconnect();

        internal void TfcSvc_OnDisconnected(object sender, EventArgs eventArgs)
        {
            Disconnected?.Invoke(this, EventArgs.Empty);
        }

        internal void TfcSvc_OnConnected(object sender, EventArgs eventArgs)
        {
            Connected?.Invoke(this, EventArgs.Empty);
        }
        
        internal void TfcSvc_OnMsgReceived(object sender, MqttMessageReceivedEventArgs args)
        {
            string jsonPayload = Encoding.UTF8.GetString(args.Payload);

            TrafficCollection tc = JsonConvert.DeserializeObject<TrafficCollection>(jsonPayload);
            if (args.Topic.Equals(String.Format(AirMap_Traffic_SituationalAwarenessChannel, _flightId)))
                SituationalAwarenessReceived?.Invoke(this, new TrafficEventArgs(tc.Traffic));
            if (args.Topic.Equals(String.Format(AirMap_Traffic_AlertChannel, _flightId)))
                AlertReceived?.Invoke(this, new TrafficEventArgs(tc.Traffic));
        }
    }
}