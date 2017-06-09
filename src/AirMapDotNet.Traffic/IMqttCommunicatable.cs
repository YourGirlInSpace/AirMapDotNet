using System;
using System.Threading.Tasks;

namespace AirMapDotNet.Traffic
{
    public interface IMqttCommunicatable
    {
        event EventHandler<MqttMessageReceivedEventArgs> MessageReceived;

        Task SendData(string topic, byte[] data);
        Task<bool> SubscribeTo(string topic);
    }
}