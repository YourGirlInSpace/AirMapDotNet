using System;
using System.Diagnostics;
using AirMapDotNet.Entities.AircraftAPI;
using AirMapDotNet.Entities.GeoJSON;
using AirMapDotNet.Entities.PilotAPI;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.FlightAPI
{
    /// <summary>
    /// Represents a flight event.
    /// </summary>
    [DebuggerDisplay("Flight #{ID}")]
    public sealed class Flight : AirMapEntity
    {
        /// <summary>
        /// The flight's unique ID.
        /// </summary>
        /// <value>The flight's unique ID in a GUID-style string.</value>
        [JsonProperty("id", Required = Required.Always)]
        public string ID { get; internal set; }

        /// <summary>
        /// The ID of the pilot who created the flight.
        /// </summary>
        /// <remarks>Can be replaced with <see cref="Pilot"/> if the <c>enhance</c> query is set to <i>true</i>.</remarks>
        [JsonProperty("pilot_id")]
        public string PilotID { get; internal set; }

        /// <summary>
        /// The central latitude of the flight.
        /// </summary>
        /// <remarks>Along with <see cref="Longitude"/>, this usually denotes the pilot's location.</remarks>
        [JsonProperty("latitude", Required = Required.Always)]
        public double Latitude { get; internal set; }

        /// <summary>
        /// The central longitude of the flight.
        /// </summary>
        /// <remarks>Along with <see cref="Latitude"/>, this usually denotes the pilot's location.</remarks>
        [JsonProperty("longitude", Required = Required.Always)]
        public double Longitude { get; internal set; }

        /// <summary>
        /// The aircraft being flown.
        /// </summary>
        /// <remarks>Can be replaced with <see cref="Aircraft"/> if the <c>enhance</c> query is set to <i>true</i>.</remarks>
        [JsonProperty("aircraft_id")]
        public string AircraftID { get; internal set; }

        /// <summary>
        /// The time when this flight was created.
        /// </summary>
        /// <remarks>Requires authentication.</remarks>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; internal set; }

        /// <summary>
        /// The time when the flight starts.
        /// </summary>
        [JsonProperty("start_time", Required = Required.Always)]
        public DateTime StartTime { get; internal set; }

        /// <summary>
        /// The time when the flight ends.
        /// </summary>
        [JsonProperty("end_time", Required = Required.Always)]
        public DateTime EndTime { get; internal set; }

        /// <summary>
        /// The country where the flight is being conducted.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; internal set; }

        /// <summary>
        /// The state where the flight is being conducted.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; internal set; }

        /// <summary>
        /// The city where the flight is being conducted.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; internal set; }

        /// <summary>
        /// If <i>true</i>, the flight is publically visible.
        /// </summary>
        [JsonProperty("public")]
        public bool IsPublic { get; internal set; }

        // Related to flight permits by an ATC facility
        /// <summary>
        /// NFC
        /// </summary>
        [JsonProperty("permits")]
        public object Permits { get; internal set; }

        /// <summary>
        /// A description of the flight area.
        /// </summary>
        [JsonProperty("geometry", Required = Required.Always)]
        public Geometry Geometry { get; internal set; }

        /// <summary>
        /// The buffer radius around the <see cref="Geometry"/> in meters.
        /// </summary>
        [JsonProperty("buffer")]
        public double Buffer { get; internal set; }

        /// <summary>
        /// The maximum flight altitude in meters.
        /// </summary>
        [JsonProperty("max_altitude", Required = Required.Always)]
        public double MaxAltitude { get; internal set; }

        /// <summary>
        /// The pilot conducting this flight.
        /// </summary>
        /// <remarks>Can be replaced with <see cref="PilotID"/> if the <c>enhance</c> query is set to <i>false</i>.</remarks>
        [JsonProperty("pilot")]
        public PilotProfile Pilot { get; internal set; }

        /// <summary>
        /// The aircraft being flown.
        /// </summary>
        /// <remarks>Can be replaced with <see cref="AircraftID"/> if the <c>enhance</c> query is set to <i>false</i>.</remarks>
        [JsonProperty("aircraft")]
        public Aircraft Aircraft { get; internal set; }
    }
}