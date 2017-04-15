using System.Collections.ObjectModel;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// A feature with multiple <see cref="LineString"/>s.
    /// </summary>
    [JsonConverter(typeof(MultiLineStringConverter))]
    public sealed class MultiLineString : GeometryObject
    {
        /// <summary>
        /// A list of each <see cref="LineString"/> in this feature.
        /// </summary>
        public Collection<LineString> LineStrings { get; } = new Collection<LineString>();

        /// <summary>
        /// Creates a new <see cref="MultiLineString"/>.
        /// </summary>
        public MultiLineString()
            : base(GeometryObjectType.MultiLineString)
        { }
    }
}