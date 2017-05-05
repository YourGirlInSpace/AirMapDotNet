using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal sealed class PositionConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            Position pos = value as Position;

            if (pos == null)
                throw new AirMapException("Failed to write GeoJSON:  Supposed Position is not a Position!");
            
            writer.WriteStartArray();
            writer.WriteValue(pos.LatLon.Longitude);
            writer.WriteValue(pos.LatLon.Latitude);

            if (Math.Abs(pos.Elevation) > Position.Epsilon)
                writer.WriteValue(pos.Elevation);
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

            JToken jt = JToken.ReadFrom(reader);
            double[] val = jt.ToObject<double[]>();

            Position pos = new Position {LatLon = new LatLon(val[1], val[0])};

            if (val.Length > 2)
                pos.Elevation = val[2];

            return pos;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Position);
        }
    }
}