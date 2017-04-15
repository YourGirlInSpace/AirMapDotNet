using System;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.FlightAPI
{
    internal class FlightEndParameters : AirMapEntity
    {
        [JsonProperty("end_time")]
        public DateTime EndTime { get; internal set; }
    }
}