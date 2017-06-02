using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal sealed class BoundingBoxConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            BoundingBox bbox = value as BoundingBox;

            if (bbox == null)
                throw new AirMapException("Failed to write GeoJSON:  Supposed Position is not a BoundingBox!");
            
            bool write3d = Math.Abs(bbox.SouthWest.Elevation) > Position.Epsilon ||
                           Math.Abs(bbox.NorthEast.Elevation) > Position.Epsilon;

            writer.WriteStartArray();
            writer.WriteValue(bbox.SouthWest.LatLon.Longitude);
            writer.WriteValue(bbox.SouthWest.LatLon.Latitude);
            if (write3d)
                writer.WriteValue(bbox.SouthWest.Elevation);
            writer.WriteValue(bbox.NorthEast.LatLon.Longitude);
            writer.WriteValue(bbox.NorthEast.LatLon.Latitude);
            if (write3d)
                writer.WriteValue(bbox.NorthEast.Elevation);
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

            switch (val.Length)
            {
                case 2:
                    return new BoundingBox(
                        new Position(new LatLon(val[1], val[0])),
                        new Position(new LatLon(val[3], val[2]))
                    );
                case 3:
                    return new BoundingBox
                    (
                        new Position(new LatLon(val[1], val[0]), val[2]),
                        new Position(new LatLon(val[4], val[3]), val[5])
                    );
            }

            throw new AirMapException("Failed to write GeoJSON:  Bounding box must be exactly 4 or 6 elements long.");
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(BoundingBox);
        }
    }
}