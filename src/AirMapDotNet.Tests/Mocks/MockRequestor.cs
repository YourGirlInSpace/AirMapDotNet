using System;
using System.IO;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities;
using AirMapDotNet.Requestors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace AirMapDotNet.Tests.Mocks
{
    public class MockRequestor : Requestor
    {
        public override async Task<T> GetAsync<T>(Uri uri, string apiKey, AuthenticationToken token)
        {
            string path = "";

            switch (uri.LocalPath)
            {
                #region Aircraft API
                case "/aircraft/v2/manufacturer/":
                    path = "Data/GET/aircraft/v2/manufacturer.json";
                    break;
                case "/aircraft/v2/model/":
                    path = "Data/GET/aircraft/v2/model.json";
                    break;
                case "/aircraft/v2/model/786bbd91-0509-4a36-94eb-f9fa46d1d20b/":
                    path = "Data/GET/aircraft/v2/model_by_id.json";
                    break;
                #endregion
                #region Flight API
                case "/flight/v2/":
                    path = "Data/GET/flight/v2/flights.json";
                    break;
                case "/flight/v2/flight|NaEwvXwcXZY5Dgh4dJ42bsdBdxPJ/":
                    path = "Data/GET/flight/v2/flight.json";
                    break;
                #endregion

                default:
                    Assert.Fail("MOCKREQUESTOR ERROR: Local path is not valid!");
                    break;

            }

            Assert.IsTrue(File.Exists(path), "MOCKREQUESTOR ERROR: Path does not exist!");

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                string data = await reader.ReadToEndAsync();

                return DeserializeJSON<Result<T>>(data).Data;
            }
        }

        public override Task<string> GetAsync(Uri uri, string apiKey, AuthenticationToken token)
        {
            throw new NotImplementedException();
        }

        public override async Task<T> PostAsync<T>(Uri uri, string apiKey, AuthenticationToken token, object data)
        {
            string path = "";

            switch (uri.LocalPath)
            {
                #region Flight API
                case "/flight/v2/polygon/":
                    path = "Data/POST/flight/v2/flight_by_point.json";
                    break;
                #endregion

                default:
                    Assert.Fail("MOCKREQUESTOR ERROR: Local path is not valid!");
                    break;

            }

            Assert.IsTrue(File.Exists(path), "MOCKREQUESTOR ERROR: Path does not exist!");

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                string jsonData = await reader.ReadToEndAsync();

                return DeserializeJSON<Result<T>>(jsonData).Data;
            }
        }

        public override Task<T> PatchAsync<T>(Uri uri, string apiKey, AuthenticationToken token, object data)
        {
            throw new NotImplementedException();
        }

        public override Task<JSendStatus> DeleteAsync(Uri uri, string apiKey, AuthenticationToken token)
        {
            throw new NotImplementedException();
        }
    }
}