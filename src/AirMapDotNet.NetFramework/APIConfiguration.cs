using System;
using System.IO;
using System.Security;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AirMapDotNet
{
    /// <summary>
    /// Provides a set of configuration parameters for an AirMap API session.
    /// </summary>
    public class APIConfiguration : IAPIConfiguration
    {
        /// <summary>
        /// The Auth0 Client ID.
        /// </summary>
        public string ClientID { get; private set; }

        /// <summary>
        /// The AirMap API key.
        /// </summary>
        public string APIKey { get; private set; }

        /// <summary>
        /// The OAuth2 callback URL.
        /// </summary>
        public Uri CallbackURL { get; private set; }

        /// <summary>
        /// The access token for the MapBox API.
        /// </summary>
        public string MapBoxAccessToken { get; private set; }

        /// <summary>
        /// Attempts to load the configuration from the config JSON available at dashboard.airmap.io/developer/.
        /// </summary>
        /// <param name="configJson">The Config JSON available from the developer dashboard.</param>
        /// <returns>An <see cref="APIConfiguration"/> created from the configuration JSON.</returns>
        /// <exception cref="JsonSerializationException">If deserialization of the config JSON fails.</exception>
        public static APIConfiguration CreateFromJSON(string configJson)
        {
            dynamic data = JsonConvert.DeserializeObject(configJson);
            
            return new APIConfiguration
            {
                ClientID = data.auth0?.client_id,
                CallbackURL = new Uri(data.auth0?.callback_url?.ToString() ?? ""),
                APIKey = data.airmap?.api_key,
                MapBoxAccessToken = data.mapbox?.access_token
            };
        }

        /// <summary>
        /// Attempts to load the configuration from a file.
        /// </summary>
        /// <remarks>You can download the configuration JSON from https://dashboard.airmap.io/developer/.</remarks>
        /// <param name="path">The path to the configuration file.</param>
        /// <returns>A <see cref="APIConfiguration"/> created from the configuration file.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="path"/> is null.</exception>
        /// <exception cref="FileNotFoundException">If <paramref name="path"/> does not exist.</exception>
        /// <exception cref="SecurityException">If you do not have permissions to read the file at <paramref name="path"/>.</exception>
        /// <exception cref="JsonSerializationException">If the contents of <paramref name="path"/> does not represent a valid JSON configuration.</exception>
        public static async Task<APIConfiguration> LoadFromFileAsync(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            string absPath = Path.GetFullPath(path);

            if (!File.Exists(absPath))
                throw new FileNotFoundException("Configuration file not found.", absPath);
            
            using (FileStream fs = File.OpenRead(absPath))
            using (StreamReader reader = new StreamReader(fs))
            {
                string contents = await reader.ReadToEndAsync();

                return CreateFromJSON(contents);
            }
        }

        private APIConfiguration()
        {

        }

        /// <summary>
        /// Creates a new <see cref="APIConfiguration"/> from an API key.
        /// </summary>
        /// <param name="apiKey">Your AirMap API key</param>
        public APIConfiguration(string apiKey)
        {
            APIKey = apiKey;
        }
        
        /// <summary>
        /// Creates a new <see cref="APIConfiguration"/> from an API key and a client ID.
        /// </summary>
        /// <param name="apiKey">Your AirMap API key</param>
        /// <param name="clientId">Your AirMap Client ID</param>
        public APIConfiguration(string apiKey, string clientId)
            : this(apiKey)
        {
            ClientID = clientId;
        }
    }
}