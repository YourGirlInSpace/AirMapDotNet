using System;

namespace AirMapDotNet.Traffic
{
    public class TrafficEventArgs : EventArgs
    {
        public Entities.TrafficAPI.Traffic[] Traffic;

        public TrafficEventArgs(Entities.TrafficAPI.Traffic[] traffic)
        {
            Traffic = traffic ?? throw new ArgumentNullException(nameof(traffic));
        }
    }
}