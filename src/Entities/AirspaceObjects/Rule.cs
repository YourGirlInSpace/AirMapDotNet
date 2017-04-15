using AirMapDotNet.Entities.GeoJSON;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Represents a flight rule and its associated boundary.
    /// </summary>
    /// <remarks>A flight rule currently describes the Commercial Flight Rules and the Recreational Flight Rules,
    /// which have different boundaries.</remarks>
    public class Rule
    {
        /// <summary>
        /// The name of the rule.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// The boundary of the rule.
        /// </summary>
        [JsonProperty("geometry")]
        public Geometry Geometry { get; }
    }
}