using System;

namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class GeometryTypeAttribute : Attribute
    {
        /// <summary>
        /// The name of the type.
        /// </summary>
        public GeometryObjectType ObjectType { get; }

        /// <summary>
        /// Creates a new <see cref="GeometryTypeAttribute"/> with a specified <see cref="GeometryObjectType"/>.
        /// </summary>
        /// <param name="typeEnum">The value to assign to <see cref="ObjectType"/>.</param>
        public GeometryTypeAttribute(GeometryObjectType typeEnum)
        {
            ObjectType = typeEnum;
        }
    }
}