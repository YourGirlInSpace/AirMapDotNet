namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Represents a registered heliport.
    /// </summary>
    [ObjectType("heliport")]
    public sealed class Heliport : AirspaceObject
    {
        /// <summary>
        /// The ICAO identifier for this heliport.
        /// </summary>
        public string ICAO => Properties["faa"]?.ToString() ?? "";
        
        /// <summary>
        /// The phone number for the heliport manager or other authority.
        /// </summary>
        public string Phone => Properties["phone"]?.ToString() ?? "";

        /// <summary>
        /// The availability of the heliport for the public.
        /// </summary>
        /// <remarks>This property is here because public heliports will usually have
        /// higher traffic than a private use heliport.</remarks>
        public string Use => Properties["use"]?.ToString() ?? "";
    }
}