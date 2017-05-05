using System;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.PilotAPI
{
    /// <summary>
    /// Describes a pilot's profile.
    /// </summary>
    public sealed class PilotProfile : AirMapEntity
    {
        /// <summary>
        /// The pilot's unique ID.
        /// </summary>
        [JsonProperty("id", Required = Required.Always)]
        public string ID { get; internal set; }

        /// <summary>
        /// The pilot's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; internal set; }

        /// <summary>
        /// The pilot's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; internal set; }

        /// <summary>
        /// The pilot's profile picture URL.
        /// </summary>
        [JsonProperty("picture_url")]
        public Uri PictureURL { get; internal set; }

        /// <summary>
        /// The pilot's username.
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; internal set; }

        /// <summary>
        /// The pilot's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; internal set; }

        /// <summary>
        /// The user metadata object.
        /// </summary>
        /// <remarks>To utilize this object, use a JSON class representation and cast this object to that.</remarks>
        [JsonProperty("user_metadata")]
        public object UserMetadata { get; internal set; }

        /// <summary>
        /// The application metadata object.
        /// </summary>
        /// <remarks>To utilize this object, use a JSON class representation and cast this object to that.</remarks>
        [JsonProperty("app_metadata")]
        public object AppMetadata { get; internal set; }
        
        [JsonProperty("verification_status")]
        internal VerificationStatus verificationStatus { get; set; }

        /// <summary>
        /// <c>True</c> if the user has verified his phone number.
        /// </summary>
        [JsonIgnore]
        public bool PhoneVerified => verificationStatus.PhoneVerified;

        /// <summary>
        /// <c>True</c> if the user has verified his email.
        /// </summary>
        [JsonIgnore]
        public bool EmailVerified => verificationStatus.EmailVerified;

        /// <summary>
        /// Optional statistics object containing general statistics on a pilot's activities.
        /// </summary>
        [JsonProperty("statistics")]
        public Statistics Statistics { get; internal set; }

        // Quick and dirty class to accomplish this without a JsonConverter.
        internal class VerificationStatus
        {
            [JsonProperty("phone")]
            public bool PhoneVerified { get; internal set; }

            [JsonProperty("email")]
            public bool EmailVerified { get; internal set; }
        }
    }
}