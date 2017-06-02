using System;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.PilotAPI
{
    /// <summary>
    /// An entity required for updating a user's profile.
    /// </summary>
    public class UpdatePilotProfile : AirMapEntity
    {
        /// <summary>
        /// Creates a new <see cref="UpdatePilotProfile"/> instance from a <see cref="PilotProfile"/>.
        /// </summary>
        /// <param name="profile">The profile to use to create the <see cref="UpdatePilotProfile"/>.</param>
        /// <returns>A <see cref="UpdatePilotProfile"/> instance for the <see cref="PilotProfile"/> <paramref name="profile"/>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="profile"/> is null.</exception>
        public static UpdatePilotProfile FromPilotProfile(PilotProfile profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            return new UpdatePilotProfile(profile.ID);
        }

        private UpdatePilotProfile() {  }

        private UpdatePilotProfile(string profileId)
        {
            ID = profileId;
        }

        /// <summary>
        /// The user ID to update.
        /// </summary>
        [JsonIgnore]
        public string ID { get; }

        /// <summary>
        /// The new username for the pilot.
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// The pilot's new first name.
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }
        
        /// <summary>
        /// The pilot's new last name.
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }
        
        /// <summary>
        /// The pilot's new phone number.  This will set the phone number validation state to <c>false</c>.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// An object store for custom user metadata scoped to the application.
        /// </summary>
        [JsonProperty("app_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public object AppMetadata { get; set; }

        /// <summary>
        /// User preferences
        /// </summary>
        [JsonProperty("user_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public object UserMetadata { get; set; }
    }
}