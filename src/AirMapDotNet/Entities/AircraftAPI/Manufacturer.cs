using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AircraftAPI
{
    /// <summary>
    /// A description of a manufacturer recognized by AirMap.
    /// </summary>
    // ReSharper disable once UseNameofExpression
    [DebuggerDisplay("Manufacturer Name={Name}")]
    public sealed class Manufacturer : AirMapEntity
    {
        /// <summary>
        /// The unique GUID associated with this <see cref="Manufacturer"/>.
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; internal set; }

        /// <summary>
        /// The manufacturer's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; internal set; }

        /// <inheritdoc/>
        public override string ToString() => Name;

        /// <summary>
        /// Retrieves a list of drone models from this manufacturer.
        /// </summary>
        /// <returns>A list of drone models from this manufacturer.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public async Task<IEnumerable<Model>> GetModels()
            => await AirMap.GetModels(this);
    }
}