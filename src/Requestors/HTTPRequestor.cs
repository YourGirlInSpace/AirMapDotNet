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
        public string UserAgent { get; set; } = "zio-airmapdotnet";

        /// <summary>
        /// The header name for the AirMap API key.
        /// </summary>
        /// <value>X-API-Key</value>
        private const string HeaderXAPI = "X-API-Key";

        /// <summary>
        /// The internal HTTP client used for requests.
        /// </summary>
        private static readonly Lazy<HttpClient> Client = new Lazy<HttpClient>(() => new HttpClient());

        /// <summary>
        /// Requests a specific resource using the <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The URI to request the resource from.</param>
        /// <param name="apiKey">Your AirMap API key.</param>
        /// <param name="token">The authentication token to use in this request.</param>
        /// <typeparam name="T">The underlying type behind the resource.</typeparam>
        /// <returns>The requested resource converted into <typeparamref name="T"/>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="uri"/> is null.</exception>
        /// <exception cref="AuthenticationException">
        ///     <para>
        ///         Thrown if an Unauthorized (401) status code was returned.
        ///     </para>
        ///     <para>
        ///         All exceptions thrown by <see cref="HTTPRequestor"/> contains several entries in their <see cref="Exception.Data"/> properties:
        ///         <list type="table">
        ///             <listheader>
        ///                 <term>Key Name</term>
        ///                 <term>Value</term>
        ///             </listheader>
        ///             <item>
        ///                 <term><c>requestUri</c></term>
        ///                 <description>The requested URI.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestHeaders</c></term>
        ///                 <description>The headers sent with the request.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestMethod</c></term>
        ///                 <description>The request method used.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>content</c></term>
        ///                 <description>The content returned with the response.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>statusCode</c></term>
        ///                 <description>The actual status code of the response..</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </exception>
        /// <exception cref="AirMapException">
        ///     <para>
        ///         Thrown if any non-successful status code was returned.
        ///     </para>
        ///     <para>
        ///         All exceptions thrown by <see cref="HTTPRequestor"/> contains several entries in their <see cref="Exception.Data"/> properties:
        ///         <list type="table">
        ///             <listheader>
        ///                 <term>Key Name</term>
        ///                 <term>Value</term>
        ///             </listheader>
        ///             <item>
        ///                 <term><c>requestUri</c></term>
        ///                 <description>The requested URI.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestHeaders</c></term>
        ///                 <description>The headers sent with the request.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestMethod</c></term>
        ///                 <description>The request method used.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>content</c></term>
        ///                 <description>The content returned with the response.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>statusCode</c></term>
        ///                 <description>The actual status code of the response..</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </exception>
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


            HttpResponseMessage hrm = await Client.Value.SendAsync(req);

            string content = await hrm.Content.ReadAsStringAsync();

            if (!hrm.IsSuccessStatusCode)
                throw GenerateException(req, hrm, content);

            Result<T> result = DeserializeJSON<Result<T>>(content);

            result.Data.RequestTime = DateTime.UtcNow;

            if (GetStatus(result.Status) == JSendStatus.Success)
                return result.Data;

            throw GenerateException(req, hrm, content);
        }

        /// <summary>
        /// Requests a status result of a specific resource using the <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The URI to request the resource from.</param>
        /// <param name="apiKey">Your AirMap API key.</param>
        /// <param name="token">The authentication token to use in this request.</param>
        /// <returns>The status result of the requested resource.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="uri"/> is null.</exception>
        /// <exception cref="AuthenticationException">
        ///     <para>
        ///         Thrown if an Unauthorized (401) status code was returned.
        ///     </para>
        ///     <para>
        ///         All exceptions thrown by <see cref="HTTPRequestor"/> contains several entries in their <see cref="Exception.Data"/> properties:
        ///         <list type="table">
        ///             <listheader>
        ///                 <term>Key Name</term>
        ///                 <term>Value</term>
        ///             </listheader>
        ///             <item>
        ///                 <term><c>requestUri</c></term>
        ///                 <description>The requested URI.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestHeaders</c></term>
        ///                 <description>The headers sent with the request.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestMethod</c></term>
        ///                 <description>The request method used.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>content</c></term>
        ///                 <description>The content returned with the response.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>statusCode</c></term>
        ///                 <description>The actual status code of the response..</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </exception>
        public override async Task<string> GetAsync(Uri uri, string apiKey, AuthenticationToken token)
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


            HttpResponseMessage hrm = await Client.Value.SendAsync(req);

            string content = await hrm.Content.ReadAsStringAsync();

            if (!hrm.IsSuccessStatusCode)
                throw GenerateException(req, hrm, content);

            Result result = DeserializeJSON<Result>(content);
            return result.Status;
        }

        /// <summary>
        /// Posts an update for the resource at <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The URI of the resource.</param>
        /// <param name="apiKey">Your AirMap API key.</param>
        /// <param name="token">The authentication token to use in this request.</param>
        /// <param name="data">The data to post.</param>
        /// <typeparam name="T">The underlying type returned from the resource.</typeparam>
        /// <returns>The result of the posted data.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="uri"/> is null.</exception>
        /// <exception cref="AuthenticationException">
        ///     <para>
        ///         Thrown if an Unauthorized (401) status code was returned.
        ///     </para>
        ///     <para>
        ///         All exceptions thrown by <see cref="HTTPRequestor"/> contains several entries in their <see cref="Exception.Data"/> properties:
        ///         <list type="table">
        ///             <listheader>
        ///                 <term>Key Name</term>
        ///                 <term>Value</term>
        ///             </listheader>
        ///             <item>
        ///                 <term><c>requestUri</c></term>
        ///                 <description>The requested URI.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestHeaders</c></term>
        ///                 <description>The headers sent with the request.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestMethod</c></term>
        ///                 <description>The request method used.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>content</c></term>
        ///                 <description>The content returned with the response.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>statusCode</c></term>
        ///                 <description>The actual status code of the response..</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </exception>
        /// <exception cref="AirMapException">
        ///     <para>
        ///         Thrown if any non-successful status code was returned.
        ///     </para>
        ///     <para>
        ///         All exceptions thrown by <see cref="HTTPRequestor"/> contains several entries in their <see cref="Exception.Data"/> properties:
        ///         <list type="table">
        ///             <listheader>
        ///                 <term>Key Name</term>
        ///                 <term>Value</term>
        ///             </listheader>
        ///             <item>
        ///                 <term><c>requestUri</c></term>
        ///                 <description>The requested URI.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestHeaders</c></term>
        ///                 <description>The headers sent with the request.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestMethod</c></term>
        ///                 <description>The request method used.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>content</c></term>
        ///                 <description>The content returned with the response.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>statusCode</c></term>
        ///                 <description>The actual status code of the response..</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </exception>
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

            HttpResponseMessage hrm = await Client.Value.SendAsync(req);

            string content = await hrm.Content.ReadAsStringAsync();

            if (!hrm.IsSuccessStatusCode)
                throw GenerateException(req, hrm, content);

            Result<T> result = DeserializeJSON<Result<T>>(content);

            result.Data.RequestTime = DateTime.UtcNow;

            if (GetStatus(result.Status) == JSendStatus.Success)
                return result.Data;

            throw GenerateException(req, hrm, content);
        }

        /// <summary>
        /// Patches the resource at <paramref name="uri"/> with <paramref name="data"/>.
        /// </summary>
        /// <param name="uri">The URI of the resource.</param>
        /// <param name="apiKey">Your AirMap API key.</param>
        /// <param name="token">The authentication token to use in this request.</param>
        /// <param name="data">The data to patch.</param>
        /// <typeparam name="T">The underlying type returned from the resource.</typeparam>
        /// <returns>The result of the patched data.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="uri"/> is null.</exception>
        /// <exception cref="AuthenticationException">
        ///     <para>
        ///         Thrown if an Unauthorized (401) status code was returned.
        ///     </para>
        ///     <para>
        ///         All exceptions thrown by <see cref="HTTPRequestor"/> contains several entries in their <see cref="Exception.Data"/> properties:
        ///         <list type="table">
        ///             <listheader>
        ///                 <term>Key Name</term>
        ///                 <term>Value</term>
        ///             </listheader>
        ///             <item>
        ///                 <term><c>requestUri</c></term>
        ///                 <description>The requested URI.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestHeaders</c></term>
        ///                 <description>The headers sent with the request.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestMethod</c></term>
        ///                 <description>The request method used.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>content</c></term>
        ///                 <description>The content returned with the response.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>statusCode</c></term>
        ///                 <description>The actual status code of the response..</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </exception>
        /// <exception cref="AirMapException">
        ///     <para>
        ///         Thrown if any non-successful status code was returned.
        ///     </para>
        ///     <para>
        ///         All exceptions thrown by <see cref="HTTPRequestor"/> contains several entries in their <see cref="Exception.Data"/> properties:
        ///         <list type="table">
        ///             <listheader>
        ///                 <term>Key Name</term>
        ///                 <term>Value</term>
        ///             </listheader>
        ///             <item>
        ///                 <term><c>requestUri</c></term>
        ///                 <description>The requested URI.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestHeaders</c></term>
        ///                 <description>The headers sent with the request.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestMethod</c></term>
        ///                 <description>The request method used.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>content</c></term>
        ///                 <description>The content returned with the response.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>statusCode</c></term>
        ///                 <description>The actual status code of the response..</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </exception>
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

            HttpResponseMessage hrm = await Client.Value.SendAsync(req);

            string content = await hrm.Content.ReadAsStringAsync();

            if (!hrm.IsSuccessStatusCode)
                throw GenerateException(req, hrm, content);

            Result<T> result = DeserializeJSON<Result<T>>(content);

            result.Data.RequestTime = DateTime.UtcNow;

            if (GetStatus(result.Status) == JSendStatus.Success)
                return result.Data;

            throw GenerateException(req, hrm, content);
        }

        /// <summary>
        /// Deletes the resource at <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The URI of the resource.</param>
        /// <param name="apiKey">Your AirMap API key.</param>
        /// <param name="token">The authentication token to use in this request.</param>
        /// <returns>The result of the deletion.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="uri"/> is null.</exception>
        /// <exception cref="AuthenticationException">
        ///     <para>
        ///         Thrown if an Unauthorized (401) status code was returned.
        ///     </para>
        ///     <para>
        ///         All exceptions thrown by <see cref="HTTPRequestor"/> contains several entries in their <see cref="Exception.Data"/> properties:
        ///         <list type="table">
        ///             <listheader>
        ///                 <term>Key Name</term>
        ///                 <term>Value</term>
        ///             </listheader>
        ///             <item>
        ///                 <term><c>requestUri</c></term>
        ///                 <description>The requested URI.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestHeaders</c></term>
        ///                 <description>The headers sent with the request.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestMethod</c></term>
        ///                 <description>The request method used.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>content</c></term>
        ///                 <description>The content returned with the response.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>statusCode</c></term>
        ///                 <description>The actual status code of the response..</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </exception>
        /// <exception cref="AirMapException">
        ///     <para>
        ///         Thrown if any non-successful status code was returned.
        ///     </para>
        ///     <para>
        ///         All exceptions thrown by <see cref="HTTPRequestor"/> contains several entries in their <see cref="Exception.Data"/> properties:
        ///         <list type="table">
        ///             <listheader>
        ///                 <term>Key Name</term>
        ///                 <term>Value</term>
        ///             </listheader>
        ///             <item>
        ///                 <term><c>requestUri</c></term>
        ///                 <description>The requested URI.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestHeaders</c></term>
        ///                 <description>The headers sent with the request.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>requestMethod</c></term>
        ///                 <description>The request method used.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>content</c></term>
        ///                 <description>The content returned with the response.</description>
        ///             </item>
        ///             <item>
        ///                 <term><c>statusCode</c></term>
        ///                 <description>The actual status code of the response..</description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </exception>
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
            
            HttpResponseMessage hrm = await Client.Value.SendAsync(req);

            string content = await hrm.Content.ReadAsStringAsync();
            if (hrm.IsSuccessStatusCode)
            {
                Result result = DeserializeJSON<Result>(content);

                return GetStatus(result.Status);
            }

            throw GenerateException(req, hrm, content);
        }
        
        /// <summary>
        /// Generates an exception for a given <paramref name="request"/>, <paramref name="response"/> and <paramref name="content"/>
        /// </summary>
        /// <param name="request">The request data.</param>
        /// <param name="response">The response data.</param>
        /// <param name="content">The content returned with the response data.</param>
        /// <returns>An exception containing details on how the request failed.</returns>
        private Exception GenerateException(HttpRequestMessage request, HttpResponseMessage response, string content)
        {
            Result<AirMapErrorData> errorData = DeserializeJSON<Result<AirMapErrorData>>(content);

            Exception ex;
            switch (response.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    ex = new AuthenticationException($"Unable to {request.Method.Method} data:  Authentication token is not valid for this resource.");
                    break;
                case HttpStatusCode.InternalServerError:
                case HttpStatusCode.BadGateway:
                case HttpStatusCode.NotImplemented:
                    ex = new AirMapException($"Unable to {request.Method.Method} data: Server failed.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
                    break;
                default:
                    ex = new AirMapException($"Unable to {request.Method.Method} data: Data error.", GetStatus(errorData?.Status ?? ""), errorData?.Data);
                    break;
            }

            ex.Data.Add("requestUri", request.RequestUri);
            ex.Data.Add("requestHeaders", request.Headers.ToString());
            ex.Data.Add("requestMethod", request.Method.Method);
            ex.Data.Add("content", content);
            ex.Data.Add("statusCode", response.StatusCode);

            return ex;
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
        /// This method appends the <see cref="UserAgent"/> property with a forward slash, then the current assembly's
        /// major and minor versions, then the build number.  For example, <c>zio-airmapdotnet/1.0.1000</c>.  For this purpose, the revision
        /// number is far too precise.</remarks>
        private string GetUserAgent()
        {
            Version vers = Assembly.GetExecutingAssembly().GetName().Version;

            return $"{UserAgent}/{vers.Major}.{vers.Minor}.{vers.Build}";
        }
    }
}