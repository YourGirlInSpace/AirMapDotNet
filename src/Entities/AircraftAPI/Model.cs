using System.Diagnostics;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AircraftAPI
{
    /// <summary>
    /// Represents a drone model.
    /// </summary>
    [DebuggerDisplay("Model Name={Name}")]
    public class Model : AirMapEntity
    {
        /// <summary>
        /// The unique GUID for this drone model.
        /// </summary>
        [JsonProperty("id")]
        public virtual string ID { get; set; }

        /// <summary>
        /// The model name of the drone.
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The drone's manufacturer.
        /// </summary>
        [JsonProperty("manufacturer")]
        public virtual Manufacturer Manufacturer { get; set; }

        /// <inheritdoc/>
        public override string ToString() => Name;
    }
}