using System;
using System.Collections.Specialized;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities;
using AirMapDotNet.Requestors;

[assembly:CLSCompliant(true)]
namespace AirMapDotNet
{
    /// <summary>
    /// The representation of a session on the AirMap API.
    /// </summary>
    public partial class AirMap
    {
        /// <summary>
        /// The API key used by this session.
        /// </summary>
        /// <remarks>The API key is a JWT token, though not with a standard payload.
        /// There currently is no method to directly validate an API key.</remarks>
        internal string APIKey { get; }

        /// <summary>
        /// The <see cref="Requestor"/> used to interact with the AirMap API.
        /// </summary>
        public Requestor Requestor { get; set; }
        
        /// <summary>
        /// The authentication token used by this session.
        /// </summary>
        public AuthenticationToken AuthenticationToken { get; set; } = null;

        /// <summary>
        /// Creates a new AirMap API session using the provided <paramref name="apiKey"/>.
        /// </summary>
        /// <param name="apiKey">Your AirMap API key.</param>
        public AirMap(string apiKey)
        {
            Requestor = new HTTPRequestor();
            APIKey = apiKey;
        }

        /// <summary>
        /// Requests a resource from the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        internal async Task<T> GetAsync<T>(Href<T> uri)
            where T : class, IAirMapEntity => uri == null
            ? default(T)
            : await GetAsync<T>(uri.Compile())
                .ConfigureAwait(false);

        /// <summary>
        /// Requests a resource from the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="parameters">Query parameters for the resource request.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        internal async Task<T> GetAsync<T>(Href<T> uri, NameValueCollection parameters)
            where T : class, IAirMapEntity => uri == null
            ? default(T)
            : await GetAsync<T>(uri.Compile(parameters))
                .ConfigureAwait(false);

        /// <summary>
        /// Requests a resource from the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        internal T Get<T>(Href<T> uri)
            where T : class, IAirMapEntity => GetAsync(uri).Result;

        /// <summary>
        /// Requests a resource from the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="parameters">Query parameters for the resource request.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        internal T Get<T>(Href<T> uri, NameValueCollection parameters)
            where T : class, IAirMapEntity => GetAsync(uri, parameters).Result;


        /// <summary>
        /// Requests a resource from the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        private async Task<T> GetAsync<T>(Uri uri) where T : class, IAirMapEntity
        {
            T result;

            try
            {
                result = await Requestor.GetAsync<T>(uri, APIKey, AuthenticationToken)
                    .ConfigureAwait(false);
                result.AirMap = this;
            }
            catch (AirMapException ame)
            {
                // Authorization:  Refresh if applicable.


                throw new AirMapException("Failed to get data.", ame);
            }

            return result;
        }

        /// <summary>
        /// Posts an updated resource to the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="data">The data to post.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        internal async Task<T> PostAsync<T>(Href<T> uri, object data)
            where T : class, IAirMapEntity => uri == null
            ? default(T)
            : await PostAsync<T>(uri.Compile(), data)
                .ConfigureAwait(false);

        /// <summary>
        /// Posts an updated resource to the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="parameters">Query parameters for the resource request.</param>
        /// <param name="data">The data to post.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        internal async Task<T> PostAsync<T>(Href<T> uri, NameValueCollection parameters, object data)
            where T : class, IAirMapEntity => uri == null
            ? default(T)
            : await PostAsync<T>(uri.Compile(parameters), data)
                .ConfigureAwait(false);

        /// <summary>
        /// Posts an updated resource to the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="data">The data to post.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        internal T Post<T>(Href<T> uri, object data)
            where T : class, IAirMapEntity => PostAsync(uri, data).Result;

        /// <summary>
        /// Posts an updated resource to the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="parameters">Query parameters for the resource request.</param>
        /// <param name="data">The data to post.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        internal T Post<T>(Href<T> uri, NameValueCollection parameters, object data)
            where T : class, IAirMapEntity => PostAsync(uri, parameters, data).Result;

        /// <summary>
        /// Posts an updated resource to the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="data">The data to post.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        private async Task<T> PostAsync<T>(Uri uri, object data) where T : class, IAirMapEntity
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            T result;

            try
            {
                result = await Requestor.PostAsync<T>(uri, APIKey, AuthenticationToken, data)
                    .ConfigureAwait(false);
                result.AirMap = this;
            }
            catch (AirMapException ame)
            {
                // Authorization:  Refresh if applicable.
                
                throw new AirMapException("Failed to post data.", ame);
            }

            return result;
        }



        /// <summary>
        /// Updates the resource on the AirMap API with the supplied <paramref name="data"/>.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="data">The data to update.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        internal async Task<T> PatchAsync<T>(Href<T> uri, object data)
            where T : class, IAirMapEntity => uri == null
            ? default(T)
            : await PatchAsync<T>(uri.Compile(), data)
                .ConfigureAwait(false);

        /// <summary>
        /// Updates the resource on the AirMap API with the supplied <paramref name="data"/>.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="parameters">Query parameters for the resource request.</param>
        /// <param name="data">The data to update.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        internal async Task<T> PatchAsync<T>(Href<T> uri, NameValueCollection parameters, object data)
            where T : class, IAirMapEntity => uri == null
            ? default(T)
            : await PatchAsync<T>(uri.Compile(parameters), data)
                .ConfigureAwait(false);

        /// <summary>
        /// Updates the resource on the AirMap API with the supplied <paramref name="data"/>.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="data">The data to update.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        internal T Patch<T>(Href<T> uri, object data)
            where T : class, IAirMapEntity => PatchAsync(uri, data).Result;

        /// <summary>
        /// Updates the resource on the AirMap API with the supplied <paramref name="data"/>.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="parameters">Query parameters for the resource request.</param>
        /// <param name="data">The data to update.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        internal T Patch<T>(Href<T> uri, NameValueCollection parameters, object data)
            where T : class, IAirMapEntity => PatchAsync(uri, parameters, data).Result;

        /// <summary>
        /// Updates the resource on the AirMap API with the supplied <paramref name="data"/>.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <param name="data">The data to update.</param>
        /// <typeparam name="T">The underlying type of the resource.</typeparam>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        private async Task<T> PatchAsync<T>(Uri uri, object data) where T : class, IAirMapEntity
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            T result;

            try
            {
                result = await Requestor.PatchAsync<T>(uri, APIKey, AuthenticationToken, data)
                    .ConfigureAwait(false);
                result.AirMap = this;
            }
            catch (AirMapException ame)
            {
                // Authorization:  Refresh if applicable.

                throw new AirMapException("Failed to patch data.", ame);
            }

            return result;
        }

        /// <summary>
        /// Deletes a resource on the AirMap API.
        /// </summary>
        /// <param name="uri">The URL of the resource.</param>
        /// <returns>The resultant data.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        internal async Task DeleteAsync(Uri uri)
        {
            try
            {
                await Requestor.DeleteAsync(uri, APIKey, AuthenticationToken)
                    .ConfigureAwait(false);
            }
            catch (AirMapException ame)
            {
                // Authorization:  Refresh if applicable.

                throw new AirMapException("Failed to delete data.", ame);
            }
        }
    }
}
