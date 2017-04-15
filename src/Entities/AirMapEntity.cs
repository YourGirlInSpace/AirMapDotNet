using System;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// Represents a requested entity from the AirMap API.
    /// </summary>
    public class AirMapEntity : IAirMapEntity
    {
        /// <inheritdoc />
        public virtual AirMap AirMap { get; set; }

        /// <inheritdoc />
        public virtual DateTime RequestTime { get; set; }
    }
}