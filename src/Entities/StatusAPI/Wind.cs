using Newtonsoft.Json;

namespace AirMapDotNet.Entities.StatusAPI
{
    /// <summary>
    /// Describes current wind conditions.
    /// </summary>
    public class Wind
    {
        /// <summary>
        /// The direction the wind is coming <i>from</i>.
        /// </summary>
        [JsonProperty("heading")]
        public double Heading { get; internal set; }

        /// <summary>
        /// The wind speeds in km/h.
        /// </summary>
        [JsonProperty("speed")]
        public double Speed { get; internal set; }

        /// <summary>
        /// The wind gusts in km/h.
        /// </summary>
        [JsonProperty("gusting")]
        public double Gusts { get; internal set; }
    }
}