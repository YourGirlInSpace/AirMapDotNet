using Newtonsoft.Json;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// Represents a JWT payload.
    /// </summary>
    /// <remarks>For information on JWT, see https://jwt.io</remarks>
    public class JWTPayload
    {
        /// <summary>
        /// The Issuer field.
        /// </summary>
        [JsonProperty("iss")]
        public virtual string Issuer { get; set; }

        /// <summary>
        /// The Subject field.
        /// </summary>
        [JsonProperty("sub")]
        public virtual string Subject { get; set; }

        /// <summary>
        /// The Audience field.
        /// </summary>
        [JsonProperty("aud")]
        public virtual string Audience { get; set; }

        /// <summary>
        /// The Expiry field.
        /// </summary>
        [JsonProperty("exp")]
        public virtual long Expiry { get; set; }

        /// <summary>
        /// The Issued At field.
        /// </summary>
        [JsonProperty("iat")]
        public virtual long IssuedAt { get; set; }
    }
}