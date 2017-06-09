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
        public Position SouthWest { get; }

        /// <summary>
        /// The northeast corner of the <see cref="BoundingBox"/>.
        /// </summary>
        public Position NorthEast { get; }

        /// <summary>
        /// Creates a new <see cref="BoundingBox"/>.
        /// </summary>
        /// <param name="sw">The southwest coordinate.</param>
        /// <param name="ne">The northeast coordinate.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="sw"/> is null.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="ne"/> is null.</exception>
        public BoundingBox(Position sw, Position ne)
        {
            SouthWest = sw ?? throw new ArgumentNullException(nameof(sw));
            NorthEast = ne ?? throw new ArgumentNullException(nameof(ne));
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
            => Equals(obj as BoundingBox);

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((SouthWest != null ? SouthWest.GetHashCode() : 0) * 397) ^ (NorthEast != null ? NorthEast.GetHashCode() : 0);
            }
        }

        /// <inheritdoc />
        public bool Equals(BoundingBox other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(SouthWest, other.SouthWest) && Equals(NorthEast, other.NorthEast);
        }

        /// <summary>
        /// Determines whether <paramref name="left"/> is equal to <paramref name="right"/>.
        /// </summary>
        /// <param name="left">The first <see cref="BoundingBox"/>.</param>
        /// <param name="right">The second <see cref="BoundingBox"/>.</param>
        /// <returns><b>True</b> if <paramref name="left"/> equals <paramref name="right"/>, otherwise <b>false</b>.</returns>
        public static bool operator ==(BoundingBox left, BoundingBox right)
            => Equals(left, right);

        /// <summary>
        /// Determines whether <paramref name="left"/> is not equal to <paramref name="right"/>.
        /// </summary>
        /// <param name="left">The first <see cref="BoundingBox"/>.</param>
        /// <param name="right">The second <see cref="BoundingBox"/>.</param>
        /// <returns><b>True</b> if <paramref name="left"/> does not equal <paramref name="right"/>, otherwise <b>false</b>.</returns>
        public static bool operator !=(BoundingBox left, BoundingBox right)
            => !Equals(left, right);
    }
}