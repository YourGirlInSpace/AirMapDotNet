using Newtonsoft.Json;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// A representation of AirMap's error name-message object.
    /// </summary>
    public class NameMessagePair
    {
        /// <summary>
        /// The name of the query parameter that failed.
        /// </summary>
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The reason why the query parameter failed.
        /// </summary>
        [JsonProperty("message")]
        public virtual string Message { get; set; }
    }
}