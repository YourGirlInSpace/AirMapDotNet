using AirMapDotNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace AirMapDotNet.Tests
{
    [TestClass]
    [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
    [SuppressMessage("ReSharper", "ExpressionIsAlwaysNull")]
    [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
    public class LatLonTests
    {
        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_NoArguments_OK()
        {
            LatLon ll = new LatLon();

            Assert.AreEqual(0, ll.Latitude, 1e-5, "Latitude == 0");
            Assert.AreEqual(0, ll.Longitude, 1e-5, "Longitude == 0");
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_PlainArguments_IsValid()
        {
            LatLon ll = new LatLon(26, -81);

            Assert.AreEqual(26, ll.Latitude, 1e-5, "Latitude == 26");
            Assert.AreEqual(-81, ll.Longitude, 1e-5, "Longitude == -81");
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_PlainLatitudeOutOfRangeHigh_OutOfRangeException()
        {
            new LatLon(999, 0);
        }
        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_PlainLatitudeOutOfRangeLow_OutOfRangeException()
        {
            new LatLon(-999, 0);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_PlainLongitudeOutOfRangeHigh_OutOfRangeException()
        {
            new LatLon(0, 999);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_PlainLongitudeOutOfRangeLow_OutOfRangeException()
        {
            new LatLon(0, -999);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_MeasurementLatitudeOutOfRangeHigh_OutOfRangeException()
        {
            var lat = 999;
            var lon = 0;

            new LatLon(lat, lon);
        }
        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_MeasurementLatitudeOutOfRangeLow_OutOfRangeException()
        {
            var lat = -999;
            var lon = 0;

            new LatLon(lat, lon);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_MeasurementLongitudeOutOfRangeHigh_OutOfRangeException()
        {
            var lat = 0;
            var lon = 999;

            new LatLon(lat, lon);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Constructor_MeasurementLongitudeOutOfRangeLow_OutOfRangeException()
        {
            var lat = 0;
            var lon = -999;

            new LatLon(lat, lon);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Project_ValidArguments_IsCorrect()
        {
            LatLon LAX_Rwy_25R = new LatLon(33.9398772, -118.37977695);
            LatLon LAX_Rwy_7L = new LatLon(33.93583058333333, -118.41934175);

            LatLon projected = LAX_Rwy_25R.Project(263, 3685.3368);

            Assert.AreEqual(LAX_Rwy_7L.Latitude, projected.Latitude, 1e-3);
            Assert.AreEqual(LAX_Rwy_7L.Longitude, projected.Longitude, 1e-3);
        }



        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentNullException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Distance_OtherNull_ThrowsArgumentNullException()
        {
            LatLon LAX_Rwy_25R = new LatLon(33.9398772, -118.37977695);

            LAX_Rwy_25R.Distance(null);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Distance_ValidArguments_IsCorrect()
        {
            LatLon LAX_Rwy_25R = new LatLon(33.9398772, -118.37977695);
            LatLon LAX_Rwy_7L = new LatLon(33.93583058333333, -118.41934175);

            double dist = LAX_Rwy_25R.Distance(LAX_Rwy_7L) * 3.28084;

            // Is the distance valid to within 25 feet?
            Assert.AreEqual(12091, dist, 25);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentNullException))]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Bearing_OtherNull_ThrowsArgumentNullException()
        {
            LatLon LAX_Rwy_25R = new LatLon(33.9398772, -118.37977695);

            LAX_Rwy_25R.Bearing(null);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Bearing_ValidArguments_IsCorrect()
        {
            LatLon LAX_Rwy_25R = new LatLon(33.9398772, -118.37977695);
            LatLon LAX_Rwy_7L = new LatLon(33.93583058333333, -118.41934175);

            double bear = LAX_Rwy_25R.Bearing(LAX_Rwy_7L);

            // Is the distance valid to within 1 degree?
            Assert.AreEqual(263, bear, 1);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void ToDMS_NaN_IsCorrect()
        {
            LatLon ll = new LatLon();

            string dms = ll.ToDMS();

            // Is the distance valid to within 1 degree?
            Assert.AreEqual("00°00'00.0\"N 00°00'00.0\"E", dms);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void ToDMS_ValidLLNW_IsCorrect()
        {
            LatLon ll = new LatLon(33.9398772, -118.37977695);

            string dms = ll.ToDMS();

            // Is the distance valid to within 1 degree?
            Assert.AreEqual("33°56'23.6\"N 118°22'47.2\"W", dms);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void ToDMS_ValidLLSE_IsCorrect()
        {
            LatLon ll = new LatLon(-33.9398772, 118.37977695);

            string dms = ll.ToDMS();

            // Is the distance valid to within 1 degree?
            Assert.AreEqual("33°56'23.6\"S 118°22'47.2\"E", dms);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorEquality_ABEqual_IsTrue()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(33.9398772, -118.37977695);

            bool rez = a == b;

            Assert.IsTrue(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorEquality_ABNotEqual_IsFalse()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(34.9398772, -118.37977695);

            bool rez = a == b;

            Assert.IsFalse(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorEquality_ANull_IsFalse()
        {
            LatLon a = null;
            LatLon b = new LatLon(34.9398772, -118.37977695);

            bool rez = a == b;

            Assert.IsFalse(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorEquality_BNull_IsFalse()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = null;

            bool rez = a == b;

            Assert.IsFalse(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorEquality_ABNull_IsTrue()
        {
            LatLon a = null;
            LatLon b = null;

            bool rez = a == b;

            Assert.IsTrue(rez);
        }


        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorInequality_ABEqual_IsFalse()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(33.9398772, -118.37977695);

            bool rez = a != b;

            Assert.IsFalse(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorInequality_ABNotEqual_IsTrue()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(34.9398772, -118.37977695);

            bool rez = a != b;

            Assert.IsTrue(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorInequality_ANull_IsTrue()
        {
            LatLon a = null;
            LatLon b = new LatLon(34.9398772, -118.37977695);

            bool rez = a != b;

            Assert.IsTrue(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorInequality_BNull_IsTrue()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = null;

            bool rez = a != b;

            Assert.IsTrue(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void OperatorInequality_ABNull_IsTrue()
        {
            LatLon a = null;
            LatLon b = null;

            bool rez = a != b;

            Assert.IsFalse(rez);
        }



        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Equals_ABEqual_IsTrue()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(33.9398772, -118.37977695);

            bool rez = a.Equals(b);

            Assert.IsTrue(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Equals_ABNotEqual_IsFalse()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(34.9398772, -118.37977695);

            bool rez = a.Equals(b);

            Assert.IsFalse(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void Equals_BNull_IsFalse()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = null;

            bool rez = a.Equals(b);

            Assert.IsFalse(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        public void Equals_Self_IsTrue()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);

            bool rez = a.Equals(a);

            Assert.IsTrue(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        public void Equals_SameValue_IsTrue()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(33.9398772, -118.37977695);

            bool rez = a.Equals(b);

            Assert.IsTrue(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        public void Equals_DifferentValue_IsTrue()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(33.9398772, -112.37977695);

            bool rez = a.Equals(b);

            Assert.IsFalse(rez);
        }


        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void EqualsObject_ABEqual_IsTrue()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(33.9398772, -118.37977695);

            bool rez = a.Equals((object)b);

            Assert.IsTrue(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void EqualsObject_ABNotEqual_IsFalse()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = new LatLon(34.9398772, -118.37977695);

            bool rez = a.Equals((object)b);

            Assert.IsFalse(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void EqualsObject_BNull_IsFalse()
        {
            LatLon a = new LatLon(33.9398772, -118.37977695);
            LatLon b = null;

            bool rez = a.Equals((object)b);

            Assert.IsFalse(rez);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
        public void SetLatitude_OutOfRangeValueHigh_ThrowsArgumentOutOfRangeException()
        {
            new LatLon { Latitude = 999 };
        }
        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
        public void SetLatitude_OutOfRangeValueLow_ThrowsArgumentOutOfRangeException()
        {
            new LatLon { Latitude = -999 };
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
        public void SetLatitude_Valid_IsValid()
        {
            LatLon one = new LatLon { Latitude = 45 };

            Assert.AreEqual(45, one.Latitude, 1e-5);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
        public void SetLongitude_OutOfRangeValueHigh_ThrowsArgumentOutOfRangeException()
        {
            new LatLon { Longitude = 999 };
        }
        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
        public void SetLongitude_OutOfRangeValueLow_ThrowsArgumentOutOfRangeException()
        {
            new LatLon { Longitude = -999 };
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
        public void SetLongitude_Valid_IsValid()
        {
            LatLon one = new LatLon { Longitude = 45 };

            Assert.AreEqual(45, one.Longitude, 1e-5);
        }


        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
        public void GetHashCode_ABAreEqual_IsEqual()
        {
            LatLon one = new LatLon(1, 1);
            LatLon two = new LatLon(1, 1);

            Assert.AreEqual(one.GetHashCode(), two.GetHashCode());
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
        public void GetHashCode_ABAreDifferent_IsNotEqual()
        {
            LatLon one = new LatLon(1, 1);
            LatLon two = new LatLon(1, 2);

            Assert.AreNotEqual(one.GetHashCode(), two.GetHashCode());
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void ToString_ValidLLNW_IsCorrect()
        {
            LatLon ll = new LatLon(33.9398772, -118.37977695);

            string dms = ll.ToString();

            // Is the distance valid to within 1 degree?
            Assert.AreEqual("33°56'23.6\"N 118°22'47.2\"W", dms);
        }

        [TestMethod]
        [TestCategory("AirMapDotNet")]
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public void ToString_ValidLLSE_IsCorrect()
        {
            LatLon ll = new LatLon(-33.9398772, 118.37977695);

            string dms = ll.ToString();

            // Is the distance valid to within 1 degree?
            Assert.AreEqual("33°56'23.6\"S 118°22'47.2\"E", dms);
        }
    }
}