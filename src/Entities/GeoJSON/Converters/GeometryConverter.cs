using System;
using System.Linq;
using System.Reflection;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal sealed class GeometryConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            Geometry geom = value as Geometry;
            
            if (geom == null)
                throw new AirMapException($"Failed to write GeoJSON:  {nameof(value)} is not a Geometry!");

            writer.WriteStartObject();

            writer.WritePropertyName("type");
            writer.WriteValue(geom.GeometryType.ToString().ToLowerInvariant());

            writer.WritePropertyName("coordinates");
            serializer.Serialize(writer, geom.GeometryObject);

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

            Geometry geom = new Geometry();

            JToken jt = JToken.ReadFrom(reader);

            if (!jt.HasValues)
                throw new AirMapException("Failed to parse GeoJSON:  Token does not have values.");
            
            JToken typeToken = jt["type"];
            if (typeToken == null)
                throw new AirMapException("Failed to parse GeoJSON: Token \"type\" does not exist.");

            JToken coordinatesToken = jt["coordinates"];
            if (coordinatesToken == null)
                throw new AirMapException("Failed to parse GeoJSON: Token \"coordinates\" does not exist.");

            geom.GeometryType = (GeometryObjectType) Enum.Parse(typeof(GeometryObjectType), typeToken.Value<string>(), true);

            /* In plain english:
             * Search for all objects with the attribute GeometryTypeAttribute,
             * and select the type with the attribute matching geom.GeometryType,
             * deserialize the token and assign it to geom.GeometryObject
             */
            geom.GeometryObject = (GeometryObject)
                (
                    from t in Utilities.GetTypesWithAttribute<GeometryTypeAttribute>()
                    let objType = t.GetCustomAttribute<GeometryTypeAttribute>(true)
                    // There should only be one instance of this
                    where objType.ObjectType == geom.GeometryType
                    select coordinatesToken.ToObject(t)
                ).FirstOrDefault();
            
            return geom;
        }
        
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Geometry);
        }
    }
}