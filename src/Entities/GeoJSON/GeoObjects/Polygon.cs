using System.Collections.ObjectModel;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// A feature with shapes defined by <see cref="LineString"/> <see cref="Boundaries"/>.
    /// </summary>
    [JsonConverter(typeof(PolygonConverter))]
    [GeometryType(GeometryObjectType.Polygon)]
    public sealed class Polygon : GeometryObject
    {
        private double _area = -1;

        /// <summary>
        /// The area of the <see cref="Polygon"/> in square meters.
        /// </summary>
        public double Area
        {
            get
            {
                if (_area < 0)
                    _area = GeoUtilities.CalculateArea(Boundaries);

                return _area;
            }
        }

        /// <summary>
        /// A list of boundaries for each polygon shape.
        /// </summary>
        /// <remarks>Per the GeoJSON standard (RFC7946), clockwise rings represent the exterior boundary of the polygon,
        /// and counterclockwise rings represent holes.</remarks>
        public Collection<LineString> Boundaries { get; } = new Collection<LineString>();

        /// <summary>
        /// Creates a new <see cref="Polygon"/>.
        /// </summary>
        public Polygon()
            : base(GeometryObjectType.Polygon)
        { }
    }
}