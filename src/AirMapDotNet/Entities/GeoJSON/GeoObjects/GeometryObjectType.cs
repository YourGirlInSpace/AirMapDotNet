namespace AirMapDotNet.Entities.GeoJSON.GeoObjects
{
    /// <summary>
    /// The type of feature.
    /// </summary>
    public enum GeometryObjectType
    {
        /// <summary>
        /// A <see cref="GeoObjects.Point"/>.
        /// </summary>
        Point,
        /// <summary>
        /// A <see cref="GeoObjects.MultiPoint"/>.
        /// </summary>
        MultiPoint,
        /// <summary>
        /// A <see cref="GeoObjects.LineString"/>.
        /// </summary>
        LineString,
        /// <summary>
        /// A <see cref="GeoObjects.MultiLineString"/>.
        /// </summary>
        MultiLineString,
        /// <summary>
        /// A <see cref="GeoObjects.Polygon"/>.
        /// </summary>
        Polygon,
        /// <summary>
        /// A <see cref="GeoObjects.MultiPolygon"/>.
        /// </summary>
        MultiPolygon,
        /// <summary>
        /// A <see cref="GeometryCollection"/>.
        /// </summary>
        Collection
    }
}