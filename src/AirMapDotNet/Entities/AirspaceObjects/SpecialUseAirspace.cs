namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Represents a Special Use Airspace.
    /// </summary>
    /// <remarks>Special Use Airspace includes airspace that is prohibited, restricted or otherwise designated as a dangerous area to operate an aircraft.</remarks>
    [ObjectType("special_use_airspace")]
    public sealed class SpecialUseAirspace : AirspaceObject
    {
        /// <summary>
        /// The type of Special Use Airspace.
        /// </summary>
        public string SUAType => Properties["type"]?.ToString() ?? "";
    }
}