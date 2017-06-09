using System;

namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Represents a temporary flight restriction.
    /// </summary>
    [ObjectType("tfr")]
    public sealed class TFR : AirspaceObject
    {
        /// <summary>
        /// A detailed FAA URL describing the TFR.
        /// </summary>
        public Uri URL => new Uri(Properties["url"]?.ToString() ?? "");

        /// <summary>
        /// The type of TFR.
        /// </summary>
        public string TFRType => Properties["type"]?.ToString() ?? "";

        /// <summary>
        /// The reason for the TFR.
        /// </summary>
        public string NOTAMReason => Properties["notam_reason"]?.ToString() ?? "";
    }
}