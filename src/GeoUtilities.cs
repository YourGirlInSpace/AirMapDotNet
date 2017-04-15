using System;
using AirMapDotNet.Entities.GeoJSON;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;

namespace AirMapDotNet
{
    /// <summary>
    /// Exposes several methods to ease the creation of GeoJSON objects.
    /// </summary>
    public static class GeoUtilities
    {
        /// <summary>
        /// Creates a new <see cref="Geometry"/> object with a rectanglular
        /// <see cref="Polygon"/> feature.
        /// </summary>
        /// <param name="topLeft">The top left coordinate of the rectangle.</param>
        /// <param name="bottomRight">The bottom right coordinate of the rectangle.</param>
        /// <returns>A <see cref="Geometry"/> object with a rectangular <see cref="Polygon"/> feature.</returns>
        /// <exception cref="ArgumentNullException">If either <paramref name="topLeft"/> or <paramref name="bottomRight"/> are null.</exception>
        public static Geometry CreateRectangle(LatLon topLeft, LatLon bottomRight)
        {
            if (topLeft == null)
                throw new ArgumentNullException(nameof(topLeft));
            if (bottomRight == null)
                throw new ArgumentNullException(nameof(bottomRight));

            double latTop = topLeft.Latitude;
            double latBot = bottomRight.Latitude;
            double lonLeft = topLeft.Longitude;
            double lonRight = bottomRight.Longitude;

            LatLon bottomLeft = new LatLon(latBot, lonLeft);
            LatLon topRight = new LatLon(latTop, lonRight);

            Geometry geom = new Geometry {GeometryType = "Polygon"};

            Polygon poly = new Polygon();
            
            LineString ls = new LineString();
            ls.Points.Add(new Position(topLeft));
            ls.Points.Add(new Position(topRight));
            ls.Points.Add(new Position(bottomRight));
            ls.Points.Add(new Position(bottomLeft));
            ls.Points.Add(new Position(topLeft));

            poly.Boundaries.Add(ls);

            geom.GeometryObject = poly;

            return geom;
        }

        /// <summary>
        /// Creates a new <see cref="Geometry"/> object with a circular
        /// <see cref="Polygon"/> feature with a radius of <paramref name="radius"/> and the center position <paramref name="center"/>.
        /// </summary>
        /// <param name="center">The center position.</param>
        /// <param name="radius">The radius of the circle in meters.</param>
        /// <returns>A <see cref="Geometry"/> object with a circular <see cref="Polygon"/> feature.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="center"/> is null.</exception>
        public static Geometry CreateCircle(LatLon center, double radius)
        {
            return CreateCircle(center, radius, 16);
        }

        /// <summary>
        /// Creates a new <see cref="Geometry"/> object with a circular
        /// <see cref="Polygon"/> feature with a radius of <paramref name="radius"/> and the center position <paramref name="center"/>.
        /// </summary>
        /// <param name="center">The center position.</param>
        /// <param name="radius">The radius of the circle in meters.</param>
        /// <param name="points">The number of points describing the circumference of the circle up to a maximum of 64.</param>
        /// <returns>A <see cref="Geometry"/> object with a circular <see cref="Polygon"/> feature.</returns>
        /// <exception cref="ArgumentOutOfRangeException">If the number of points is less than 3 or greater than 64.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="center"/> is null.</exception>
        public static Geometry CreateCircle(LatLon center, double radius, int points)
        {
            if (center == null)
                throw new ArgumentNullException(nameof(center));
            if (points < 3 || points > 64)
                throw new ArgumentOutOfRangeException(nameof(points), $"{nameof(points)} must be between 3 and 64!");

            double iter = 360.0/points;
            
            Geometry geom = new Geometry {GeometryType = "Polygon"};

            Polygon poly = new Polygon();

            LineString ls = new LineString();
            for (double i = 0; i < 360.0; i += iter)
                ls.Points.Add(new Position(center.Project(i, radius)));

            // Copy the first point to the end to close the loop.
            ls.Points.Add(ls.Points[0]);

            poly.Boundaries.Add(ls);

            geom.GeometryObject = poly;

            return geom;
        }

        /// <summary>
        /// Creates a new path (a <see cref="LineString"/>) from a list of <see cref="LatLon" /> points.
        /// </summary>
        /// <param name="points">The points comprising the path.</param>
        /// <returns>A <see cref="Geometry"/> with a <see cref="LineString"/> feature.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="points"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="points"/> contains less than 2 elements.</exception>
        public static Geometry CreatePath(params LatLon[] points)
        {
            if (points == null)
                throw new ArgumentNullException(nameof(points));
            if (points.Length < 2)
                throw new ArgumentOutOfRangeException(nameof(points), $"{nameof(points)} must have at least 2 elements.");

            Geometry geom = new Geometry {GeometryType = "LineString"};
            
            LineString ls = new LineString();
            foreach (LatLon pt in points)
                ls.Points.Add(new Position(pt));

            geom.GeometryObject = ls;

            return geom;
        }
    }
}