using System;
using System.Linq;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.GeoJSON.Converters
{
    internal class GeometryCollectionConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (serializer == null)
                throw new ArgumentNullException(nameof(serializer));

            GeometryCollection mpf = value as GeometryCollection;

            if (mpf == null)
                throw new AirMapException($"Failed to write GeoJSON:  {nameof(value)} is not a GeometryCollection!");

            writer.WriteStartArray();

            foreach (Geometry pos in mpf.Geometries)
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

            GeometryCollection pf = new GeometryCollection();
            pointArray.ToObject<Geometry[]>().ToList().ForEach(x => pf.Geometries.Add(x));

            return pf;
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(GeometryCollection);
    }
}