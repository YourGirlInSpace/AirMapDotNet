using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities.FlightAPI;
using MQTTnet;
using MQTTnet.Core;
using MQTTnet.Core.Client;
using MQTTnet.Core.Packets;
using MQTTnet.Core.Protocol;

namespace AirMapDotNet.Services
{
    /// <summary>
    /// Exposes an interface to the AirMap MQTT Traffic API.
    /// </summary>
    public class TrafficService : AirMapService
    {
        internal event EventHandler Connected;
        internal event EventHandler Disconnected;

        private MqttClient _client;

        internal TrafficService(AirMap am)
            : base(am)
        {
        }

        /// <summary>
        /// Connects to the AirMap traffic service.
        /// </summary>
        /// <param name="flightId">The flight ID to listen to.</param>
        /// <returns><c>True</c> if the connection was successful, otherwise <c>false</c>.</returns>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        public async Task<bool> Connect(string flightId)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            MqttClientOptions opts = new MqttClientOptions
            {
                ClientId = Guid.NewGuid().ToString(),
                CleanSession = true,
                KeepAlivePeriod = TimeSpan.FromSeconds(15),
                UserName = flightId,
                Password = AirMap.AuthenticationToken.Token,
                Server = AirMap_Traffic_MQTTBaseUrl,
                Port = 8883,
                DefaultCommunicationTimeout = TimeSpan.FromSeconds(2)
            };

            _client = new MqttClientFactory().CreateMqttClient(opts);
            
            _client.ApplicationMessageReceived += TfcSvc_OnMsgReceived;
            _client.Connected += TfcSvc_OnConnected;
            _client.Disconnected += TfcSvc_OnDisconnected;
            
            await _client.ConnectAsync();

            if (!_client.IsConnected)
                throw new ApplicationException("Client not connected!");

            if (!await SubscribeTo(_client, string.Format(AirMap_Traffic_AlertChannel, flightId)))
                return false;

            return await SubscribeTo(_client, string.Format(AirMap_Traffic_SituationalAwarenessChannel, flightId));
        }
        
        /// <summary>
        /// Connects to the traffic service for traffic alerts for the <paramref name="flight"/>.
        /// </summary>
        /// <param name="flight">The flight to subscribe to.</param>
        /// <returns><c>True</c> if the subscription was successful, otherwise <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="flight"/> is null.</exception>
        public Task<bool> Connect(Flight flight)
        {
            if (flight == null)
                throw new ArgumentNullException(nameof(flight));

            return Connect(flight.ID);
        }

        private void TfcSvc_OnDisconnected(object sender, EventArgs eventArgs)
        {
            Disconnected?.Invoke(this, EventArgs.Empty);
        }

        private void TfcSvc_OnConnected(object sender, EventArgs eventArgs)
        {
            Connected?.Invoke(this, EventArgs.Empty);
        }

        // TODO: temporary
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "msg")]
        private void TfcSvc_OnMsgReceived(object sender, MqttApplicationMessageReceivedEventArgs mqttApplicationMessageReceivedEventArgs)
        {
            MqttApplicationMessage msg = mqttApplicationMessageReceivedEventArgs.ApplicationMessage;
            
        }

        private static async Task<bool> SubscribeTo(MqttClient client, string channel)
        {
            TopicFilter tf = new TopicFilter(channel, MqttQualityOfServiceLevel.AtLeastOnce);

            IList<MqttSubscribeResult> results = await client.SubscribeAsync(tf);

            if (results.Count == 0)
                return false;

            return results[0].ReturnCode != MqttSubscribeReturnCode.Failure;
        }
    }
}