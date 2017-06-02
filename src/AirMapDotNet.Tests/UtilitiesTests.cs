using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;

namespace AirMapDotNet.Tests
{
    [TestClass]
    [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
    [SuppressMessage("ReSharper", "ExpressionIsAlwaysNull")]
    [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
    public class UtilitiesTests
    {
        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void GetTypesWithAttribute_ValidType_OK()
        {
            Assembly amdn = Assembly.GetAssembly(typeof(GeometryTypeAttribute));

            IEnumerable<Type> typesWithAttribute = Utilities.GetTypesWithAttribute<GeometryTypeAttribute>(amdn);

            IEnumerable<Type> withAttribute = typesWithAttribute as IList<Type> ?? typesWithAttribute.ToList();

            Assert.AreEqual(7, withAttribute.Count(), 0, "Type count not equal!");

            Assert.IsTrue(withAttribute.Contains(typeof(GeometryCollection)));
            Assert.IsTrue(withAttribute.Contains(typeof(LineString)));
            Assert.IsTrue(withAttribute.Contains(typeof(MultiLineString)));
            Assert.IsTrue(withAttribute.Contains(typeof(MultiPoint)));
            Assert.IsTrue(withAttribute.Contains(typeof(MultiPolygon)));
            Assert.IsTrue(withAttribute.Contains(typeof(Point)));
            Assert.IsTrue(withAttribute.Contains(typeof(Polygon)));
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void GetTypesWithAttribute_InvalidType_OK()
        {
            Assembly amdn = Assembly.GetAssembly(typeof(GeometryObject));

            IEnumerable<Type> typesWithAttribute = Utilities.GetTypesWithAttribute<ClassInitializeAttribute>(amdn);

            Assert.AreEqual(0, typesWithAttribute.Count());
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void GetTypesWithAttribute_ValidTypeInvalidAssembly_OK()
        {
            IEnumerable<Type> typesWithAttribute = Utilities.GetTypesWithAttribute<GeometryTypeAttribute>(Assembly.GetExecutingAssembly());

            Assert.AreEqual(0, typesWithAttribute.Count());
        }

        [TestMethod]
        public void ToRadians_Valid_OK()
        {
            Assert.AreEqual(Math.PI, Utilities.ToRadians(180), 1e-8);
        }

        [TestMethod]
        public void ToDegrees_Valid_OK()
        {
            Assert.AreEqual(180, Utilities.ToDegrees(Math.PI), 1e-8);
        }

        [TestMethod]
        public void DateTimeFromTimestamp_Valid_OK()
        {
            // Suppose you know exactly when this test was made, eh?
            const long millis = 1496313433000;
            DateTime equivTime = new DateTime(2017, 6, 1, 10, 37, 13, DateTimeKind.Utc);

            Assert.AreEqual(equivTime, Utilities.DateTimeFromTimestamp(millis));
        }
    }
}