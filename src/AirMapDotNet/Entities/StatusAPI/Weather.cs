using Newtonsoft.Json;

namespace AirMapDotNet.Entities.StatusAPI
{
    /// <summary>
    /// Provides a current snapshot of weather conditions in the flight area.
    /// </summary>
    public sealed class Weather
    {
        /// <summary>
        /// Overall weather conditions, e.g. "partly cloudy"
        /// </summary>
        [JsonProperty("condition")]
        public string Conditions { get; internal set; }

        /// <summary>
        /// The name of the weather icon for the current <see cref="Conditions"/>.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; internal set; }

        /// <summary>
        /// The relative humidity in %.
        /// </summary>
        [JsonProperty("humidity")]
        public double Humidity { get; internal set; }

        /// <summary>
        /// The visibility in kilometers.
        /// </summary>
        [JsonProperty("visibility")]
        public double Visibility { get; internal set; }

        /// <summary>
        /// The probability of rain in %.
        /// </summary>
        [JsonProperty("precipitation")]
        public double Precipitation { get; internal set; }

        /// <summary>
        /// The temperature in degrees Celsius.
        /// </summary>
        [JsonProperty("temperature")]
        public double Temperature { get; internal set; }

        /// <summary>
        /// Current wind conditions.
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; internal set; }
    }
}