using System;
using System.Linq;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal sealed class LineStringConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            LineString mpf = value as LineString;

            if (mpf == null)
                throw new AirMapException($"Failed to write GeoJSON:  {nameof(value)} is not a LineStringFeature!");

            writer.WriteStartArray();

            foreach (Position pos in mpf.Points)
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

            LineString pf = new LineString();

            foreach (var x in pointArray.ToObject<Position[]>())
                pf.Points.Add(x);

            return pf;
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(LineString);
    }
}