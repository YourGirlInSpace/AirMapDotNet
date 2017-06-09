using Newtonsoft.Json;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// Represents a JWT payload.
    /// </summary>
    /// <remarks>For information on JWT, see https://jwt.io</remarks>
    public sealed class JWTPayload
    {
        /// <summary>
        /// The Issuer field.
        /// </summary>
        [JsonProperty("iss")]
        public string Issuer { get; set; }

        /// <summary>
        /// The Subject field.
        /// </summary>
        [JsonProperty("sub")]
        public string Subject { get; set; }

        /// <summary>
        /// The Audience field.
        /// </summary>
        [JsonProperty("aud")]
        public string Audience { get; set; }

        /// <summary>
        /// The Expiry field.
        /// </summary>
        [JsonProperty("exp")]
        public long Expiry { get; set; }

        /// <summary>
        /// The Issued At field.
        /// </summary>
        [JsonProperty("iat")]
        public long IssuedAt { get; set; }
    }
}