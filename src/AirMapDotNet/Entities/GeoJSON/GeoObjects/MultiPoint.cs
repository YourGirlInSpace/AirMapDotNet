using System.Collections.ObjectModel;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// A feature with multiple individual points.
    /// </summary>
    [JsonConverter(typeof(MultiPointConverter))]
    [GeometryType(GeometryObjectType.MultiPoint)]
    public sealed class MultiPoint : GeometryObject
    {
        /// <summary>
        /// The positions of each point in this feature.
        /// </summary>
        public Collection<Position> Points { get; } = new Collection<Position>();

        /// <summary>
        /// Creates a new <see cref="MultiPoint"/>.
        /// </summary>
        public MultiPoint()
            : base(GeometryObjectType.MultiPoint)
        { }
    }
}