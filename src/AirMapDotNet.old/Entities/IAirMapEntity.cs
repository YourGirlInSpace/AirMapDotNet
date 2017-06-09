using System;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// Represents a requested entity from the AirMap API.
    /// </summary>
    public interface IAirMapEntity
    {
        /// <summary>
        /// The <see cref="AirMap"/> instance used to request the entity.
        /// </summary>
        AirMap AirMap { get; set; }
        /// <summary>
        /// The time the request was completed.
        /// </summary>
        DateTime RequestTime { get; set; }
    }
}