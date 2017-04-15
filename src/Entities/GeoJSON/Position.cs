using System;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON
{
    /// <summary>
    /// Represents a three-dimensional position on a map.
    /// </summary>
    [JsonConverter(typeof(PositionConverter))]
    public sealed class Position : IEquatable<Position>
    {
        /// <summary>
        /// The absolute tolerance before an elevation may be considered zero.  In this case, 1mm.
        /// </summary>
        public const double Epsilon = 0.001;

        /// <summary>
        /// The Latitude and Longitude of the position,
        /// </summary>
        public LatLon LatLon { get; set; }

        /// <summary>
        /// The elevation of the position above the WGS84 reference ellipsoid in meters.
        /// </summary>
        public double Elevation { get; set; }

        /// <summary>
        /// Creates a new <see cref="Position"/>.
        /// </summary>
        public Position()
        {

        }

        /// <summary>
        /// Creates a new <see cref="Position"/>.
        /// </summary>
        /// <param name="ll">The value to assign to <see cref="LatLon"/>.</param>
        public Position(LatLon ll)
        {
            LatLon = ll;
        }

        /// <summary>
        /// Creates a new <see cref="Position"/>.
        /// </summary>
        /// <param name="ll">The value to assign to <see cref="LatLon"/>.</param>
        /// <param name="elev">The value to assign to <see cref="Elevation"/></param>
        public Position(LatLon ll, double elev)
        {
            LatLon = ll;
            Elevation = elev;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return Equals(obj as Position);
        }

        /// <inheritdoc />
        public bool Equals(Position other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(LatLon, other.LatLon) && Math.Abs(Elevation - other.Elevation) < Epsilon;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((LatLon?.GetHashCode() ?? 0)*397) ^ Elevation.GetHashCode();
            }
        }

        /// <summary>
        /// Determines whether <paramref name="left"/> is equal to <paramref name="right"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Position"/>.</param>
        /// <param name="right">The second <see cref="Position"/>.</param>
        /// <returns><b>True</b> if <paramref name="left"/> equals <paramref name="right"/>, otherwise <b>false</b>.</returns>
        public static bool operator ==(Position left, Position right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Determines whether <paramref name="left"/> is not equal to <paramref name="right"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Position"/>.</param>
        /// <param name="right">The second <see cref="Position"/>.</param>
        /// <returns><b>True</b> if <paramref name="left"/> does not equal <paramref name="right"/>, otherwise <b>false</b>.</returns>
        public static bool operator !=(Position left, Position right)
        {
            return !Equals(left, right);
        }
    }
}