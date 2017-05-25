using System;
using System.Threading.Tasks;
using Auth0;
using Auth0.AuthenticationApi;
using Auth0.AuthenticationApi.Models;

namespace AirMapDotNet.Authentication
{
    /// <summary>
    /// Provides several methods used for authenticating end users.
    /// </summary>
    public static class AuthenticationService
    {
        /// <summary>
        /// The AirMap single signon gateway domain.
        /// </summary>
        private const string AIRMAP_SSO_DOMAIN = "sso.airmap.io";

        /// <summary>
        /// The default connection used for <see cref="LoginAsync"/>.
        /// </summary>
        private const string DEFAULT_CONNECTION = "Username-Password-Authentication";
        
        private static readonly Lazy<AuthenticationApiClient> _client =
            new Lazy<AuthenticationApiClient>(() => new AuthenticationApiClient(AIRMAP_SSO_DOMAIN));

        /// <summary>
        /// Attempts to log in via the AirMap SSO.
        /// </summary>
        /// <param name="config">The API configuration to use.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>A <see cref="AuthenticationToken"/> if authentication was successful.</returns>
        /// <exception cref="AuthenticationException">If authentication was unsuccessful or user data was not available.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="APIConfiguration.ClientID"/> property was not set.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="config"/> is null.</exception>
        public static async Task<AuthenticationToken> LoginAsync(APIConfiguration config, string username, string password)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (string.IsNullOrEmpty(config.ClientID))
                throw new AuthenticationException("Client ID not set.");
            
            AuthenticationRequest req = new AuthenticationRequest
            {
                Connection = DEFAULT_CONNECTION,
                ClientId = config.ClientID,
                Username = username,
                Password = password,
                Scope = "openid"
            };

            AuthenticationResponse resp;
            User user;

            try
            {
                resp = await _client.Value.AuthenticateAsync(req);
            }
            catch (Exception ex)
            {
                throw new AuthenticationException("Failed to authenticate user.", ex);
            }

            try
            {
                user = (User) await _client.Value.GetUserInfoAsync(resp.AccessToken);
            }
            catch (Exception ex)
            {
                throw new AuthenticationException("Failed to get user information.", ex);
            }
            
            AuthenticationToken at = new AuthenticationToken(resp.IdToken, user);

            return at;
        }
    }
}