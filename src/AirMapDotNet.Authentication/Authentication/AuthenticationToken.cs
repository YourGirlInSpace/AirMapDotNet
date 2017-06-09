using System;
using AirMapDotNet.Entities;
using Newtonsoft.Json;
using System.Text;

namespace AirMapDotNet.Authentication
{
    /// <summary>
    /// The Authentication Token used to access user-restricted features of the AirMap API.
    /// </summary>
    public sealed class AuthenticationToken : IAuthenticationToken
    {
        /// <summary>
        /// The user that was authenticated with this token.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Represents the current epoch -- January 1st, 1970 at 0:00Z.
        /// </summary>
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        
        /// <summary>
        /// The issuer field of the ID token.
        /// </summary>
        /// <value>Should always be https://sso.airmap.io/</value>
        public string Issuer { get; }

        /// <summary>
        /// The subject field of the ID token.
        /// </summary>
        /// <value>The authenticated user's unique ID.</value>
        public string Subject { get; }

        /// <summary>
        /// The audience field of the ID token.
        /// </summary>
        /// <value>This value should match the Client ID in the developer portal.</value>
        public string Audience { get; }

        /// <summary>
        /// The time when this authentication token was generated.
        /// </summary>
        public DateTime IssuedAt { get; }

        /// <summary>
        /// The time when this authentication token expires.
        /// </summary>
        public DateTime Expiry { get; }

        /// <summary>
        /// The authentication token's validity.  <b>True</b> if the token is valid and in date, otherwise <b>false</b>.
        /// </summary>
        public bool IsValid => Expiry > DateTime.UtcNow;

        /// <summary>
        /// The full token passed in the Authentication HTTP header.
        /// </summary>
        public string Token { get; }

        /// <summary>
        /// Creates a new <see cref="AuthenticationToken"/> from a JWT-encoded ID token.
        /// </summary>
        /// <param name="token">A JWT-encoded ID token provided by AirMap's SSO</param>
        /// <exception cref="ArgumentNullException">If <paramref name="token"/> is null.</exception>
        /// <exception cref="AuthenticationException">If <paramref name="token"/> is not a valid JWT token.</exception>
        public AuthenticationToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException(nameof(token));
            
            try
            {
                string[] idTokenParts = token.Split('.');

                string payload = Encoding.UTF8.GetString(Convert.FromBase64String(PadBase64(idTokenParts[1])));
                JWTPayload payloadData = JsonConvert.DeserializeObject<JWTPayload>(payload);

                Token = token;
                Issuer = payloadData.Issuer;
                Subject = payloadData.Subject;
                Audience = payloadData.Audience;

                IssuedAt = Epoch.AddSeconds(payloadData.IssuedAt);
                Expiry = Epoch.AddSeconds(payloadData.Expiry);
            } catch
            {
                throw new AuthenticationException("Supplied token does not appear to be a JWT token!");
            }
        }

        internal AuthenticationToken(string token, User user)
            : this(token)
        {
            User = user;
        }

        /// <summary>
        /// Pads a Base64 string to a length divisible by four.
        /// </summary>
        /// <param name="b64">The input Base64 string.</param>
        /// <returns>The padded Base64 string.</returns>
        private static string PadBase64(string b64)
        {
            return b64.PadRight(b64.Length + (4 - b64.Length % 4) % 4, '=');
        }
    }
}