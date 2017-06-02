using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AirMapDotNet.Tests
{
    [TestClass]
    public class AirMapExceptionTest
    {
        [TestMethod]
        [TestCategory("AirMapDotNet")]
        public void ConstructorTests()
        {
            string testMessage = @"TEST MESSAGE";
            JSendStatus testStatus = JSendStatus.Success;
            Exception testException = new Exception("This is a test exception.");

            var airMapException = new AirMapException();

            Assert.IsNotNull(airMapException);

            airMapException = new AirMapException(testMessage);

            Assert.IsNotNull(airMapException);
            Assert.AreEqual(airMapException.Message, testMessage, "Messages are not equal.");

            airMapException = new AirMapException(testStatus);

            Assert.IsNotNull(airMapException);
            Assert.AreEqual(airMapException.Status, testStatus, "Statuses are not equal.");

            airMapException = new AirMapException(testMessage, testStatus);

            Assert.IsNotNull(airMapException);
            Assert.AreEqual(airMapException.Message, testMessage, "Messages are not equal.");
            Assert.AreEqual(airMapException.Status, testStatus, "Statuses are not equal.");


            airMapException = new AirMapException(testMessage, testException);

            Assert.IsNotNull(airMapException);
            Assert.AreEqual(airMapException.Message, testMessage, "Messages are not equal.");
            Assert.AreEqual(airMapException.InnerException, testException, "Inner exception is not equal.");


            airMapException = new AirMapException(testMessage, testStatus, testException);

            Assert.IsNotNull(airMapException);
            Assert.AreEqual(airMapException.Message, testMessage, "Messages are not equal.");
            Assert.AreEqual(airMapException.InnerException, testException, "Inner exception is not equal.");
            Assert.AreEqual(airMapException.Status, testStatus, "Statuses are not equal.");


            IFormatter formatter = new BinaryFormatter();
            using (Stream s = new MemoryStream())
            {
                formatter.Serialize(s, airMapException);

                s.Seek(0, SeekOrigin.Begin);
                Debug.Assert(s.Length > 0);
                
                airMapException = (AirMapException) formatter.Deserialize(s);
                
                Assert.IsNotNull(airMapException);
                Assert.AreEqual(airMapException.Message, testMessage, "Messages are not equal.");
                // These won't be *exactly* the same due to serialization,
                // but at least the data contained within them should be.
                Assert.AreEqual(airMapException.InnerException?.Message, testException.Message);
                Assert.AreEqual(airMapException.Status, testStatus, "Statuses are not equal.");
            }
        }
    }
}
