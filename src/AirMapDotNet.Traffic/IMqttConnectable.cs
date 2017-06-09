using System;
using System.Threading.Tasks;

namespace AirMapDotNet.Traffic
{
    public interface IMqttConnectable
    {
        event EventHandler Connected;
        event EventHandler Disconnected;

        Task<bool> Connect();
        Task Disconnect();
    }
}