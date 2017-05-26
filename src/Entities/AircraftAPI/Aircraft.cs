using System.Diagnostics;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AircraftAPI
{
    /// <summary>
    /// Represents an individual aircraft.
    /// </summary>
    [DebuggerDisplay("Aircraft ID={ID} Nickname=\"{Nickname}\"")]
    public sealed class Aircraft : AirMapEntity
    {
        /// <summary>
        /// The aircraft's unique identifier.
        /// </summary>
        /// <value>The aircraft's unique identifier beginning with <c>aircraft|</c></value>
        [JsonProperty("id")]
        public string ID { get; internal set; }

        /// <summary>
        /// The aircraft's nickname.
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; internal set; }

        /// <summary>
        /// The model of the aircraft.
        /// </summary>
        [JsonProperty("model")]
        public Model Model { get; internal set; }

        /// <summary>
        /// The time this aircraft was created.
        /// </summary>
        [JsonProperty("created_at")]
        public System.DateTime CreatedAt { get; internal set; }
    }
}