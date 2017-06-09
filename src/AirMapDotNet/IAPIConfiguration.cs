using System;

namespace AirMapDotNet
{
    public interface IAPIConfiguration
    {

        /// <summary>
        /// The Auth0 Client ID.
        /// </summary>
        string ClientID { get; }

        /// <summary>
        /// The AirMap API key.
        /// </summary>
        string APIKey { get; }

        /// <summary>
        /// The OAuth2 callback URL.
        /// </summary>
        Uri CallbackURL { get; }

        /// <summary>
        /// The access token for the MapBox API.
        /// </summary>
        string MapBoxAccessToken { get; }
    }
}