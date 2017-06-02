namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Represents a wildfire.
    /// </summary>
    [ObjectType("fire")]
    public sealed class Wildfire : AirspaceObject
    {
        /// <summary>
        /// The date this restriction is valid.
        /// </summary>
        /// <remarks>This is not a DateTime object due to the lack of a time zone.</remarks>
        public string EffectiveDate => Properties["date_effective"]?.ToString() ?? "";
    }
}