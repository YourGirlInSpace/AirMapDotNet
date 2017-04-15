using System.Collections.Generic;
using AirMapDotNet.Entities.GeoJSON.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.GeoJSON
{
    /// <summary>
    /// Represents a spatially bounded area defined by <see cref="Geometry"/>.
    /// </summary>
    [JsonConverter(typeof(FeatureConverter))]
    public sealed class Feature
    {
        /// <summary>
        /// The feature type.
        /// </summary>
        /// <value>This should always be "Feature".</value>
        public string FeatureType { get; set; }

        /// <summary>
        /// Describes the bounds of this <see cref="Feature"/>.
        /// </summary>
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// The geometry describing the bounds of this feature.
        /// </summary>
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Properties assigned to this feature.
        /// </summary>
        public Dictionary<string, object> Properties { get; } = new Dictionary<string, object>();

        /// <summary>
        /// Gets or sets the property with the name "<paramref name="key"/>".
        /// </summary>
        /// <param name="key">The name of the property.</param>
        public object this[string key]
        {
            get
            {
                return !Properties.ContainsKey(key) ? null : Properties[key];
            }

            set
            {
                if (!Properties.ContainsKey(key))
                {
                    Properties.Add(key, value);
                    return;
                }

                Properties[key] = value;
            }
        }
    }
}