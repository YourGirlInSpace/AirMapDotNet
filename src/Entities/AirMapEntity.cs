using Newtonsoft.Json;
using System;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// Represents a requested entity from the AirMap API.
    /// </summary>
    public class AirMapEntity : IAirMapEntity
    {
        /// <inheritdoc />
        [JsonIgnore]
        public virtual AirMap AirMap { get; set; }

        /// <inheritdoc />
        [JsonIgnore]
        public virtual DateTime RequestTime { get; set; }
    }
}