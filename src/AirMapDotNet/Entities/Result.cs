using Newtonsoft.Json;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// Represents a JSend API result.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// The status of the request.
        /// </summary>
        [JsonProperty("status")]
        public virtual string Status { get; internal set; }
    }

    /// <summary>
    /// Represents a JSend API result with data object <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The underlying type representing the JSend "data" property.</typeparam>
    public sealed class Result<T> : Result
        where T : class, IAirMapEntity
    {
        /// <summary>
        /// The actual result of the query.
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; internal set; }
    }
}