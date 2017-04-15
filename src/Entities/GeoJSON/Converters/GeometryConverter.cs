using System;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal class GeometryConverter : JsonConverter
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
            writer.WriteValue(geom.GeometryType);

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

            geom.GeometryType = typeToken.Value<string>();

            // Since the GeoJSON specification is unlikely to change in a long while,
            // we'll just do it this way.  Yay for laziness!
            switch (typeToken.Value<string>().ToLowerInvariant())
            {
                case "point":
                    geom.GeometryObject = coordinatesToken.ToObject<Point>();
                    break;
                case "multipoint":
                    geom.GeometryObject = coordinatesToken.ToObject<MultiPoint>();
                    break;
                case "linestring":
                    geom.GeometryObject = coordinatesToken.ToObject<LineString>();
                    break;
                case "multilinestring":
                    geom.GeometryObject = coordinatesToken.ToObject<MultiLineString>();
                    break;
                case "polygon":
                    geom.GeometryObject = coordinatesToken.ToObject<Polygon>();
                    break;
                case "multipolygon":
                    geom.GeometryObject = coordinatesToken.ToObject<MultiPolygon>();
                    break;
                case "geometrycollection":
                    geom.GeometryObject = coordinatesToken.ToObject<GeometryCollection>();
                    break;
            }

            return geom;
        }
        
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Geometry);
        }
    }
}