using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal class FeatureCollectionConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            FeatureCollection featureCollection = value as FeatureCollection;

            if (featureCollection == null)
                throw new AirMapException($"Failed to write GeoJSON:  {nameof(value)} is not a FeatureCollection!");

            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteValue(featureCollection.FeatureCollectionType);

            writer.WritePropertyName("features");
            writer.WriteStartArray();

            foreach (Feature feature in featureCollection.Features)
                serializer.Serialize(writer, feature);

            writer.WriteEndArray();
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
            JToken geomObj = jsonObj["features"];

            if (typeObj == null)
                throw new AirMapException("Failed to read GeoJSON:  \"type\" property missing!");
            if (geomObj == null)
                throw new AirMapException("Failed to read GeoJSON:  \"features\" property missing!");

            FeatureCollection featureCollection = new FeatureCollection
            {
                FeatureCollectionType = typeObj.Value<string>()
            };


            geomObj.ToObject<Feature[]>().ToList().ForEach(x => featureCollection.Features.Add(x));
            
            return featureCollection;
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(FeatureCollection);
    }
}