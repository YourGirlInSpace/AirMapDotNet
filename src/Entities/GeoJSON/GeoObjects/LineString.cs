using System.Collections.ObjectModel;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// A line feature with two or more points.
    /// </summary>
    [JsonConverter(typeof(LineStringConverter))]
    public sealed class LineString : GeometryObject
    {
        /// <summary>
        /// The positions of each point along the line.
        /// </summary>
        public Collection<Position> Points { get; } = new Collection<Position>();

        /// <summary>
        /// Creates a new <see cref="LineString"/>.
        /// </summary>
        public LineString()
            : base(GeometryObjectType.LineString)
        { }
    }
}