namespace AirMapDotNet.Services
{
    /// <summary>
    /// Represents a service exposing methods for the AirMap API.
    /// </summary>
    internal class AirMapService : IAirMapService
    {
        /// <summary>
        /// The current AirMap instance.
        /// </summary>
        public AirMap AirMap { get; protected set; }

        internal AirMapService(AirMap am)
        {
            AirMap = am;
        }
    }
}