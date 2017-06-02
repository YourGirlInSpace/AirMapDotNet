using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Threading.Tasks;
using AirMapDotNet.Entities.GeoJSON;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using AirMapDotNet.Entities.StatusAPI;
using Newtonsoft.Json;

namespace AirMapDotNet.Services
{
    /// <summary>
    /// Exposes several methods for the Status API.
    /// </summary>
    internal class StatusService : AirMapService
    {
        internal StatusService(AirMap am)
            : base(am)
        { }
        
        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied position and a radius <paramref name="buffer"/> around the position, with optional weather information.
        /// </summary>
        /// <param name="latlon">The <see cref="LatLon"/> of the launch point.</param>
        /// <param name="buffer">The radius to include around the launch point.</param>
        /// <param name="weather">If <b>true</b>, weather information will be supplied in the response.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="latlon"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="buffer"/> is not in the range 0 to 10000.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        internal async Task<Status> GetStatus(LatLon latlon, double buffer, bool weather)
        {
            if (latlon == null)
                throw new ArgumentNullException(nameof(latlon));
            if (buffer < 0 || buffer > 10000)
                throw new ArgumentOutOfRangeException(nameof(buffer), $"{nameof(buffer)} must be between 0 and 10000.");

            Href<Status> statusLink = new Href<Status>(new Uri(AirMap_Status_ByPoint));

            NameValueCollection parms = new NameValueCollection
            {
                ["latitude"] = latlon.Latitude.ToString(CultureInfo.InvariantCulture),
                ["longitude"] = latlon.Longitude.ToString(CultureInfo.InvariantCulture),
                ["weather"] = weather ? "true" : "false",
                ["buffer"] = buffer.ToString(CultureInfo.InvariantCulture)
            };

            return await AirMap.GetAsync(statusLink, parms);
        }

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied geometry and a radius <paramref name="buffer"/> around the geometry, with optional weather information.
        /// </summary>
        /// <param name="geom">The geometry of the flight area.</param>
        /// <param name="buffer">The buffer around a <see cref="LineString"/>.</param>
        /// <param name="weather">If <b>true</b>, weather information will be supplied in the response.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="AirMapException">If <paramref name="geom"/> is not a <see cref="LineString"/> or <see cref="Polygon"/>.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="geom"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="buffer"/> is not in the range 0 to 10000.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        internal async Task<Status> GetStatus(Geometry geom, double buffer, bool weather)
        {
            if (geom == null)
                throw new ArgumentNullException(nameof(geom));
            if (buffer < 0 || buffer > 10000)
                throw new ArgumentOutOfRangeException(nameof(buffer), $"{nameof(buffer)} must be between 0 and 10000.");

            Href<Status> statusLink;

            if (geom.GeometryObject is LineString)
                statusLink = new Href<Status>(new Uri(AirMap_Status_ByPath));
            else if (geom.GeometryObject is Polygon)
                statusLink = new Href<Status>(new Uri(AirMap_Status_ByPolygon));
            else throw new AirMapException("The only accepted geometries are LineString and Polygon!");

            NameValueCollection parms = new NameValueCollection
            {
                ["geom"] = JsonConvert.SerializeObject(geom),
                ["weather"] = weather ? "true" : "false"
            };

            if (geom.GeometryObject is LineString)
                parms.Add("buffer", buffer.ToString(CultureInfo.InvariantCulture));

            return await AirMap.GetAsync(statusLink, parms);
        }
    }
}