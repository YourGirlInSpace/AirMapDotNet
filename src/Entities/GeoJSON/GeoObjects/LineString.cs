using System.Collections.ObjectModel;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// A line feature with two or more points.
    /// </summary>
    [JsonConverter(typeof(LineStringConverter))]
    [GeometryType(GeometryObjectType.LineString)]
    public sealed class LineString : GeometryObject
    {
        /// <summary>
        /// The length of the <see cref="LineString"/> in meters.
        /// </summary>
        public double Length {
            get
            {
                double sum = 0;
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    sum += Points[i].LatLon.Distance(Points[i + 1].LatLon);
                }

                return sum;
            }
        }

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