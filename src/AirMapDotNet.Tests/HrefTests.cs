using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirMapDotNet;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirMapDotNet.Tests
{
    [TestClass]
    public class HrefTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "No ANE thrown!")]
        public void CompileTest_NVCNull()
        {
            Href google = new Href(new Uri("http://google.com"));
            
            Uri comp = google.Compile(null);
        }

        [TestMethod]
        public void CompileTest_ValidArgs()
        {
            Href google = new Href(new Uri("http://google.com"));

            Dictionary<string, string> nvc = new Dictionary<string, string>
            {
                ["q"] = "test"
            };

            Uri comp = google.Compile(nvc);

            Assert.AreEqual("http://google.com/?q=test", comp.ToString(), "URL invalid.");
        }
    }
}