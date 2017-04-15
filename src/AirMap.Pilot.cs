using System;
using System.Threading.Tasks;
using AirMapDotNet.Entities.PilotAPI;
using AirMapDotNet.Authentication;

namespace AirMapDotNet
{
    public partial class AirMap
    {
        /// <summary>
        /// Retrieves the profile for the currently authenticated user.
        /// </summary>
        /// <returns>A <see cref="PilotProfile"/> containing details on the currently authenticated user.</returns>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public async Task<PilotProfile> GetProfile()
        {
            if (AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            Href<PilotProfile> profileLink =
                new Href<PilotProfile>(new Uri($"https://api.airmap.com/pilot/v2/{AuthenticationToken.Subject}"));

            return await GetAsync(profileLink);
        }

        /// <summary>
        /// Retrieves the profile of the user with ID <paramref name="uid"/>.
        /// </summary>
        /// <param name="uid">The unique ID of the user.</param>
        /// <returns>A <see cref="PilotProfile"/> containing publically-available details on the user.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="uid"/> is null or equals <see cref="string.Empty"/>.</exception>
        public async Task<PilotProfile> GetProfile(string uid)
        {
            if (string.IsNullOrEmpty(uid))
                throw new ArgumentNullException(nameof(uid));

            Href<PilotProfile> profileLink = new Href<PilotProfile>(new Uri($"https://api.airmap.com/pilot/v2/{uid}"));

            return await GetAsync(profileLink);
        }
    }
}
