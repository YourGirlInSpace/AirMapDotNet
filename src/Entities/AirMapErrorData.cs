using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// Represents an Error data response from the AirMap API server.
    /// </summary>
    public class AirMapErrorData : AirMapEntity
    {
        /// <summary>
        /// An array of <see cref="NameMessagePair"/>s that describes each problematic query and how it failed.
        /// </summary>
        [JsonProperty("errors")]
        public virtual Collection<NameMessagePair> Errors { get; }
    }
}