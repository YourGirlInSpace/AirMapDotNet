using System;
using System.Linq;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal sealed class PolygonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            Polygon mpf = value as Polygon;

            if (mpf == null)
                throw new AirMapException($"Failed to write GeoJSON:  {nameof(value)} is not a PolygonFeature!");

            writer.WriteStartArray();

            foreach (LineString pos in mpf.Boundaries)
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

            Polygon pf = new Polygon();
            pointArray.ToObject<LineString[]>().ToList().ForEach(x => pf.Boundaries.Add(x));
            
            return pf;
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(Polygon);
    }
}