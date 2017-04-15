using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Represents an airport.
    /// </summary>
    [ObjectType("airport")]
    public class Airport : AirspaceObject
    {
        /// <summary>
        /// The airport's IATA code.
        /// </summary>
        public string IATA => Properties["iata"]?.ToString();

        /// <summary>
        /// The airport's ICAO code.
        /// </summary>
        public string ICAO => Properties["icao"]?.ToString();

        /// <summary>
        /// <b>True</b> if the airport has a paved runway.
        /// </summary>
        public bool Paved => (bool) Properties["paved"];

        /// <summary>
        /// The phone number of the airport manager or person of authority.
        /// </summary>
        public string Phone => Properties["phone"]?.ToString() ?? "";

        /// <summary>
        /// <b>True</b> if the airport has a staffed air traffic control tower.
        /// </summary>
        public bool Tower => (bool) Properties["tower"];

        /// <summary>
        /// The runways at this airport.
        /// </summary>
        public Collection<Runway> Runways => (Collection<Runway>) Properties["runways"];

        /// <summary>
        /// The elevation of the airport in feet.
        /// </summary>
        public double Elevation => (double) Properties["elevation"];

        /// <summary>
        /// The longest runway at this airport in feet.
        /// </summary>
        public double LongestRunway => (double) Properties["longest_runway"];

        /// <summary>
        /// <b>True</b> if the airport has an instrument approach procedure.
        /// </summary>
        public bool InstrumentApproach => (bool) Properties["instrument_approach_procedure"];

        /// <summary>
        /// The usage of the airport.
        /// </summary>
        /// <value>"public" or "private".</value>
        public bool Use => (bool) Properties["use"];

        /// <summary>
        /// The flight rules associated with this airport.
        /// </summary>
        [JsonProperty("rules")]
        public Collection<Rule> Rules { get; }
    }
}