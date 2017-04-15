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
    public class Flight : AirMapEntity
    {
        /// <summary>
        /// The flight's unique ID.
        /// </summary>
        /// <value>The flight's unique ID in a GUID-style string.</value>
        [JsonProperty("id", Required = Required.Always)]
        public virtual string ID { get; set; }

        /// <summary>
        /// The ID of the pilot who created the flight.
        /// </summary>
        /// <remarks>Can be replaced with <see cref="Pilot"/> if the <c>enhance</c> query is set to <i>true</i>.</remarks>
        [JsonProperty("pilot_id")]
        public virtual string PilotID { get; set; }

        /// <summary>
        /// The central latitude of the flight.
        /// </summary>
        /// <remarks>Along with <see cref="Longitude"/>, this usually denotes the pilot's location.</remarks>
        [JsonProperty("latitude", Required = Required.Always)]
        public virtual double Latitude { get; set; }

        /// <summary>
        /// The central longitude of the flight.
        /// </summary>
        /// <remarks>Along with <see cref="Latitude"/>, this usually denotes the pilot's location.</remarks>
        [JsonProperty("longitude", Required = Required.Always)]
        public virtual double Longitude { get; set; }

        /// <summary>
        /// The aircraft being flown.
        /// </summary>
        /// <remarks>Can be replaced with <see cref="Aircraft"/> if the <c>enhance</c> query is set to <i>true</i>.</remarks>
        [JsonProperty("aircraft_id")]
        public virtual string AircraftID { get; set; }

        /// <summary>
        /// The time when this flight was created.
        /// </summary>
        /// <remarks>Requires authentication.</remarks>
        [JsonProperty("created_at")]
        public virtual DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time when the flight starts.
        /// </summary>
        [JsonProperty("start_time", Required = Required.Always)]
        public virtual DateTime StartTime { get; set; }

        /// <summary>
        /// The time when the flight ends.
        /// </summary>
        [JsonProperty("end_time", Required = Required.Always)]
        public virtual DateTime EndTime { get; set; }

        /// <summary>
        /// The country where the flight is being conducted.
        /// </summary>
        [JsonProperty("country")]
        public virtual string Country { get; set; }

        /// <summary>
        /// The state where the flight is being conducted.
        /// </summary>
        [JsonProperty("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The city where the flight is being conducted.
        /// </summary>
        [JsonProperty("city")]
        public virtual string City { get; set; }

        /// <summary>
        /// If <i>true</i>, the flight is publically visible.
        /// </summary>
        [JsonProperty("public")]
        public virtual bool IsPublic { get; set; }

        // TODO: Ask about this
        /// <summary>
        /// NFC
        /// </summary>
        [JsonProperty("permits")]
        public virtual object Permits { get; set; }

        /// <summary>
        /// A description of the flight area.
        /// </summary>
        [JsonProperty("geometry", Required = Required.Always)]
        public virtual Geometry Geometry { get; set; }

        /// <summary>
        /// The buffer radius around the <see cref="Geometry"/> in meters.
        /// </summary>
        [JsonProperty("buffer")]
        public virtual double Buffer { get; set; }

        /// <summary>
        /// The maximum flight altitude in meters.
        /// </summary>
        [JsonProperty("max_altitude", Required = Required.Always)]
        public virtual double MaxAltitude { get; set; }

        /// <summary>
        /// The pilot conducting this flight.
        /// </summary>
        /// <remarks>Can be replaced with <see cref="PilotID"/> if the <c>enhance</c> query is set to <i>false</i>.</remarks>
        [JsonProperty("pilot")]
        public virtual PilotProfile Pilot { get; set; }

        /// <summary>
        /// The aircraft being flown.
        /// </summary>
        /// <remarks>Can be replaced with <see cref="AircraftID"/> if the <c>enhance</c> query is set to <i>false</i>.</remarks>
        [JsonProperty("aircraft")]
        public virtual Aircraft Aircraft { get; set; }
    }
}