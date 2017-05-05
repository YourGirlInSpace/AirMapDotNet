namespace AirMapDotNet.Services
{
    /// <summary>
    /// Represents a service exposing methods for the AirMap API.
    /// </summary>
    internal interface IAirMapService
    {
        /// <summary>
        /// The current AirMap instance.
        /// </summary>
        AirMap AirMap { get; }
    }
}