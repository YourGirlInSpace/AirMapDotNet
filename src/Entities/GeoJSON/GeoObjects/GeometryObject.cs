namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// Represents a generic GeoJSON feature.
    /// </summary>
    public abstract class GeometryObject
    {
        /// <summary>
        /// The feature type.
        /// </summary>
        public GeometryObjectType GeometryObjectType { get; protected set; }

        /// <summary>
        /// Creates a new <see cref="GeometryObject"/> with the supplied parameters.
        /// </summary>
        /// <param name="type">The value to assign to <see cref="GeometryObjectType"/>.</param>
        protected GeometryObject(GeometryObjectType type)
        {
            GeometryObjectType = type;
        }
    }
}