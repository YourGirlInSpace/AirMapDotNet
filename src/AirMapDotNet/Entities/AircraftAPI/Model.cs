using System.Diagnostics;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AircraftAPI
{
    /// <summary>
    /// Represents a drone model.
    /// </summary>
    // ReSharper disable once UseNameofExpression
    [DebuggerDisplay("Model Name={Name}")]
    public sealed class Model : AirMapEntity
    {
        /// <summary>
        /// The unique GUID for this drone model.
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; internal set; }

        /// <summary>
        /// The model name of the drone.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; internal set; }

        /// <summary>
        /// The drone's manufacturer.
        /// </summary>
        [JsonProperty("manufacturer")]
        public Manufacturer Manufacturer { get; internal set; }

        /// <inheritdoc/>
        public override string ToString() => Name;
    }
}