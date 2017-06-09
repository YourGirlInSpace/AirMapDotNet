using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities.FlightAPI;
using AirMapDotNet.Entities.GeoJSON;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using AirMapDotNet.Services;

namespace AirMapDotNet
{
    public partial class AirMap
    {
        private readonly FlightService _flightService;

        /// <summary>
        /// The default maximum limit for requests.
        /// </summary>
        private const int DefaultLimit = 1000;
        /// <summary>
        /// The default enhancement state for requests.
        /// </summary>
        private const bool DefaultEnhance = false;

        /// <summary>
        /// Retrieves flight by its ID.
        /// </summary>
        /// <param name="id">The flight's unique ID.</param>
        /// <returns>The flight with the ID <paramref name="id"/>.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="id"/> is null.</exception>
        public Task<Flight> GetFlight(string id)
            => GetFlight(id, DefaultEnhance);

        /// <summary>
        /// Retrieves flight by its ID.
        /// </summary>
        /// <param name="id">The flight's unique ID.</param>
        /// <param name="enhance">If <b>true</b>, the response will populate detailed fields such as <i>aircraft</i> or <i>pilot</i>.</param>
        /// <returns>The flight with the ID <paramref name="id"/>.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="id"/> is null.</exception>
        public async Task<Flight> GetFlight(string id, bool enhance)
            => await _flightService.GetFlight(id, enhance);

        /// <summary>
        /// Retrieves a list of all flights within a geographic area.
        /// </summary>
        /// <param name="geoJson">A description of the area to request in <a href="http://geojson.org/">GeoJSON</a> format.</param>
        /// <returns>A list of all flights inside the area defined in <paramref name="geoJson"/>.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="geoJson"/> is null or equals <see cref="string.Empty"/>.</exception>
        public async Task<IEnumerable<Flight>> GetFlights(string geoJson)
            => await GetFlights(geoJson, DefaultLimit, DefaultEnhance);

        /// <summary>
        /// Retrieves a list of all flights within a geographic area.
        /// </summary>
        /// <param name="geoJson">A description of the area to request in <a href="http://geojson.org/">GeoJSON</a> format.</param>
        /// <param name="enhance">If <b>true</b>, the response will populate detailed fields such as <i>aircraft</i> or <i>pilot</i>.</param>
        /// <returns>A list of all flights inside the area defined in <paramref name="geoJson"/>.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="geoJson"/> is null or equals <see cref="string.Empty"/>.</exception>
        public async Task<IEnumerable<Flight>> GetFlights(string geoJson, bool enhance)
            => await GetFlights(geoJson, DefaultLimit, enhance);

        /// <summary>
        /// Retrieves a list of all flights within a geographic area.
        /// </summary>
        /// <param name="geoJson">A description of the area to request in <a href="http://geojson.org/">GeoJSON</a> format.</param>
        /// <param name="limit">The maximum amount of flights to retrieve in a request.</param>
        /// <returns>A list of all flights inside the area defined in <paramref name="geoJson"/>.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="geoJson"/> is null or equals <see cref="string.Empty"/>.</exception>
        public async Task<IEnumerable<Flight>> GetFlights(string geoJson, int limit)
            => await GetFlights(geoJson, limit, DefaultEnhance);

        /// <summary>
        /// Retrieves a list of all flights within a geographic area.
        /// </summary>
        /// <param name="geom">A bounding geometry.</param>
        /// <param name="limit">The maximum amount of flights to retrieve in a request.</param>
        /// <returns>A list of all flights inside the area defined in <paramref name="geom"/>.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AirMapException">If the serialization of <paramref name="geom"/> fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="geom"/> is null.</exception>
        public Task<IEnumerable<Flight>> GetFlights(Geometry geom, int limit)
            => _flightService.GetFlights(geom, limit);

        /// <summary>
        /// Retrieves a list of all flights within a geographic area.
        /// </summary>
        /// <param name="geoJson">A description of the area to request in <a href="http://geojson.org/">GeoJSON</a> format.</param>
        /// <param name="limit">The maximum amount of flights to retrieve in a request.</param>
        /// <param name="enhance">If <b>true</b>, the response will populate detailed fields such as <i>aircraft</i> or <i>pilot</i>.</param>
        /// <returns>A list of all flights inside the area defined in <paramref name="geoJson"/>.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="geoJson"/> is null or equals <see cref="string.Empty"/>.</exception>
        public Task<IEnumerable<Flight>> GetFlights(string geoJson, int limit, bool enhance)
            => _flightService.GetFlights(geoJson, limit, enhance);

        /// <summary>
        /// Retrieves a list of all currently active flights within a geographic area.
        /// </summary>
        /// <param name="geom">The geographic area to search.</param>
        /// <returns>A list of allcurrently active flights in the area defined by <paramref name="geom"/>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="geom"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<IEnumerable<Flight>> GetCurrentFlights(Geometry geom)
            => await GetCurrentFlights(geom, DefaultLimit, DefaultEnhance);

        /// <summary>
        /// Retrieves a list of all currently active flights within a geographic area.
        /// </summary>
        /// <param name="geom">The geographic area to search.</param>
        /// <param name="enhance">If <b>true</b>, the returned data will be enhanced with extra information.</param>
        /// <returns>A list of allcurrently active flights in the area defined by <paramref name="geom"/>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="geom"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<IEnumerable<Flight>> GetCurrentFlights(Geometry geom, bool enhance)
            => await GetCurrentFlights(geom, DefaultLimit, enhance);

        /// <summary>
        /// Retrieves a list of all currently active flights within a geographic area.
        /// </summary>
        /// <param name="geom">The geographic area to search.</param>
        /// <param name="limit">The maximum amount of flights to return.</param>
        /// <returns>A list of allcurrently active flights in the area defined by <paramref name="geom"/>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="geom"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<IEnumerable<Flight>> GetCurrentFlights(Geometry geom, int limit)
            => await GetCurrentFlights(geom, limit, DefaultEnhance);


        /// <summary>
        /// Retrieves a list of all currently active flights within a geographic area.
        /// </summary>
        /// <param name="geom">The geographic area to search.</param>
        /// <param name="limit">The maximum amount of flights to return.</param>
        /// <param name="enhance">If <b>true</b>, the returned data will be enhanced with extra information.</param>
        /// <returns>A list of allcurrently active flights in the area defined by <paramref name="geom"/>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="geom"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<IEnumerable<Flight>> GetCurrentFlights(Geometry geom, int limit, bool enhance)
            => _flightService.GetCurrentFlights(geom, limit, enhance);

        /// <summary>
        /// Retrieves a list of all flights created by the currently authenticated user.
        /// </summary>
        /// <returns>A list of all flights created by the currently authenticated user.</returns>
        /// <exception cref="AuthenticationException">If the <see cref="AirMap.AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<IEnumerable<Flight>> GetMyFlights()
            => _flightService.GetMyFlights(DefaultLimit, DefaultEnhance);

        /// <summary>
        /// Retrieves a list of all flights created by the currently authenticated user.
        /// </summary>
        /// <param name="limit">The maximum amount of flights to return.</param>
        /// <returns>A list of all flights created by the currently authenticated user.</returns>
        /// <exception cref="AuthenticationException">If the <see cref="AirMap.AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<IEnumerable<Flight>> GetMyFlights(int limit)
            => _flightService.GetMyFlights(limit, DefaultEnhance);

        /// <summary>
        /// Retrieves a list of all flights created by the currently authenticated user.
        /// </summary>
        /// <param name="enhance">If <b>true</b>, the returned data will be enhanced with extra information.</param>
        /// <returns>A list of all flights created by the currently authenticated user.</returns>
        /// <exception cref="AuthenticationException">If the <see cref="AirMap.AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<IEnumerable<Flight>> GetMyFlights(bool enhance)
            => _flightService.GetMyFlights(DefaultLimit, enhance);

        /// <summary>
        /// Retrieves a list of all flights created by the currently authenticated user.
        /// </summary>
        /// <param name="limit">The maximum amount of flights to return.</param>
        /// <param name="enhance">If <b>true</b>, the returned data will be enhanced with extra information.</param>
        /// <returns>A list of all flights created by the currently authenticated user.</returns>
        /// <exception cref="AuthenticationException">If the <see cref="AirMap.AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<IEnumerable<Flight>> GetMyFlights(int limit, bool enhance)
            => _flightService.GetMyFlights(limit, enhance);

        /// <summary>
        /// Creates a new flight using the parameters in <see cref="FlightCreationParameters"/>.
        /// </summary>
        /// <param name="creationParams">The parameters of the new flight.</param>
        /// <returns>The created flight.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="AirMapException">If the <see cref="FlightCreationParameters.Geometry"/> property of <paramref name="creationParams"/> is not a <see cref="LineString"/> or <see cref="Polygon"/>.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<Flight> CreateFlight(FlightCreationParameters creationParams)
            => _flightService.CreateFlight(creationParams);

        /// <summary>
        /// Deletes a flight.
        /// </summary>
        /// <param name="flight">The flight.</param>
        /// <returns><b>True</b> if the deletion was successful.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="flight"/> is null.</exception>
        public Task<bool> DeleteFlight(Flight flight)
        {
            if (flight == null)
                throw new ArgumentNullException(nameof(flight));

            return DeleteFlight(flight.ID);
        }

        /// <summary>
        /// Deletes a flight by its unique ID.
        /// </summary>
        /// <param name="flightId">The flight's unique ID.</param>
        /// <returns><b>True</b> if the deletion was successful.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="flightId"/> is null.</exception>
        public Task<bool> DeleteFlight(string flightId)
            => _flightService.DeleteFlight(flightId);

        /// <summary>
        /// Ends a flight.
        /// </summary>
        /// <param name="flight">The flight.</param>
        /// <returns>The time the flight was ended.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="flight"/> is null.</exception>
        public async Task<DateTime> EndFlight(Flight flight)
        {
            if (flight == null)
                throw new ArgumentNullException(nameof(flight));

            return await EndFlight(flight.ID);
        }

        /// <summary>
        /// Ends a flight by its unique ID.
        /// </summary>
        /// <param name="flightId">The flight's unique ID.</param>
        /// <returns>The time the flight was ended.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="flightId"/> is null.</exception>
        public Task<DateTime> EndFlight(string flightId)
            => _flightService.EndFlight(flightId);
    }
}
