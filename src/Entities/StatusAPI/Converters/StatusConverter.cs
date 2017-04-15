using System;
using AirMapDotNet.Entities.AirspaceObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AirMapDotNet.Entities.StatusAPI.Converters
{
    internal class StatusConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // Do nothing.  We don't need to reserialize this class.
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

            JToken advColorToken = jsonObj["advisory_color"];
            JToken msdToken = jsonObj["max_safe_distance"];
            JToken advisoriesToken = jsonObj["advisories"];
            JToken weatherToken = jsonObj["weather"];

            if (advColorToken == null)
                throw new AirMapException("Failed to read GeoJSON:  \"advisory_color\" property missing!");
            if (msdToken == null)
                throw new AirMapException("Failed to read GeoJSON:  \"max_safe_distance\" property missing!");
            if (advisoriesToken == null)
                throw new AirMapException("Failed to read GeoJSON:  \"advisories\" property missing!");
            if (weatherToken == null)
                throw new AirMapException("Failed to read GeoJSON:  \"weather\" property missing!");

            Status status = new Status
            {
                AdvisoryColor = advColorToken.Value<string>(),
                MaxSafeDistance = msdToken.Value<double>(),
                Weather = weatherToken.ToObject<Weather>()
            };
            
            foreach (JToken adv in advisoriesToken)
                status.Advisories.Add(AirspaceObject.Deserialize(adv.ToString()));
            
            return status;
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(Status);
    }
}