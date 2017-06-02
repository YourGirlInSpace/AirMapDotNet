using AirMapDotNet.Entities.GeoJSON;
using AirMapDotNet.Entities.GeoJSON.GeoObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace AirMapDotNet.Tests.Entities.GeoJSON
{
    [TestClass]
    public class FeatureCollectionTest
    {
        private const string FeatureCollectionNoFeatures = @"
{
  'type': 'FeatureCollection',
  'features': []
}";
        private const string FeatureCollectionPointFeature = @"
{
  'type': 'FeatureCollection',
  'features': [
    {
      'type': 'Feature',
      'geometry': {
        'type': 'Point',
        'coordinates': [-103.71093749999999, 36.66841891894786]
      }
    }
  ]
}";

        [TestMethod]
        [TestCategory("AirMapDotNet.Entities.GeoJSON")]
        public void DecodeFeatureCollectionNoFeatures()
        {
            FeatureCollection fc = JsonConvert.DeserializeObject<FeatureCollection>(FeatureCollectionNoFeatures);

            Assert.IsNotNull(fc);
            Assert.IsNotNull(fc.Features);

            Assert.AreEqual(fc.FeatureCollectionType, "FeatureCollection", "FeatureCollectionType is not 'FeatureCollection'!");
            Assert.AreEqual(fc.Features.Count, 0, "Feature count is not zero!");
        }

        [TestMethod]
        [TestCategory("AirMapDotNet.Entities.GeoJSON")]
        public void DecodeFeatureCollectionWithFeature()
        {
            FeatureCollection fc = JsonConvert.DeserializeObject<FeatureCollection>(FeatureCollectionPointFeature);

            Assert.IsNotNull(fc);
            Assert.IsNotNull(fc.Features);

            Assert.AreEqual(fc.FeatureCollectionType, "FeatureCollection", "FeatureCollectionType is not 'FeatureCollection'!");
            Assert.AreEqual(fc.Features.Count, 1, "Feature count is not one!");

            Assert.AreEqual(fc.Features[0].Geometry.GeometryType, GeometryObjectType.Point, "Geometry type is not Point!");
        }

        [TestMethod]
        [TestCategory("AirMapDotNet.Entities.GeoJSON")]
        public void DecodeEncodeFeatureCollectionWithFeature()
        {
            FeatureCollection fc = JsonConvert.DeserializeObject<FeatureCollection>(FeatureCollectionPointFeature);

            string json = JsonConvert.SerializeObject(fc);

            FeatureCollection fc2 = JsonConvert.DeserializeObject<FeatureCollection>(json);

            Assert.AreEqual(fc.FeatureCollectionType, fc2.FeatureCollectionType);
            Assert.AreEqual(fc.Features.Count, fc2.Features.Count);

            Assert.AreEqual(fc.Features.Count, 1);
            Assert.AreEqual(fc2.Features.Count, 1);

            Assert.AreEqual(fc.Features[0].FeatureType, fc2.Features[0].FeatureType);

            Geometry fcGeom = fc.Features[0].Geometry;
            Geometry fc2Geom = fc2.Features[0].Geometry;

            Assert.AreEqual(fcGeom.GeometryType, fc2Geom.GeometryType);

            Assert.IsTrue(fcGeom.GeometryObject is Point);
            Assert.IsTrue(fc2Geom.GeometryObject is Point);

            Point pt1 = (Point) fcGeom.GeometryObject;
            Point pt2 = (Point) fc2Geom.GeometryObject;

            Assert.AreEqual(pt1.Position.Elevation, pt2.Position.Elevation);
            Assert.AreEqual(pt1.Position.LatLon.Latitude, pt2.Position.LatLon.Latitude, 0.0001);
            Assert.AreEqual(pt1.Position.LatLon.Longitude, pt2.Position.LatLon.Longitude, 0.0001);
        }
    }
}
