namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Represents a power plant.
    /// </summary>
    [ObjectType("power_plant")]
    public class PowerPlant : AirspaceObject
    {
        /// <summary>
        /// The type of power plant.
        /// </summary>
        public string Tech => Properties["tech"]?.ToString() ?? "";

        /// <summary>
        /// The power plant's code.
        /// </summary>
        public string PlantCode => Properties["plant_code"]?.ToString() ?? "";
    }
}