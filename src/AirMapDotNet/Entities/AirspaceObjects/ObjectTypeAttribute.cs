using System;

namespace AirMapDotNet.Entities.AirspaceObjects
{
    /// <summary>
    /// Provides a description of a type, and allows it to be implicitly deserialized to
    /// a class via <see cref="AirspaceObject.Deserialize"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class ObjectTypeAttribute : Attribute
    {
        /// <summary>
        /// The name of the type.
        /// </summary>
        public string TypeName { get; }

        /// <summary>
        /// Creates a new <see cref="ObjectTypeAttribute"/> with a specified type name.
        /// </summary>
        /// <param name="typeName">The value to assign to <see cref="TypeName"/>.</param>
        public ObjectTypeAttribute(string typeName)
        {
            TypeName = typeName;
        }
    }
}