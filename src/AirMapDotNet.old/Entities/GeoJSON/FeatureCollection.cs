using System.Collections.ObjectModel;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON
{
    /// <summary>
    /// Represents a collection of <see cref="Feature"/>s.
    /// </summary>
    // I am suppressing this message because this is exactly what the GeoJSON specification calls
    // this object.  RFC7946 § 3.3
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
    [JsonConverter(typeof(FeatureCollectionConverter))]
    public sealed class FeatureCollection
    {
        /// <summary>
        /// The type of this feature collection.
        /// </summary>
        /// <value>This should always be "FeatureCollection".</value>
        public string FeatureCollectionType { get; set; }

        /// <summary>
        /// Describes the bounds of this <see cref="FeatureCollection"/>.
        /// </summary>
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// The features contained within this <see cref="FeatureCollection"/>.
        /// </summary>
        public Collection<Feature> Features { get; } = new Collection<Feature>();
    }
}