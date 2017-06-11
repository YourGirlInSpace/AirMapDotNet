using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using MQTTnet;
using MQTTnet.Core;
using MQTTnet.Core.Client;
using MQTTnet.Core.Packets;
using MQTTnet.Core.Protocol;

namespace AirMapDotNet.Traffic
{
    public class MqttClient : IMqttClient
    {
        public event EventHandler Connected;
        public event EventHandler Disconnected;
        public event EventHandler<MqttMessageReceivedEventArgs> MessageReceived;

        private readonly MQTTnet.Core.Client.MqttClient _client;
        private readonly string _flightId;

        public MqttClient(AirMap airMap, string flightId)
        {
            if (airMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!airMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            _flightId = flightId ?? throw new ArgumentNullException(nameof(flightId));

            MqttClientOptions opts = new MqttClientOptions
            {
                ClientId = airMap.AuthenticationToken.Audience,

                UserName = flightId,
                Password = airMap.AuthenticationToken.Token,

                Server = TrafficAPI.AirMap_Traffic_MQTTBaseUrl,
                Port = 8883,

                CleanSession = true,
                KeepAlivePeriod = TimeSpan.FromSeconds(15),
                DefaultCommunicationTimeout = TimeSpan.FromSeconds(2),
                
                //TlsOptions = {
                //    UseTls = true
                //}
            };

            _client = new MqttClientFactory().CreateMqttClient(opts);
        }


        public async Task<bool> Connect()
        {
            _client.ApplicationMessageReceived += TfcSvc_OnMsgReceived;
            _client.Connected += TfcSvc_OnConnected;
            _client.Disconnected += TfcSvc_OnDisconnected;

            await _client.ConnectAsync();

            if (!_client.IsConnected)
                throw new TrafficAPIException("Client not connected!");

            if (!await SubscribeTo(string.Format(TrafficAPI.AirMap_Traffic_AlertChannel, _flightId)))
                return false;
            if (!await SubscribeTo(string.Format(TrafficAPI.AirMap_Traffic_SituationalAwarenessChannel, _flightId)))
                return false;

            Connected?.Invoke(this, EventArgs.Empty);
            return true;
        }

        public async Task Disconnect()
        {
            await _client.DisconnectAsync();

            Disconnected?.Invoke(this, EventArgs.Empty);
        }

        public async Task SendData(string topic, byte[] data)
        {
            MqttApplicationMessage am = new MqttApplicationMessage(topic, data, MqttQualityOfServiceLevel.AtLeastOnce, true);

            await _client.PublishAsync(am);
        }

        public async Task<bool> SubscribeTo(string topic)
        {
            TopicFilter tf = new TopicFilter(topic, MqttQualityOfServiceLevel.AtLeastOnce);

            IList<MqttSubscribeResult> results = await _client.SubscribeAsync(tf);

            if (results.Count == 0)
                return false;

            return results[0].ReturnCode != MqttSubscribeReturnCode.Failure;
        }

        internal void TfcSvc_OnDisconnected(object sender, EventArgs eventArgs)
        {
            Disconnected?.Invoke(this, EventArgs.Empty);
        }

        internal void TfcSvc_OnConnected(object sender, EventArgs eventArgs)
        {
            Connected?.Invoke(this, EventArgs.Empty);
        }

        [SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "msg")]
        [SuppressMessage("ReSharper", "UnusedVariable")]
        internal void TfcSvc_OnMsgReceived(object sender, MqttApplicationMessageReceivedEventArgs mqttApplicationMessageReceivedEventArgs)
        {
            MqttApplicationMessage msg = mqttApplicationMessageReceivedEventArgs.ApplicationMessage;

            var args = new MqttMessageReceivedEventArgs(msg.Topic, msg.Payload);

            MessageReceived?.Invoke(this, args);
        }
    }
}