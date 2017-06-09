using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities.FlightAPI;
using AirMapDotNet.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AirMapDotNet.Tests
{
    [TestClass]
    public class AirMapTest
    {
        private const double TOLERANCE = 1e-5;
        private const string ISS = "https://sso.airmap.io";
        private const string SUB = "auth0|58c...a5c";
        private const string AUD = "OPy...XxF";
        private static readonly DateTime EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private static string ConstructJWT(DateTime time, TimeSpan expires)
        {
            // ========= HEADER =========
            string header = "{\"typ\":\"JWT\",\"alg\":\"HS256\"}";

            string header_b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(header), Base64FormattingOptions.None)
                .Replace("=", "");

            // ========= PAYLOAD =========
            string payload = "{";
            payload += $"\"iss\": \"{ISS}\",";
            payload += $"\"sub\": \"{SUB}\",";
            payload += $"\"aud\": \"{AUD}\",";

            int iat_sec = (int)(time - EPOCH).TotalSeconds;
            int exp_sec = (int)(time + expires - EPOCH).TotalSeconds;

            payload += $"\"exp\": {exp_sec},";
            payload += $"\"iat\": {iat_sec}";
            payload += "}";

            string payload_b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(payload), Base64FormattingOptions.None)
                .Replace("=", "");

            // ========= SIGNATURE =========
            string signature_b64 = "jcLrbJHZHeyvIJGvRMdKD9Nz4yzRAUzQVmi98JwOUSM"; // WILL NOT VALIDATE

            return $"{header_b64}.{payload_b64}.{signature_b64}";
        }

        private AuthenticationToken GenerateAuthToken()
        {
            string jwt = ConstructJWT(DateTime.UtcNow - TimeSpan.FromMinutes(5), TimeSpan.FromHours(4));

            return new AuthenticationToken(jwt);
        }
        
        private AirMap InitializeAirMap()
        {
            Assert.IsTrue(File.Exists("airmap.config.json"), "ERROR: airmap.config.json missing!");

            string jsonConfigData = File.ReadAllText("airmap.config.json");
            APIConfiguration config = APIConfiguration.CreateFromJSON(jsonConfigData);

            AuthenticationToken token = GenerateAuthToken();

            return new AirMap(config, token)
            {
                Requestor = new MockRequestor()
            };
        }

        private bool DateTimesEqual(DateTime a, DateTime b)
            => Math.Abs(Math.Floor((a - EPOCH).TotalSeconds) - Math.Floor((b - EPOCH).TotalSeconds)) < TOLERANCE;

        #region Aircraft API
        [TestMethod]
        [TestCategory("AirMap [Aircraft API]")]
        public async Task TestGetManufacturers()
        {
            AirMap am = InitializeAirMap();

            var manus = await am.GetManufacturers();

            Assert.IsTrue(manus.Any(x => x.Name.Equals("DJI")));
        }

        [TestMethod]
        [TestCategory("AirMap [Aircraft API]")]
        public async Task TestGetModels()
        {
            AirMap am = InitializeAirMap();

            var models = await am.GetModels("2a55b47e-ca49-4b7e-99c7-dee9cd784ec9");

            Assert.IsTrue(models.Any(x => x.ID.Equals("b3b1c26f-06da-4eae-9390-667c90039175")));
        }

        [TestMethod]
        [TestCategory("AirMap [Aircraft API]")]
        public async Task TestGetModelByID()
        {
            AirMap am = InitializeAirMap();

            var model = await am.GetModel("786bbd91-0509-4a36-94eb-f9fa46d1d20b");

            Assert.IsTrue(model.Name.Equals("Phantom 4"));
        }
        #endregion

        #region Flight API
        [TestMethod]
        [TestCategory("AirMap [Flight API]")]
        public async Task TestGetFlights()
        {
            AirMap am = InitializeAirMap();

            IEnumerable<Flight> flights = await am.GetFlights(GeoUtilities.CreateCircle(new LatLon(0, 0), 500), 2);

            // Enumerate first to avoid multiple enumeration
            IEnumerable<Flight> enumerable = flights as IList<Flight> ?? flights.ToList();

            Assert.AreEqual(2, enumerable.Count());
            Assert.IsTrue(enumerable.Any(x => x.ID.Equals("flight|NaEwvXwcXZY5Dgh4dJ42bsdBdxPJ")));
        }

        [TestMethod]
        [TestCategory("AirMap [Flight API]")]
        public async Task TestGetFlight()
        {
            AirMap am = InitializeAirMap();

            Flight flight = await am.GetFlight("flight|NaEwvXwcXZY5Dgh4dJ42bsdBdxPJ");
            
            Assert.AreEqual("flight|NaEwvXwcXZY5Dgh4dJ42bsdBdxPJ", flight.ID);
            Assert.AreEqual("auth0|5830cb954dcef2f237eb58dc", flight.PilotID);
            Assert.AreEqual(34.070999, flight.Latitude, TOLERANCE);
            Assert.AreEqual(-118.309439, flight.Longitude, TOLERANCE);
            Assert.AreEqual("aircraft|4eL6YR6ILg00yPT70pZ7DuGXkNLP", flight.AircraftID);
            Assert.IsTrue(DateTimesEqual(new DateTime(2017, 6, 9, 4, 11, 28), flight.CreatedAt), "DateTimesEqual(new DateTime(2017, 6, 10, 4, 11, 28), flight.CreatedAt)");
            Assert.IsTrue(DateTimesEqual(new DateTime(2017, 6, 10, 1, 30, 0), flight.StartTime), "DateTimesEqual(new DateTime(2017, 6, 10, 1, 30, 0), flight.StartTime)");
            Assert.IsTrue(DateTimesEqual(new DateTime(2017, 6, 10, 2, 29, 0), flight.EndTime), "DateTimesEqual(new DateTime(2017, 6, 10, 2, 29, 0), flight.EndTime)");
            Assert.AreEqual("USA", flight.Country);
            Assert.AreEqual("California", flight.State);
            Assert.AreEqual("Los Angeles", flight.City);
            Assert.AreEqual(true, flight.IsPublic);
            Assert.AreEqual(182, flight.Buffer, TOLERANCE);
            Assert.AreEqual(121.92, flight.MaxAltitude, TOLERANCE);
        }

        [TestMethod]
        [TestCategory("AirMap [Flight API]")]
        public async Task TestCreateFlightByPoint()
        {
            AirMap am = InitializeAirMap();

            FlightCreationParameters fcp = new FlightCreationParameters
            {
                Latitude = 26,
                Longitude = -81,

                MaxAltitude = 121.91,
                Buffer = 1000,

                AircraftID = "aircraft|9M5dkMfi8Jw6ZptwXKM9W5GgdNsK",
                
                StartTime = new DateTime(2016, 8, 11, 13, 40, 00, DateTimeKind.Utc),
                EndTime = new DateTime(2016, 8, 11, 13, 45, 00, DateTimeKind.Utc),

                Geometry = GeoUtilities.CreateCircle(new LatLon(26, -81), 1000),

                IsPublic = true,
                Notify = false
            };

            Flight flight = await am.CreateFlight(fcp);

            Assert.AreEqual("flight|ZWRMwRnclvpfQAfLdWLMniDBM9N9", flight.ID);
            Assert.AreEqual("auth0|58c...a5c", flight.PilotID);
            Assert.AreEqual(26, flight.Latitude, TOLERANCE);
            Assert.AreEqual(-81, flight.Longitude, TOLERANCE);
            Assert.AreEqual("aircraft|9M5dkMfi8Jw6ZptwXKM9W5GgdNsK", flight.AircraftID);
            Assert.IsTrue(DateTimesEqual(new DateTime(2016, 8, 11, 13, 40, 00, DateTimeKind.Utc), flight.StartTime), "StartTime NE");
            Assert.IsTrue(DateTimesEqual(new DateTime(2016, 8, 11, 13, 45, 00, DateTimeKind.Utc), flight.EndTime), "EndTime NE");
            Assert.AreEqual(true, flight.IsPublic);
            Assert.AreEqual(100, flight.Buffer, TOLERANCE);
            Assert.AreEqual(121.91, flight.MaxAltitude, TOLERANCE);
        }
        #endregion
    }
}