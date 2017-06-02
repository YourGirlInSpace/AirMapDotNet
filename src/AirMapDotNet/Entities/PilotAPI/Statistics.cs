using System;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.PilotAPI
{
    /// <summary>
    /// General statistics of a pilot, including flight time, and total aircraft count.
    /// </summary>
    public class Statistics
    {
        [JsonProperty("flight")]
        internal Flight flight { get; set; }

        [JsonProperty("aircraft")]
        internal Aircraft aircraft { get; set; }

        /// <summary>
        /// Total number of hours logged by this pilot on AirMap.
        /// </summary>
        [JsonIgnore]
        public int TotalFlightTime => flight.total;

        /// <summary>
        /// The last known flight time in UTC.
        /// </summary>
        [JsonIgnore]
        public DateTime LastFlightTime => flight.last_flight_time;

        /// <summary>
        /// The total number of aircraft the pilot has.
        /// </summary>
        [JsonIgnore]
        public int NumberOfAircraft => aircraft.total;

        internal class Flight
        {
            public int total { get; set; }
            public DateTime last_flight_time { get; set; }
        }

        internal class Aircraft
        {
            public int total { get; set; }
        }

    }
}