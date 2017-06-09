using Newtonsoft.Json;

namespace AirMapDotNet.Entities.TrafficAPI
{
    internal class TrafficProperties
    {
        [JsonProperty("aircraft_id")]
        internal string AircraftID { get; set; }

        [JsonProperty("aircraft_type")]
        internal string AircraftType { get; set; }
    }
}