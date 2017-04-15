using System;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.PilotAPI
{
    /// <summary>
    /// Describes a pilot's profile.
    /// </summary>
    public class PilotProfile : AirMapEntity
    {
        /// <summary>
        /// The pilot's unique ID.
        /// </summary>
        [JsonProperty("id", Required = Required.Always)]
        public virtual string ID { get; set; }

        /// <summary>
        /// The pilot's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; }

        /// <summary>
        /// The pilot's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public virtual string LastName { get; set; }

        /// <summary>
        /// The pilot's profile picture URL.
        /// </summary>
        [JsonProperty("picture_url")]
        public virtual Uri PictureURL { get; set; }

        /// <summary>
        /// The pilot's username.
        /// </summary>
        [JsonProperty("username")]
        public virtual string UserName { get; set; }
    }
}