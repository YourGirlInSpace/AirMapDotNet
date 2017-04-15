using System.Diagnostics;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AircraftAPI
{
    /// <summary>
    /// A description of a manufacturer recognized by AirMap.
    /// </summary>
    [DebuggerDisplay("Manufacturer Name={Name}")]
    public class Manufacturer : AirMapEntity
    {
        /// <summary>
        /// The unique GUID associated with this <see cref="Manufacturer"/>.
        /// </summary>
        [JsonProperty("id")]
        public virtual string ID { get; set; }

        /// <summary>
        /// The manufacturer's name.
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString() => Name;
    }
}