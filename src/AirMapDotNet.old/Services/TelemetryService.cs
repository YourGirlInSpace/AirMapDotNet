using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace AirMapDotNet.Services
{
    /*public class TelemetryService : AirMapService
    {
        private Socket _socket;

        public async Task Connect()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPHostEntry entry = await Dns.GetHostEntryAsync(AirMap_Telemetry_BaseURL);

            if (entry.AddressList.Length > 0)
            {
                var ip = entry.AddressList[0];
                
                await Task.Factory.FromAsync(_socket.BeginConnect, _socket.EndConnect, ip, AirMap_Telemetry_Port, null);
            }
        }
    }*/
}