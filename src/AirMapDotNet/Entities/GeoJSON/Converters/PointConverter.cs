using System;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal sealed class PointConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            Point point = value as Point;

            if (point == null)
                throw new AirMapException($"Failed to write GeoJSON:  {nameof(value)} is not a Geometry!");

            serializer.Serialize(writer, point.Position);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));
            if (objectType == null)
                throw new ArgumentNullException(nameof(objectType));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            JToken jt = JToken.ReadFrom(reader);

            Position position = jt.ToObject<Position>();

            return new Point
            {
                Position = position
            };
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(Point);
    }
}