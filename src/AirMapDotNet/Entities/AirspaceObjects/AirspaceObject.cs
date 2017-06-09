using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using AirMapDotNet.Entities.GeoJSON;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Airspace objects represent all the different advisories in which a UAS operator may be interested. The Airspace objects are returned in both the Status API and the Airspace API.
    /// </summary>
    [DebuggerDisplay("Airspace Object #{ID} Type={ObjectType}")]
    public abstract class AirspaceObject
    {
        /// <summary>
        /// The unique ID of this object.
        /// </summary>
        [JsonProperty("id", Required = Required.Always)]
        public string ID { get; internal set; }

        /// <summary>
        /// The name of this object.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; internal set; }

        /// <summary>
        /// The type of this object.
        /// </summary>
        [JsonProperty("type", Required = Required.Always)]
        public string ObjectType { get; internal set; }

        /// <summary>
        /// The country where this object exists.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; internal set; }

        /// <summary>
        /// The state where this object exists.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; internal set; }

        /// <summary>
        /// The city where this object exists.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; internal set; }

        /// <summary>
        /// The time when this object was last updated.
        /// </summary>
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; internal set; }

        /// <summary>
        /// Unique properties of the object.
        /// </summary>
        [JsonProperty("properties")]
        public Dictionary<string, object> Properties { get; } = new Dictionary<string, object>();

        /// <summary>
        /// The geometry of the object.
        /// </summary>
        [JsonProperty("geometry")]
        public Geometry Geometry { get; internal set; }
        
        /// <summary>
        /// Implicitly deserializes a JSON string into an <see cref="AirspaceObject"/>.
        /// </summary>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>The deserialized object.</returns>
        public static AirspaceObject Deserialize(string json)
        {
            dynamic preSerialize = JsonConvert.DeserializeObject(json);

            string type = (string) preSerialize.type;

            return 
                (
                    from t in Utilities.GetTypesWithAttribute<ObjectTypeAttribute>()
                    let objType = t.GetTypeInfo().GetCustomAttribute<ObjectTypeAttribute>(true)
                    // There should only be one instance of this
                    where objType.TypeName.Equals(type)
                    select (AirspaceObject) JsonConvert.DeserializeObject(json, t)
                ).FirstOrDefault();
        }
    }
}