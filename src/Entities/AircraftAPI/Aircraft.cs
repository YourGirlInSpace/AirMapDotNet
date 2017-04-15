using System.Diagnostics;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AircraftAPI
{
    /// <summary>
    /// Represents an individual aircraft.
    /// </summary>
    [DebuggerDisplay("Aircraft ID={ID} Nickname=\"{Nickname}\"")]
    public class Aircraft : AirMapEntity
    {
        /// <summary>
        /// The aircraft's unique identifier.
        /// </summary>
        /// <value>The aircraft's unique identifier beginning with <c>aircraft|</c></value>
        [JsonProperty("id")]
        public virtual string ID { get; set; }

        /// <summary>
        /// The aircraft's nickname.
        /// </summary>
        [JsonProperty("nickname")]
        public virtual string Nickname { get; set; }

        /// <summary>
        /// The model of the aircraft.
        /// </summary>
        [JsonProperty("model")]
        public virtual Model Model { get; set; }
    }
}