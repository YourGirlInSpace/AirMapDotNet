using System;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON
{
    /// <summary>
    /// Describes the bounds of a geographic object -- In other words, the corners that describe a box
    /// that contains all points described in a <see cref="Feature"/> or <see cref="FeatureCollection"/>.
    /// </summary>
    [JsonConverter(typeof(BoundingBoxConverter))]
    public sealed class BoundingBox : IEquatable<BoundingBox>
    {
        /// <summary>
        /// The southwest corner of the <see cref="BoundingBox"/>.
        /// </summary>
        public Position SouthWest { get; set; }

        /// <summary>
        /// The northeast corner of the <see cref="BoundingBox"/>.
        /// </summary>
        public Position NorthEast { get; set; }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return Equals(obj as BoundingBox);
        }

        /// <inheritdoc />
        public bool Equals(BoundingBox other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(SouthWest, other.SouthWest) && Equals(NorthEast, other.NorthEast);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((SouthWest?.GetHashCode() ?? 0)*397) ^ (NorthEast?.GetHashCode() ?? 0);
            }
        }

        /// <summary>
        /// Determines whether <paramref name="left"/> is equal to <paramref name="right"/>.
        /// </summary>
        /// <param name="left">The first <see cref="BoundingBox"/>.</param>
        /// <param name="right">The second <see cref="BoundingBox"/>.</param>
        /// <returns><b>True</b> if <paramref name="left"/> equals <paramref name="right"/>, otherwise <b>false</b>.</returns>
        public static bool operator ==(BoundingBox left, BoundingBox right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Determines whether <paramref name="left"/> is not equal to <paramref name="right"/>.
        /// </summary>
        /// <param name="left">The first <see cref="BoundingBox"/>.</param>
        /// <param name="right">The second <see cref="BoundingBox"/>.</param>
        /// <returns><b>True</b> if <paramref name="left"/> does not equal <paramref name="right"/>, otherwise <b>false</b>.</returns>
        public static bool operator !=(BoundingBox left, BoundingBox right)
        {
            return !Equals(left, right);
        }
    }
}