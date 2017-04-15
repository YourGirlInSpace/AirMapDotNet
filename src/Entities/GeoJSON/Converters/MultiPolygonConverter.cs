using System;
using System.Linq;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal class MultiPolygonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            MultiPolygon mpf = value as MultiPolygon;

            if (mpf == null)
                throw new AirMapException($"Failed to write GeoJSON:  {nameof(value)} is not a MultiPolygonFeature!");

            writer.WriteStartArray();

            foreach (Polygon pos in mpf.Polygons)
                serializer.Serialize(writer, pos);

            writer.WriteEndArray();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));
            if (objectType == null)
                throw new ArgumentNullException(nameof(objectType));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            JToken pointArray = JToken.ReadFrom(reader);

            MultiPolygon pf = new MultiPolygon();
            pointArray.ToObject<Polygon[]>().ToList().ForEach(x => pf.Polygons.Add(x));

            return pf;
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(MultiPolygon);
    }
}