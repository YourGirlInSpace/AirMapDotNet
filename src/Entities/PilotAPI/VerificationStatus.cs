using Newtonsoft.Json;

namespace AirMapDotNet.Entities.PilotAPI
{
    internal class VerificationStatus : AirMapEntity
    {
        [JsonProperty("verified")]
        public bool Verified { get; internal set; }
    }
}