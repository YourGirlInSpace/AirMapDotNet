using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// Represents a singular point on a map.
    /// </summary>
    [JsonConverter(typeof(PointConverter))]
    [GeometryType(GeometryObjectType.Point)]
    public sealed class Point : GeometryObject
    {
        /// <summary>
        /// The position of the point.
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Creates a new <see cref="Point"/>.
        /// </summary>
        public Point()
            : base(GeometryObjectType.Point)
        { }
    }
}