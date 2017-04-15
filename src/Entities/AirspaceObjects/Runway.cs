using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Represents an airport's runway.
    /// </summary>
    public class Runway
    {
        /// <summary>
        /// The identifier of the runway.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// The length of the runway in feet.
        /// </summary>
        [JsonProperty("length")]
        public double Length { get; }

        /// <summary>
        /// The true bearing of the runway in degrees.
        /// </summary>
        [JsonProperty("bearing")]
        public double Bearing { get; }
    }
}