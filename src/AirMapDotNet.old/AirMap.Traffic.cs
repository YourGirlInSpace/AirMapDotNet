using AirMapDotNet.Services;

namespace AirMapDotNet
{
    public partial class AirMap
    {
        /// <summary>
        /// The service used for situational awareness of airborne traffic.
        /// </summary>
        public TrafficService TrafficService { get; }
    }
}