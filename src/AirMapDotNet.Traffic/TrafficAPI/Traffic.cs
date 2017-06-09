using System;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.TrafficAPI
{
    /// <summary>
    /// Represents an airborne craft for situational awareness purposes.
    /// </summary>
    public class Traffic : AirMapEntity
    {
        /// <summary>
        /// One nautical mile is defined as exactly 1,852 meters.
        /// </summary>
        private const int NM_TO_METERS = 1852;

        /// <summary>
        /// This traffic instance's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; internal set; }

        /// <summary>
        /// The direction of the aircraft relative to the UAS flight in degrees true.
        /// </summary>
        [JsonProperty("direction")]
        public double Direction { get; internal set; } = -1;
        /// <summary>
        /// The traffic's altitude in feet MSL.
        /// </summary>
        [JsonProperty("altitude")]
        public double Altitude { get; internal set; }

        /// <summary>
        /// Ground speed in knots.
        /// </summary>
        [JsonProperty("ground_speed_kts")]
        public int GroundSpeed { get; internal set; } = -1;

        /// <summary>
        /// True heading in degrees.
        /// </summary>
        [JsonProperty("true_heading")]
        public int TrueHeading { get; internal set; } = -1;

        /// <summary>
        /// The traffic's position at time received.
        /// </summary>
        [JsonIgnore]
        public LatLon InitialLatLon
            => new LatLon(Latitude, Longitude);

        /// <summary>
        /// The traffic's extrapolated position.
        /// </summary>
        [JsonIgnore]
        public LatLon LatLon
        {
            get
            {
                TimeSpan diff = RecordedTime - DateTime.UtcNow;
                
                double nmTraverse = diff.TotalHours*GroundSpeed;
                
                return InitialLatLon.Project(TrueHeading, nmTraverse * NM_TO_METERS);
            }
        }

        /// <summary>
        /// The traffic type.  See <see cref="TrafficAPI.TrafficType"/>.
        /// </summary>
        [JsonIgnore]
        public TrafficType TrafficType { get; internal set; }

        /// <summary>
        /// The time the message was sent to the client.
        /// </summary>
        [JsonIgnore]
        public DateTime Timestamp
            => Utilities.DateTimeFromTimestamp(Timestamp_Unix);

        /// <summary>
        /// The time the aircraft's position was last recorded.
        /// </summary>
        [JsonIgnore]
        public DateTime RecordedTime
            => Utilities.DateTimeFromTimestamp(RecordedTime_Unix * 1000); // Recorded time comes back in seconds

        /// <summary>
        /// The aircraft's tail number OR flight number.
        /// </summary>
        public string AircraftID
            => Properties?.AircraftID;

        /// <summary>
        /// The aircraft's type code.
        /// </summary>
        public string AircraftType
            => Properties?.AircraftType;

        [JsonProperty("properties")]
        private TrafficProperties Properties { get; }

        [JsonProperty("timestamp")]
        private long Timestamp_Unix { get; }
        [JsonProperty("recorded_time")]
        private long RecordedTime_Unix { get; }

        [JsonProperty("latitude")]
        private double Latitude { get; }
        [JsonProperty("longitude")]
        private double Longitude { get; }
    }
}