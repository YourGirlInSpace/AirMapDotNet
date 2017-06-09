using AirMapDotNet.Traffic;

namespace AirMapDotNet.Tests.Mocks
{
    public interface IMqttTestClient : IMqttClient
    {
        void TriggerDiagnosticMessage(string topic, byte[] payload);
    }
}