using System;
using AirMapDotNet.Entities.GeoJSON;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.FlightAPI
{
    /// <summary>
    /// Provides flight creation parameters to the AirMap API.
    /// </summary>
    public class FlightCreationParameters
    {
        /// <summary>
        /// The latitude of the takeoff point in degrees.
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude of the takeoff point in degrees.
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// The maximum altitude above the ground in meters.
        /// </summary>
        /// <value>Must be between 0 and 121 meters (400 feet).</value>
        [JsonProperty("max_altitude")]
        public double MaxAltitude { get; set; }

        /// <summary>
        /// The aircraft associated with the flight.
        /// </summary>
        [JsonProperty("aircraft_id")]
        public string AircraftID { get; set; }

        /// <summary>
        /// Takeoff time.
        /// </summary>
        /// <value>Must be between now (UTC) and +7 days from now.</value>
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Landing time.
        /// </summary>
        /// <value>Must be less than four hours from <see cref="StartTime"/>.</value>
        [JsonProperty("end_time")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Make the flight publically visible.
        /// </summary>
        [JsonProperty("public")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// Give digital notice to the relevant authorities.
        /// </summary>
        [JsonProperty("notify")]
        public bool Notify { get; set; }

        /// <summary>
        /// The buffer size around the takeoff point or a <see cref="LineString"/> in meters.
        /// </summary>
        /// <value>Value must be between 0 and 2,000 meters.</value>
        [JsonProperty("buffer")]
        public double Buffer { get; set; }

        /// <summary>
        /// Optional geometry attribute.  Leave null to make this flight point-radius.
        /// </summary>
        /// <remarks>The only two accepted geometries are <see cref="LineString"/> and <see cref="Polygon"/>.</remarks>
        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }
    }
}