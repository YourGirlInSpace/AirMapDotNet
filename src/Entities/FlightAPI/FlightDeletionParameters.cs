using Newtonsoft.Json;

namespace AirMapDotNet.Entities.FlightAPI
{
    internal sealed class FlightDeletionParameters : AirMapEntity
    {
        [JsonProperty("id")]
        public string ID { get; internal set; }
    }
}