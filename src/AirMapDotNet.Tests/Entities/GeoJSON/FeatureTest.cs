using AirMapDotNet.Entities.GeoJSON;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace AirMapDotNet.Tests.Entities.GeoJSON
{
    [TestClass]
    public class FeatureTest
    {
        private const string FeatureNoProperties = @"
{
  'type': 'Feature',
  'geometry': {
    'type': 'Point',
    'coordinates': [-103.71093749999999, 36.66841891894786]
  }
}
";
        private const string FeatureWithProperties = @"
{
  'type': 'Feature',
  'properties': {
    'testKey': 'testValue'
  },
  'geometry': {
    'type': 'Point',
    'coordinates': [-103.71093749999999, 36.66841891894786]
  }
}
";
        [TestMethod]
        [TestCategory("AirMapDotNet.Entities.GeoJSON")]
        public void DecodeFeatureNoProperties()
        {
            Feature feature = JsonConvert.DeserializeObject<Feature>(FeatureNoProperties);

            Assert.IsNotNull(feature);
            Assert.IsNotNull(feature.Geometry);
            Assert.IsNotNull(feature.Properties);

            Assert.AreEqual(feature.FeatureType, "Feature", "FeatureType is not 'Feature'!");
            Assert.AreEqual(feature.Properties.Count, 0, "Unknown properties in play!");
        }

        [TestMethod]
        [TestCategory("AirMapDotNet.Entities.GeoJSON")]
        public void DecodeFeatureWithProperties()
        {
            Feature feature = JsonConvert.DeserializeObject<Feature>(FeatureWithProperties);

            Assert.IsNotNull(feature);
            Assert.IsNotNull(feature.Geometry);
            Assert.IsNotNull(feature.Properties);

            Assert.AreEqual(feature.FeatureType, "Feature", "FeatureType is not 'Feature'!");
            Assert.AreEqual(feature.Properties.Count, 1, "Unknown properties in play!");

            Assert.IsTrue(feature.Properties.ContainsKey("testKey"), "Properties does not contain testKey!");
            Assert.AreEqual(feature.Properties["testKey"], "testValue", "Property 'testKey' does not equal 'testValue'!");
        }
    }
}
