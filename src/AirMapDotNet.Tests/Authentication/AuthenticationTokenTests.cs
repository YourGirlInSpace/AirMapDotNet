using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirMapDotNet.Authentication;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirMapDotNet.Authentication.Tests
{
    [TestClass()]
    public class AuthenticationTokenTests
    {
        private const string ISS = "https://sso.airmap.io";
        private const string SUB = "auth0|58c...a5c";
        private const string AUD = "OPy...XxF";
        private static readonly DateTime EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private static string ConstructJWT(DateTime time, TimeSpan expires)
        {
            // ========= HEADER =========
            string header = "{\"typ\":\"JWT\",\"alg\":\"HS256\"}";

            string header_b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(header), Base64FormattingOptions.None)
                .Replace("=", "");

            // ========= PAYLOAD =========
            string payload = "{";
            payload += $"\"iss\": \"{ISS}\",";
            payload += $"\"sub\": \"{SUB}\",";
            payload += $"\"aud\": \"{AUD}\",";

            int iat_sec = (int)(time - EPOCH).TotalSeconds;
            int exp_sec = (int)(time + expires - EPOCH).TotalSeconds;

            payload += $"\"exp\": {exp_sec},";
            payload += $"\"iat\": {iat_sec}";
            payload += "}";

            string payload_b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(payload), Base64FormattingOptions.None)
                .Replace("=", "");

            // ========= SIGNATURE =========
            string signature_b64 = "jcLrbJHZHeyvIJGvRMdKD9Nz4yzRAUzQVmi98JwOUSM"; // WILL NOT VALIDATE

            return $"{header_b64}.{payload_b64}.{signature_b64}";
        }

        [TestMethod]
        public void AuthenticationTokenTest_ValidInDate()
        {
            DateTime issuedTime = DateTime.UtcNow - TimeSpan.FromMinutes(1);

            string jwt_valid = ConstructJWT(issuedTime, TimeSpan.FromHours(4));

            AuthenticationToken at = new AuthenticationToken(jwt_valid);

            Assert.AreEqual(jwt_valid, at.Token);
            Assert.AreEqual(SUB, at.Subject);
            Assert.AreEqual(AUD, at.Audience);
            Assert.AreEqual(ISS, at.Issuer);
            // To avoid problems with milliseconds
            Assert.AreEqual((int)(issuedTime - EPOCH).TotalSeconds, (int)(at.IssuedAt - EPOCH).TotalSeconds);
            Assert.IsTrue(at.IsValid);
        }

        [TestMethod]
        public void AuthenticationTokenTest_ValidOutOfDate()
        {
            DateTime issuedTime = DateTime.UtcNow - TimeSpan.FromDays(2);

            string jwt_valid = ConstructJWT(issuedTime, TimeSpan.FromHours(4));

            AuthenticationToken at = new AuthenticationToken(jwt_valid);

            Assert.AreEqual(jwt_valid, at.Token);
            Assert.AreEqual(SUB, at.Subject);
            Assert.AreEqual(AUD, at.Audience);
            Assert.AreEqual(ISS, at.Issuer);
            // To avoid problems with milliseconds
            Assert.AreEqual((int)(issuedTime - EPOCH).TotalSeconds, (int)(at.IssuedAt - EPOCH).TotalSeconds);
            Assert.IsFalse(at.IsValid);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AuthenticationTokenTest_Null()
        {
            AuthenticationToken at = new AuthenticationToken(null);
        }

        [TestMethod]
        [ExpectedException(typeof(AuthenticationException))]
        public void AuthenticationTokenTest_Invalid()
        {
            AuthenticationToken at = new AuthenticationToken("totallyaJWTtokenyo");
        }
    }
}