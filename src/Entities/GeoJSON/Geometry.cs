using AirMapDotNet.Entities.GeoJSON.Converters;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON
{
    /// <summary>
    /// Represents a GeoJSON entity.
    /// </summary>
    [JsonConverter(typeof(GeometryConverter))]
    public sealed class Geometry
    {
        /// <summary>
        /// The type of element.
        /// </summary>
        [JsonProperty("type")]
        public GeometryObjectType GeometryType { get; set; }

        /// <summary>
        /// The feature described by this Geometry object.
        /// </summary>
        public GeometryObject GeometryObject { get; set; }
    }
}