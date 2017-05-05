using System;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities;
using Newtonsoft.Json;

namespace AirMapDotNet.Requestors
{
    /// <summary>
    /// Provides a template for custom requestors.
    /// </summary>
    /// <remarks>
    /// Custom requestors may be made using your own HTTP libraries.
    /// </remarks>
    public abstract class Requestor
    {
        /// <summary>
        /// Maximum number of concurrent requests.
        /// </summary>
        public const int MaxConcurrentRequests = 20;

        /// <summary>
        /// Default character set for requests.
        /// </summary>
        public const string CharSet = @"utf-8";

        /// <summary>
        /// Requests a specific resource using the <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The URI to request the resource from.</param>
        /// <param name="apiKey">Your AirMap API key.</param>
        /// <param name="token">The authentication token to use in this request.</param>
        /// <typeparam name="T">The underlying type behind the resource.</typeparam>
        /// <returns>The requested resource converted into <typeparamref name="T"/>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="uri"/> is null.</exception>
        public abstract Task<T> GetAsync<T>(Uri uri, string apiKey, AuthenticationToken token)
            where T : class, IAirMapEntity;

        /// <summary>
        /// Requests a specific resource using the <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The URI to request the resource from.</param>
        /// <param name="apiKey">Your AirMap API key.</param>
        /// <param name="token">The authentication token to use in this request.</param>
        /// <returns>The requested resource as a string.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="uri"/> is null.</exception>
        public abstract Task<string> GetAsync(Uri uri, string apiKey, AuthenticationToken token);

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
        public abstract Task<T> PostAsync<T>(Uri uri, string apiKey, AuthenticationToken token, object data)
            where T : class, IAirMapEntity;

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
        public abstract Task<T> PatchAsync<T>(Uri uri, string apiKey, AuthenticationToken token, object data)
            where T : class, IAirMapEntity;

        /// <summary>
        /// Deletes the resource at <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The URI of the resource.</param>
        /// <param name="apiKey">Your AirMap API key.</param>
        /// <param name="token">The authentication token to use in this request.</param>
        /// <returns>The result of the deletion.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="uri"/> is null.</exception>
        public abstract Task<JSendStatus> DeleteAsync(Uri uri, string apiKey, AuthenticationToken token);

        /// <summary>
        /// Deserializes a JSON string into an object <typeparamref name="T"/>.
        /// </summary>
        /// <param name="data">The JSON data to deserialize.</param>
        /// <typeparam name="T">The type to deserialize to.</typeparam>
        /// <returns>The deserialized data, casted to <typeparamref name="T"/>.</returns>
        /// <exception cref="AirMapException">If the deserialization fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null or equals <see cref="string.Empty"/>.</exception>
        internal virtual T DeserializeJSON<T>(string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException(nameof(data));

            try
            {
                return JsonConvert.DeserializeObject<T>(data);
            } catch (JsonSerializationException jsx)
            {
                throw new AirMapException("Failed to deserialize data.", jsx);
            }
        }

        /// <summary>
        /// Serializes an object to a JSON string.
        /// </summary>
        /// <param name="data">The object to serialize.</param>
        /// <returns>The serialized JSON string.</returns>
        /// <exception cref="AirMapException">If the serialization fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        internal virtual string SerializeJSON(object data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            try
            {
                return JsonConvert.SerializeObject(data);
            }
            catch (JsonSerializationException jsx)
            {
                throw new AirMapException("Failed to serialize data.", jsx);
            }
        }
    }
}