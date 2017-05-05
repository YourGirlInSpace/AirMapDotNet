using System.Collections.ObjectModel;
using AirMapDotNet.Entities.AirspaceObjects;
using AirMapDotNet.Entities.StatusAPI.Converters;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.StatusAPI
{
    /// <summary>
    /// Provides the current status of a proposed flight area.
    /// </summary>
    [JsonConverter(typeof(StatusConverter))]
    public sealed class Status : AirMapEntity
    {
        /// <summary>
        /// The distance between a flight's takeoff point and the nearest yellow or red zone in meters.
        /// </summary>
        [JsonProperty("max_safe_distance")]
        public double MaxSafeDistance { get; internal set; }

        /// <summary>
        /// The advisory color.
        /// </summary>
        /// <remarks>
        /// <para>The color follows a simple traffic light pattern.</para>
        /// <para>Green
        /// indicates that there are no known advisories, and it is probably
        /// safe to fly.</para>
        /// <para>Yellow indicates that the operator may require
        /// additional authorization or actions to fly in the area.</para>
        /// <para>Red indicates that the flight area is strictly regulated and
        /// is probably not safe to fly for the majority of operators.</para>
        /// </remarks>
        [JsonProperty("advisory_color")]
        public string AdvisoryColor { get; internal set; }

        /// <summary>
        /// A list of all <see cref="AirspaceObject"/>s intersecting the proposed flight.
        /// </summary>
        [JsonProperty("advisories")]
        public Collection<AirspaceObject> Advisories { get; } = new Collection<AirspaceObject>();

        /// <summary>
        /// A <see cref="Weather"/> object containing current weather conditions.
        /// </summary>
        [JsonProperty("weather")]
        public Weather Weather { get; internal set; }
    }
}