using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal class FeatureConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            Feature feature = value as Feature;

            if (feature == null)
                throw new AirMapException($"Failed to write GeoJSON:  {nameof(value)} is not a Feature!");

            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteValue(feature.FeatureType);
            
            if (feature.Properties.Count > 0)
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (KeyValuePair<string, object> property in feature.Properties)
                {
                    writer.WritePropertyName(property.Key);
                    writer.WriteValue(property.Value);
                }
                writer.WriteEndObject();
            }

            writer.WritePropertyName("geometry");
            serializer.Serialize(writer, feature.Geometry);
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));
            if (objectType == null)
                throw new ArgumentNullException(nameof(objectType));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            JToken jsonObj = JToken.ReadFrom(reader);

            JToken typeObj = jsonObj["type"];
            JToken geomObj = jsonObj["geometry"];
            JToken propObj = jsonObj["properties"];

            if (typeObj == null)
                throw new AirMapException("Failed to read GeoJSON:  \"type\" property missing!");
            if (geomObj == null)
                throw new AirMapException("Failed to read GeoJSON:  \"geometry\" property missing!");

            Feature feature = new Feature
            {
                FeatureType = typeObj.Value<string>(),
                Geometry = geomObj.ToObject<Geometry>()
            };


            if (propObj != null && propObj.Type != JTokenType.Null)
            {
                Dictionary<string, object> props = propObj.ToObject<Dictionary<string, object>>();
                foreach (KeyValuePair<string, object> property in props)
                    feature.Properties.Add(property.Key, property.Value);
            }

            return feature;
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(Feature);
    }
}