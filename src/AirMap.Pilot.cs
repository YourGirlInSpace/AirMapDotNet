using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AirMapDotNet.Entities.PilotAPI;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities.AircraftAPI;
using AirMapDotNet.Services;

namespace AirMapDotNet
{
    public partial class AirMap
    {
        private readonly PilotService _pilotService;

        /// <summary>
        /// Retrieves the profile for the currently authenticated user.
        /// </summary>
        /// <returns>A <see cref="PilotProfile"/> containing details on the currently authenticated user.</returns>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<PilotProfile> GetProfile()
            => _pilotService.GetProfile();

        /// <summary>
        /// Retrieves the profile of the user with ID <paramref name="uid"/>.
        /// </summary>
        /// <param name="uid">The unique ID of the user.</param>
        /// <returns>A <see cref="PilotProfile"/> containing publically-available details on the user.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="uid"/> is null or equals <see cref="string.Empty"/>.</exception>
        public Task<PilotProfile> GetProfile(string uid)
            => _pilotService.GetProfile(uid);

        /// <summary>
        /// Updates a pilot's profile using the provided <see cref="UpdatePilotProfile"/>
        /// </summary>
        /// <param name="upp">The parameters to update.</param>
        /// <returns>The updated profile.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<UpdatePilotProfile> UpdateProfile(UpdatePilotProfile upp)
            => _pilotService.UpdateProfile(upp);

        /// <summary>
        /// Sends a six digit token via SMS to the phone number attached to the pilot's profile.
        /// </summary>
        /// <param name="profile">The pilot's profile.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="profile"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task SendPhoneVerificationToken(PilotProfile profile)
            => _pilotService.SendPhoneVerificationToken(profile);

        /// <summary>
        /// Sends a six digit token via SMS to the phone number attached to the pilot's profile.
        /// </summary>
        /// <param name="uid">The user ID.</param>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task SendPhoneVerificationToken(string uid)
            => _pilotService.SendPhoneVerificationToken(uid);

        /// <summary>
        /// Verifies the user's phone number through a six-digit token sent via SMS through <see cref="SendPhoneVerificationToken(AirMapDotNet.Entities.PilotAPI.PilotProfile)"/>.
        /// </summary>
        /// <param name="profile">The pilot's profile.</param>
        /// <param name="token">The token the user has entered.</param>
        /// <returns><c>True</c> if the token was validated.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="profile"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<bool> VerifyPhoneToken(PilotProfile profile, int token)
            => _pilotService.VerifyPhoneToken(profile, token);

        /// <summary>
        /// Verifies the user's phone number through a six-digit token sent via SMS through <see cref="SendPhoneVerificationToken(string)"/>.
        /// </summary>
        /// <param name="uid">The pilot's profile ID.</param>
        /// <param name="token">The token the user has entered.</param>
        /// <returns><c>True</c> if the token was validated.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<bool> VerifyPhoneToken(string uid, int token)
            => _pilotService.VerifyPhoneToken(uid, token);

        /// <summary>
        /// Gets a list of all aircraft currently attributed to the pilot.
        /// </summary>
        /// <returns>A list of all aircraft currently attributed to the pilot.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public Task<IEnumerable<Aircraft>> GetPilotAircraft()
            => _pilotService.GetPilotAircraft();

        /// <summary>
        /// Adds an aircraft to the pilot's profile.
        /// </summary>
        /// <param name="model">The aircraft's model from <see cref="GetModels(string,string)"/>.</param>
        /// <param name="nickname">The aircraft's nickname.</param>
        /// <returns>The new aircraft.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="model"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<Aircraft> AddPilotAircraft(Model model, string nickname)
            => _pilotService.AddPilotAircraft(model, nickname);

        /// <summary>
        /// Adds an aircraft to the pilot's profile.
        /// </summary>
        /// <param name="model">The aircraft's model ID from <see cref="GetModels(string,string)"/>.</param>
        /// <param name="nickname">The aircraft's nickname.</param>
        /// <returns>The new aircraft.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task<Aircraft> AddPilotAircraft(string model, string nickname)
            => _pilotService.AddPilotAircraft(model, nickname);

        /// <summary>
        /// Adds an aircraft to the pilot's profile.
        /// </summary>
        /// <param name="aircraft">The aircraft instance.</param>
        /// <param name="nickname">The aircraft's new nickname.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="aircraft"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task UpdatePilotAircraft(Aircraft aircraft, string nickname)
            => _pilotService.UpdatePilotAircraft(aircraft, nickname);

        /// <summary>
        /// Adds an aircraft to the pilot's profile.
        /// </summary>
        /// <param name="aircraftId">The aircraft's ID.</param>
        /// <param name="nickname">The aircraft's new nickname.</param>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task UpdatePilotAircraft(string aircraftId, string nickname)
            => _pilotService.UpdatePilotAircraft(aircraftId, nickname);

        /// <summary>
        /// Deletes an aircraft from the pilot's profile.
        /// </summary>
        /// <param name="aircraft">The aircraft instance.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="aircraft"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task DeletePilotAircraft(Aircraft aircraft)
            => _pilotService.DeletePilotAircraft(aircraft);

        /// <summary>
        /// Deletes an aircraft from the pilot's profile.
        /// </summary>
        /// <param name="aircraftId">The aircraft's ID.</param>
        /// <exception cref="AirMapException">If the request fails.</exception>
        public Task DeletePilotAircraft(string aircraftId)
            => _pilotService.DeletePilotAircraft(aircraftId);
    }
}
