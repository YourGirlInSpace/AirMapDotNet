using Newtonsoft.Json;

namespace AirMapDotNet.Entities.FlightAPI
{
    internal class FlightDeletionParameters : AirMapEntity
    {
        [JsonProperty("id")]
        public string ID { get; internal set; }
    }
}