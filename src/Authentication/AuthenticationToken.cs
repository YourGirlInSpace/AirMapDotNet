using System;

namespace AirMapDotNet.Authentication
{
    /// <summary>
    /// The Authentication Token used to access user-restricted features of the AirMap API.
    /// </summary>
    public sealed class AuthenticationToken
    {
        /// <summary>
        /// The user that was authenticated with this token.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// The full token passed in the Authentication HTTP header.
        /// </summary>
        public string Token { get; }

        /// <summary>
        /// Creates a new <see cref="AuthenticationToken"/> from a JWT-encoded ID token.
        /// </summary>
        /// <param name="token">A JWT-encoded ID token provided by AirMap's SSO</param>
        /// <exception cref="ArgumentNullException">If <paramref name="token"/> is null.</exception>
        public AuthenticationToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException(nameof(token));
            
            Token = token;
        }

        internal AuthenticationToken(string token, User user)
            : this(token)
        {
            User = user;
        }
    }
}