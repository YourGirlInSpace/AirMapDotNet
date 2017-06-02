namespace AirMapDotNet.Entities.TrafficAPI
{
    /// <summary>
    /// Represents the type of traffic described in <see cref="Traffic"/>
    /// </summary>
    public enum TrafficType
    {
        /// <summary>
        /// Traffic that is heading towards the tracked aircraft and will
        /// be within 1km within 30 seconds.
        /// </summary>
        Alert,
        /// <summary>
        /// Traffic that is within 10 miles.
        /// </summary>
        SituationalAwareness
    }
}