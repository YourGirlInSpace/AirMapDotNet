using System.Collections.ObjectModel;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// A feature comprised of multiple <see cref="Polygon"/>s.
    /// </summary>
    [JsonConverter(typeof(MultiPolygonConverter))]
    [GeometryType(GeometryObjectType.MultiPolygon)]
    public sealed class MultiPolygon : GeometryObject
    {
        /// <summary>
        /// A list of polygons comprising this feature.
        /// </summary>
        public Collection<Polygon> Polygons { get; } = new Collection<Polygon>();

        /// <summary>
        /// Creates a new <see cref="MultiPolygon"/>.
        /// </summary>
        public MultiPolygon()
            : base(GeometryObjectType.MultiPolygon)
        { }
    }
}