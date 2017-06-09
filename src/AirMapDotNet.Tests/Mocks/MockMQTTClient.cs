using System;
using System.Threading.Tasks;
using AirMapDotNet.Traffic;

namespace AirMapDotNet.Tests.Mocks
{
    public class MockMQTTClient : IMqttTestClient
    {
        public event EventHandler Connected;
        public event EventHandler Disconnected;

        public event EventHandler<MqttMessageReceivedEventArgs> MessageReceived;

        public async Task<bool> Connect()
        {
            if (Connected != null)
                await Task.Factory.FromAsync(Connected.BeginInvoke, Connected.EndInvoke, this, EventArgs.Empty, null);
            
            return true;
        }

        public async Task Disconnect()
        {
            if (Disconnected == null)
                return;

            await Task.Factory.FromAsync(Disconnected.BeginInvoke, Disconnected.EndInvoke, this, EventArgs.Empty, null);
        }

        public Task SendData(string topic, byte[] data)
        {
            throw new NotImplementedException("Not implemented for test environment.");
        }

        public Task<bool> SubscribeTo(string topic)
        {
            return Task.FromResult(true);
        }

        public void TriggerDiagnosticMessage(string topic, byte[] payload)
        {
            var args = new MqttMessageReceivedEventArgs(topic, payload);
            MessageReceived?.Invoke(this, args);
        }
    }
}