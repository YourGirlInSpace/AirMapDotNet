using System.Collections.ObjectModel;

namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// A collection of multiple <see cref="Geometry"/> objects.
    /// </summary>
    // I am suppressing this message because this is exactly what the GeoJSON specification calls
    // this object.  RFC7946 § 3.1.8
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
    public sealed class GeometryCollection : GeometryObject
    {
        /// <summary>
        /// The <see cref="Geometry"/> objects comprising this <see cref="GeometryCollection"/>.
        /// </summary>
        public Collection<Geometry> Geometries { get; } = new Collection<Geometry>();

        /// <summary>
        /// Creates a new <see cref="GeometryCollection"/>.
        /// </summary>
        public GeometryCollection()
            : base(GeometryObjectType.Collection)
        {
        }
    }
}