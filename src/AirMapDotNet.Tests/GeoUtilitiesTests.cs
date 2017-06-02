using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirMapDotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirMapDotNet.Entities.GeoJSON;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;

namespace AirMapDotNet.Tests
{
    [TestClass()]
    [SuppressMessage("ReSharper", "ExpressionIsAlwaysNull")]
    public class GeoUtilitiesTests
    {
        private const double TOLERANCE = 1e-5;

        [TestMethod]
        public void CreateRectangle_Valid_OK()
        {
            LatLon topLeft = new LatLon(28, -81);
            LatLon bottomRight = new LatLon(27, -80);

            Geometry rect = GeoUtilities.CreateRectangle(topLeft, bottomRight);

            Assert.AreEqual(rect.GeometryType, GeometryObjectType.Polygon);
            Assert.IsInstanceOfType(rect.GeometryObject, typeof(Polygon));

            Polygon poly = rect.GeometryObject as Polygon;

            Assert.IsNotNull(poly);
            Assert.AreEqual(1, poly.Boundaries.Count);

            LineString ls = poly.Boundaries[0];

            // The first point is copied onto the last point
            Assert.AreEqual(2, ls.Points.Count(x => Math.Abs(x.LatLon.Latitude - 28) < TOLERANCE && Math.Abs(x.LatLon.Longitude - -81) < TOLERANCE));
            Assert.AreEqual(1, ls.Points.Count(x => Math.Abs(x.LatLon.Latitude - 27) < TOLERANCE && Math.Abs(x.LatLon.Longitude - -81) < TOLERANCE));
            Assert.AreEqual(1, ls.Points.Count(x => Math.Abs(x.LatLon.Latitude - 28) < TOLERANCE && Math.Abs(x.LatLon.Longitude - -80) < TOLERANCE));
            Assert.AreEqual(1, ls.Points.Count(x => Math.Abs(x.LatLon.Latitude - 27) < TOLERANCE && Math.Abs(x.LatLon.Longitude - -80) < TOLERANCE));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateRectangle_TopLeftNull_ThrowsANE()
        {
            LatLon topLeft = null;
            LatLon bottomRight = new LatLon(27, -80);

            GeoUtilities.CreateRectangle(topLeft, bottomRight);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateRectangle_BottomRightNull_ThrowsANE()
        {
            LatLon topLeft = new LatLon(28, -81);
            LatLon bottomRight = null;

            GeoUtilities.CreateRectangle(topLeft, bottomRight);
        }

        [TestMethod]
        public void CreateCircle_Valid_OK()
        {
            const int DISTANCE = 250;
            const int DELTA = 5;

            LatLon center = new LatLon(28, -81);

            Geometry rect = GeoUtilities.CreateCircle(center, DISTANCE);

            Assert.AreEqual(rect.GeometryType, GeometryObjectType.Polygon);
            Assert.IsInstanceOfType(rect.GeometryObject, typeof(Polygon));

            Polygon poly = rect.GeometryObject as Polygon;

            Assert.IsNotNull(poly);
            Assert.AreEqual(1, poly.Boundaries.Count);

            LineString ls = poly.Boundaries[0];

            Assert.AreEqual(17, ls.Points.Count);
            Assert.IsTrue(ls.Points.All(x => Math.Abs(center.Distance(x.LatLon) - DISTANCE) < DELTA));
        }

        [TestMethod]
        public void CreateCircle_Valid32Points_OK()
        {
            const int DISTANCE = 250;
            const int DELTA = 5;
            const int POINTS = 32;

            LatLon center = new LatLon(28, -81);

            Geometry rect = GeoUtilities.CreateCircle(center, DISTANCE, POINTS);

            Assert.AreEqual(rect.GeometryType, GeometryObjectType.Polygon);
            Assert.IsInstanceOfType(rect.GeometryObject, typeof(Polygon));

            Polygon poly = rect.GeometryObject as Polygon;

            Assert.IsNotNull(poly);
            Assert.AreEqual(1, poly.Boundaries.Count);

            LineString ls = poly.Boundaries[0];

            Assert.AreEqual(POINTS + 1, ls.Points.Count);
            Assert.IsTrue(ls.Points.All(x => Math.Abs(center.Distance(x.LatLon) - DISTANCE) < DELTA));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateCircle_CenterNull_ThrowsANE()
        {
            const int DISTANCE = 250;
            const int POINTS = 32;

            LatLon center = null;

            GeoUtilities.CreateCircle(center, DISTANCE, POINTS);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateCircle_PointsZero_ThrowsAOORE()
        {
            const int DISTANCE = 250;
            const int POINTS = 0;

            LatLon center = new LatLon(0, 0);

            GeoUtilities.CreateCircle(center, DISTANCE, POINTS);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateCircle_PointsTenMillion_ThrowsAOORE()
        {
            const int DISTANCE = 250;
            const int POINTS = 10000000;

            LatLon center = new LatLon(0, 0);

            GeoUtilities.CreateCircle(center, DISTANCE, POINTS);
        }
    }
}