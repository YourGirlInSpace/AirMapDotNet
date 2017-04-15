using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities;

namespace AirMapDotNet.Requestors
{
    /// <summary>
    /// Provides several methods in which to interact with the AirMap API.
    /// </summary>
    public class HTTPRequestor : Requestor
    {
        /// <summary>
        /// The User Agent header sent to the AirMap API server.
        /// </summary>
        public const string UserAgent = "zio-airmapdotnet";

        /// <summary>
        /// The header name for the AirMap API key.
        /// </summary>
        /// <value>X-API-Key</value>
        private const string HeaderXAPI = "X-API-Key";

        /// <summary>
        /// The internal HTTP client used for requests.
        /// </summary>
        private static readonly HttpClient Client = new HttpClient();

        /// <inheritdoc />
        public override async Task<T> GetAsync<T>(Uri uri, string apiKey, AuthenticationToken token)
        {
            if (uri == null)
                throw new ArgumentNullException(nameof(uri));

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, uri);
            req.Headers.Host = "api.airmap.com";

            req.Headers.UserAgent.ParseAdd(GetUserAgent());
            req.Headers.Accept.ParseAdd("application/json");
            req.Headers.AcceptCharset.ParseAdd(CharSet);

            if (!string.IsNullOrWhiteSpace(apiKey))
                req.Headers.Add(HeaderXAPI, apiKey);
            if (token != null)
                req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);


            HttpResponseMessage hrm = await Client.SendAsync(req);

            string content = await hrm.Content.ReadAsStringAsync();
            if (hrm.IsSuccessStatusCode)
            {
                Result<T> result = DeserializeJSON<Result<T>>(content);

                result.Data.RequestTime = DateTime.UtcNow;

                if (GetStatus(result.Status) == JSendStatus.Success)
                    return result.Data;
            }

            Result<AirMapErrorData> errorData = DeserializeJSON<Result<AirMapErrorData>>(content);
            switch (hrm.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    throw new AuthenticationException("Unable to request data:  Authentication token is not valid for this resource.");
                case HttpStatusCode.InternalServerError:
                case HttpStatusCode.BadGateway:
                case HttpStatusCode.NotImplemented:
                    throw new AirMapException("Unable to request data: Server failed.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
                default:
                    throw new AirMapException("Unable to request data: Data error.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
            }
        }

        /// <inheritdoc />
        public override async Task<T> PostAsync<T>(Uri uri, string apiKey, AuthenticationToken token, object data)
        {
            if (uri == null)
                throw new ArgumentNullException(nameof(uri));

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, uri);

            req.Headers.Host = "api.airmap.com";
            req.Headers.UserAgent.ParseAdd(GetUserAgent());
            req.Headers.Accept.ParseAdd("application/json");
            req.Headers.AcceptCharset.ParseAdd(CharSet);

            if (!string.IsNullOrWhiteSpace(apiKey))
                req.Headers.Add(HeaderXAPI, apiKey);
            if (token != null)
                req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);

            string jsonData = SerializeJSON(data);
            req.Content = new StringContent(jsonData);

            HttpResponseMessage hrm = await Client.SendAsync(req);

            string content = await hrm.Content.ReadAsStringAsync();
            if (hrm.IsSuccessStatusCode)
            {
                Result<T> result = DeserializeJSON<Result<T>>(content);

                result.Data.RequestTime = DateTime.UtcNow;

                if (GetStatus(result.Status) == JSendStatus.Success)
                    return result.Data;
            }

            Result<AirMapErrorData> errorData = DeserializeJSON<Result<AirMapErrorData>>(content);
            switch (hrm.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    throw new AuthenticationException("Unable to post data:  Authentication token is not valid for this resource.");
                case HttpStatusCode.InternalServerError:
                case HttpStatusCode.BadGateway:
                case HttpStatusCode.NotImplemented:
                    throw new AirMapException("Unable to post data: Server failed.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
                default:
                    throw new AirMapException("Unable to post data: Data error.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
            }
        }

        /// <inheritdoc />
        public override async Task<T> PatchAsync<T>(Uri uri, string apiKey, AuthenticationToken token, object data)
        {
            if (uri == null)
                throw new ArgumentNullException(nameof(uri));

            HttpMethod Patch = new HttpMethod("PATCH");

            HttpRequestMessage req = new HttpRequestMessage(Patch, uri);

            req.Headers.Host = "api.airmap.com";
            req.Headers.UserAgent.ParseAdd(GetUserAgent());
            req.Headers.Accept.ParseAdd("application/json");
            req.Headers.AcceptCharset.ParseAdd(CharSet);

            if (!string.IsNullOrWhiteSpace(apiKey))
                req.Headers.Add(HeaderXAPI, apiKey);
            if (token != null)
                req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);

            string jsonData = SerializeJSON(data);
            req.Content = new StringContent(jsonData);

            HttpResponseMessage hrm = await Client.SendAsync(req);

            string content = await hrm.Content.ReadAsStringAsync();
            if (hrm.IsSuccessStatusCode)
            {
                Result<T> result = DeserializeJSON<Result<T>>(content);

                result.Data.RequestTime = DateTime.UtcNow;

                if (GetStatus(result.Status) == JSendStatus.Success)
                    return result.Data;
            }

            Result<AirMapErrorData> errorData = DeserializeJSON<Result<AirMapErrorData>>(content);
            switch (hrm.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    throw new AuthenticationException("Unable to patch data:  Authentication token is not valid for this resource.");
                case HttpStatusCode.InternalServerError:
                case HttpStatusCode.BadGateway:
                case HttpStatusCode.NotImplemented:
                    throw new AirMapException("Unable to patch data: Server failed.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
                default:
                    throw new AirMapException("Unable to patch data: Data error.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
            }
        }

        /// <inheritdoc />
        public override async Task<JSendStatus> DeleteAsync(Uri uri, string apiKey, AuthenticationToken token)
        {
            if (uri == null)
                throw new ArgumentNullException(nameof(uri));

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Delete, uri);

            req.Headers.Host = "api.airmap.com";
            req.Headers.UserAgent.ParseAdd(GetUserAgent());
            req.Headers.Accept.ParseAdd("application/json");
            req.Headers.AcceptCharset.ParseAdd(CharSet);

            if (!string.IsNullOrWhiteSpace(apiKey))
                req.Headers.Add(HeaderXAPI, apiKey);
            if (token != null)
                req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
            
            HttpResponseMessage hrm = await Client.SendAsync(req);

            string content = await hrm.Content.ReadAsStringAsync();
            if (hrm.IsSuccessStatusCode)
            {
                Result result = DeserializeJSON<Result>(content);

                return GetStatus(result.Status);
            }

            Result<AirMapErrorData> errorData = DeserializeJSON<Result<AirMapErrorData>>(content);
            switch (hrm.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    throw new AuthenticationException("Unable to delete data:  Authentication token is not valid for this resource.");
                case HttpStatusCode.InternalServerError:
                case HttpStatusCode.BadGateway:
                case HttpStatusCode.NotImplemented:
                    throw new AirMapException("Unable to delete data: Server failed.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
                default:
                    throw new AirMapException("Unable to delete data: Data error.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
            }
        }

        /// <summary>
        /// Returns the <see cref="JSendStatus"/> associated with a JSend status string.
        /// </summary>
        /// <param name="status">The status string, case insensitive.</param>
        /// <returns>The <see cref="JSendStatus"/> matching the <paramref name="status"/> parameter, otherwise <see cref="JSendStatus.Unknown"/>.</returns>
        private static JSendStatus GetStatus(string status)
        {
            switch (status.ToLowerInvariant())
            {
                case "success":
                    return JSendStatus.Success;
                case "fail":
                    return JSendStatus.Fail;
                case "error":
                    return JSendStatus.Error;
                default:
                    return JSendStatus.Unknown;
            }
        }

        /// <summary>
        /// Retrieves the UserAgent string with the current assembly's version.
        /// </summary>
        /// <returns><see cref="UserAgent"/> concatenated with a forward slash and the current assembly's version.</returns>
        /// <remarks>
        /// This method appends the <see cref="UserAgent"/> constant with a forward slash, then the current assembly's
        /// major and minor versions, then the build number.  For example, <c>zio-airmapdotnet/1.0.1000</c>.  For this purpose, the revision
        /// number is far too precise.</remarks>
        private static string GetUserAgent()
        {
            Version vers = Assembly.GetExecutingAssembly().GetName().Version;

            return $"{UserAgent}/{vers.Major}.{vers.Minor}.{vers.Build}";
        }
    }
}