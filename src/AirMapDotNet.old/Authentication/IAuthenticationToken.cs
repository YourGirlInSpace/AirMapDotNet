using System;

namespace AirMapDotNet.Authentication
{
    /// <summary>
    /// The Authentication Token used to access user-restricted features of the AirMap API.
    /// </summary>
    public interface IAuthenticationToken
    {

        /// <summary>
        /// The user that was authenticated with this token.
        /// </summary>
        IUser User { get; }
        
        /// <summary>
        /// The issuer field of the ID token.
        /// </summary>
        /// <value>Should always be https://sso.airmap.io/</value>
        string Issuer { get; }

        /// <summary>
        /// The subject field of the ID token.
        /// </summary>
        /// <value>The authenticated user's unique ID.</value>
        string Subject { get; }

        /// <summary>
        /// The audience field of the ID token.
        /// </summary>
        /// <value>This value should match the Client ID in the developer portal.</value>
        string Audience { get; }

        /// <summary>
        /// The time when this authentication token was generated.
        /// </summary>
        DateTime IssuedAt { get; }

        /// <summary>
        /// The time when this authentication token expires.
        /// </summary>
        DateTime Expiry { get; }

        /// <summary>
        /// The authentication token's validity.  <b>True</b> if the token is valid and in date, otherwise <b>false</b>.
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// The full token passed in the Authentication HTTP header.
        /// </summary>
        string Token { get; }
    }
}