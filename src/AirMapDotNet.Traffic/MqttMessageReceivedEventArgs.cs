using System;

namespace AirMapDotNet.Traffic
{
    public class MqttMessageReceivedEventArgs : EventArgs
    {
        public string Topic { get; }

        public byte[] Payload { get; }
        
        public MqttMessageReceivedEventArgs(string topic, byte[] payload)
        {
            Topic = topic ?? throw new ArgumentNullException(nameof(topic));
            Payload = payload ?? throw new ArgumentNullException(nameof(payload));
        }
    }
}