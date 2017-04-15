using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Threading.Tasks;
using AirMapDotNet.Entities.GeoJSON;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using AirMapDotNet.Entities.StatusAPI;
using Newtonsoft.Json;

namespace AirMapDotNet
{
    public partial class AirMap
    {
        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied position.
        /// </summary>
        /// <param name="lat">The latitude of the launch point in degrees.</param>
        /// <param name="lon">The longitude of the launch point in degrees.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(double lat, double lon)
               => await GetStatus(lat, lon, 1, true);

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied position.
        /// </summary>
        /// <param name="latlon">The <see cref="LatLon"/> of the launch point.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="latlon"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(LatLon latlon)
            => await GetStatus(latlon, 1, true);

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied position with optional weather information.
        /// </summary>
        /// <param name="lat">The latitude of the launch point in degrees.</param>
        /// <param name="lon">The longitude of the launch point in degrees.</param>
        /// <param name="weather">If <b>true</b>, weather information will be supplied in the response.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(double lat, double lon, bool weather)
            => await GetStatus(new LatLon(lat, lon), 1, weather);

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied position with optional weather information.
        /// </summary>
        /// <param name="latlon">The <see cref="LatLon"/> of the launch point.</param>
        /// <param name="weather">If <b>true</b>, weather information will be supplied in the response.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="latlon"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(LatLon latlon, bool weather)
            => await GetStatus(latlon, 1, weather);

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied position and a radius <paramref name="buffer"/> around the position.
        /// </summary>
        /// <param name="lat">The latitude of the launch point in degrees.</param>
        /// <param name="lon">The longitude of the launch point in degrees.</param>
        /// <param name="buffer">The radius to include around the launch point.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="buffer"/> is not in the range 0 to 10000.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(double lat, double lon, double buffer)
            => await GetStatus(lat, lon, buffer, true);

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied position and a radius <paramref name="buffer"/> around the position.
        /// </summary>
        /// <param name="latlon">The <see cref="LatLon"/> of the launch point.</param>
        /// <param name="buffer">The radius to include around the launch point.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="latlon"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="buffer"/> is not in the range 0 to 10000.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(LatLon latlon, double buffer)
            => await GetStatus(latlon, buffer, true);

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied position and a radius <paramref name="buffer"/> around the position, with optional weather information.
        /// </summary>
        /// <param name="lat">The latitude of the launch point in degrees.</param>
        /// <param name="lon">The longitude of the launch point in degrees.</param>
        /// <param name="buffer">The radius to include around the launch point.</param>
        /// <param name="weather">If <b>true</b>, weather information will be supplied in the response.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="buffer"/> is not in the range 0 to 10000.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(double lat, double lon, double buffer, bool weather)
            => await GetStatus(new LatLon(lat, lon), buffer, weather);

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
        public async Task<Status> GetStatus(LatLon latlon, double buffer, bool weather)
        {
            if (latlon == null)
                throw new ArgumentNullException(nameof(latlon));
            if (buffer < 0 || buffer > 10000)
                throw new ArgumentOutOfRangeException(nameof(buffer), $"{nameof(buffer)} must be between 0 and 10000.");

            Href<Status> statusLink = new Href<Status>(new Uri("https://api.airmap.com/status/v2/point/"));

            NameValueCollection parms = new NameValueCollection
            {
                ["latitude"] = latlon.Latitude.ToString(CultureInfo.InvariantCulture),
                ["longitude"] = latlon.Longitude.ToString(CultureInfo.InvariantCulture),
                ["weather"] = weather ? "true" : "false",
                ["buffer"] = buffer.ToString(CultureInfo.InvariantCulture)
            };

            return await GetAsync(statusLink, parms);
        }

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied geometry.
        /// </summary>
        /// <param name="geom">The geometry of the flight area.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="AirMapException">If <paramref name="geom"/> is not a <see cref="LineString"/> or <see cref="Polygon"/>.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="geom"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(Geometry geom)
            => await GetStatus(geom, 1, true);

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied geometry with optional weather information.
        /// </summary>
        /// <param name="geom">The geometry of the flight area.</param>
        /// <param name="weather">If <b>true</b>, weather information will be supplied in the response.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="AirMapException">If <paramref name="geom"/> is not a <see cref="LineString"/> or <see cref="Polygon"/>.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="geom"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(Geometry geom, bool weather)
            => await GetStatus(geom, 1, weather);

        /// <summary>
        /// Retrieves a <see cref="Status"/> object for a supplied geometry and a radius <paramref name="buffer"/> around the geometry.
        /// </summary>
        /// <param name="geom">The geometry of the flight area.</param>
        /// <param name="buffer">The buffer around a <see cref="LineString"/>.</param>
        /// <returns>A <see cref="Status"/> object describing the status of the flight area.</returns>
        /// <exception cref="AirMapException">If <paramref name="geom"/> is not a <see cref="LineString"/> or <see cref="Polygon"/>.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="geom"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="buffer"/> is not in the range 0 to 10000.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<Status> GetStatus(Geometry geom, double buffer)
            => await GetStatus(geom, buffer, true);

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
        public async Task<Status> GetStatus(Geometry geom, double buffer, bool weather)
        {
            if (geom == null)
                throw new ArgumentNullException(nameof(geom));
            if (buffer < 0 || buffer > 10000)
                throw new ArgumentOutOfRangeException(nameof(buffer), $"{nameof(buffer)} must be between 0 and 10000.");

            Href<Status> statusLink;
            
            if (geom.GeometryObject is LineString)
                statusLink = new Href<Status>(new Uri("https://api.airmap.com/status/v2/path/"));
            else if (geom.GeometryObject is Polygon)
                statusLink = new Href<Status>(new Uri("https://api.airmap.com/status/v2/polygon/"));
            else throw new AirMapException("The only accepted geometries are LineString and Polygon!");

            NameValueCollection parms = new NameValueCollection
            {
                ["geom"] = JsonConvert.SerializeObject(geom),
                ["weather"] = weather ? "true" : "false"
            };

            if (geom.GeometryObject is LineString)
                parms.Add("buffer", buffer.ToString(CultureInfo.InvariantCulture));

            return await GetAsync(statusLink, parms);
        }
    }
}