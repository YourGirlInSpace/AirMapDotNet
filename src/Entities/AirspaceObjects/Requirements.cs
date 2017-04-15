using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Describes the requirements to fly in or around an <see cref="AirspaceObject"/>.
    /// </summary>
    public class Requirements
    {
        /// <summary>
        /// The routes of notice this object requires.
        /// </summary>
        [JsonProperty("notice")]
        public Notice Notice { get; internal set; }
    }

    /// <summary>
    /// Describes the routes of notice that an <see cref="AirspaceObject"/> provides.
    /// </summary>
    public class Notice
    {
        /// <summary>
        /// If <b>true</b>, digital notification are supported.
        /// </summary>
        [JsonProperty("digital")]
        public bool DigitalEnabled { get; internal set; }

        /// <summary>
        /// The phone number of the airport manager or person of authority.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; internal set; }
    }
}