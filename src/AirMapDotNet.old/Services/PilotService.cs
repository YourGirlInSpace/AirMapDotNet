using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities;
using AirMapDotNet.Entities.AircraftAPI;
using AirMapDotNet.Entities.PilotAPI;

namespace AirMapDotNet.Services
{
    /// <summary>
    /// Exposes several methods for the Pilot API.
    /// </summary>
    internal class PilotService : AirMapService
    {
        internal PilotService(AirMap am)
            : base(am)
        { }

        /// <summary>
        /// Retrieves the profile for the currently authenticated user.
        /// </summary>
        /// <returns>A <see cref="PilotProfile"/> containing details on the currently authenticated user.</returns>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        internal async Task<PilotProfile> GetProfile()
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            Href<PilotProfile> profileLink =
                new Href<PilotProfile>(
                    new Uri(string.Format(AirMap_Pilot_ByID, AirMap.AuthenticationToken.User.UserID)));

            return await AirMap.GetAsync(profileLink);
        }

        /// <summary>
        /// Retrieves the profile of the user with ID <paramref name="uid"/>.
        /// </summary>
        /// <param name="uid">The unique ID of the user.</param>
        /// <returns>A <see cref="PilotProfile"/> containing publically-available details on the user.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="uid"/> is null or equals <see cref="string.Empty"/>.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal async Task<PilotProfile> GetProfile(string uid)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            if (string.IsNullOrEmpty(uid))
                throw new ArgumentNullException(nameof(uid));

            Href<PilotProfile> profileLink = new Href<PilotProfile>(new Uri(string.Format(AirMap_Pilot_ByID, uid)));

            return await AirMap.GetAsync(profileLink);
        }

        /// <summary>
        /// Updates a pilot's profile using the provided <see cref="UpdatePilotProfile"/>
        /// </summary>
        /// <param name="upp">The parameters to update.</param>
        /// <returns>The updated profile.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal async Task<UpdatePilotProfile> UpdateProfile(UpdatePilotProfile upp)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            Href<UpdatePilotProfile> profileLink = new Href<UpdatePilotProfile>(new Uri(string.Format(AirMap_Pilot_ByID, upp.ID)));

            return await AirMap.PatchAsync(profileLink, upp);
        }

        /// <summary>
        /// Sends a six digit token via SMS to the phone number attached to the pilot's profile.
        /// </summary>
        /// <param name="profile">The pilot's profile.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="profile"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal Task SendPhoneVerificationToken(PilotProfile profile)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            return SendPhoneVerificationToken(profile.ID);
        }

        /// <summary>
        /// Sends a six digit token via SMS to the phone number attached to the pilot's profile.
        /// </summary>
        /// <param name="uid">The user ID.</param>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal async Task SendPhoneVerificationToken(string uid)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            Href<EmptyEntity> verificationLink =
                new Href<EmptyEntity>(new Uri(string.Format(AirMap_Pilot_ByID_Phone_SendToken, uid)));

            await AirMap.PostAsync(verificationLink, new ExpandoObject());
        }

        /// <summary>
        /// Verifies the user's phone number through a six-digit token sent via SMS through <see cref="SendPhoneVerificationToken(AirMapDotNet.Entities.PilotAPI.PilotProfile)"/>.
        /// </summary>
        /// <param name="profile">The pilot's profile.</param>
        /// <param name="token">The token the user has entered.</param>
        /// <returns><c>True</c> if the token was validated.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="profile"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal Task<bool> VerifyPhoneToken(PilotProfile profile, int token)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            return VerifyPhoneToken(profile.ID, token);
        }

        /// <summary>
        /// Verifies the user's phone number through a six-digit token sent via SMS through <see cref="SendPhoneVerificationToken(string)"/>.
        /// </summary>
        /// <param name="uid">The pilot's profile ID.</param>
        /// <param name="token">The token the user has entered.</param>
        /// <returns><c>True</c> if the token was validated.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal async Task<bool> VerifyPhoneToken(string uid, int token)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            Href<VerificationStatus> verificationLink =
                new Href<VerificationStatus>(new Uri(string.Format(AirMap_Pilot_ByID_Phone_VerifyToken, uid)));

            dynamic postObject = new ExpandoObject();
            postObject.token = token;

            VerificationStatus status = await AirMap.PostAsync(verificationLink, postObject);

            return status.Verified;
        }

        /// <summary>
        /// Gets a list of all aircraft currently attributed to the pilot.
        /// </summary>
        /// <returns>A list of all aircraft currently attributed to the pilot.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        internal async Task<IEnumerable<Aircraft>> GetPilotAircraft()
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            Href<EntityCollection<Aircraft>> getPilotAircraftLink =
                new Href<EntityCollection<Aircraft>>(
                    new Uri(string.Format(AirMap_Pilot_ByID_Aircraft, AirMap.AuthenticationToken.User.UserID)));

            EntityCollection<Aircraft> aircraft = await AirMap.GetAsync(getPilotAircraftLink);

            return aircraft;
        }

        /// <summary>
        /// Adds an aircraft to the pilot's profile.
        /// </summary>
        /// <param name="model">The aircraft's model from <see cref="AirMap.GetModels(string,string)"/>.</param>
        /// <param name="nickname">The aircraft's nickname.</param>
        /// <returns>The new aircraft.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="model"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal Task<Aircraft> AddPilotAircraft(Model model, string nickname)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            if (model == null)
                throw new ArgumentNullException(nameof(model));

            return AddPilotAircraft(model.ID, nickname);
        }

        /// <summary>
        /// Adds an aircraft to the pilot's profile.
        /// </summary>
        /// <param name="model">The aircraft's model ID from <see cref="AirMap.GetModels(string,string)"/>.</param>
        /// <param name="nickname">The aircraft's nickname.</param>
        /// <returns>The new aircraft.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal async Task<Aircraft> AddPilotAircraft(string model, string nickname)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            Href<Aircraft> addPilotAircraftLink =
                new Href<Aircraft>(
                    new Uri(string.Format(AirMap_Pilot_ByID_Aircraft, AirMap.AuthenticationToken.User.UserID)));

            dynamic postObject = new ExpandoObject();
            postObject.model_id = model;
            postObject.nickname = nickname;

            return await AirMap.PostAsync(addPilotAircraftLink, postObject);
        }

        /// <summary>
        /// Adds an aircraft to the pilot's profile.
        /// </summary>
        /// <param name="aircraft">The aircraft instance.</param>
        /// <param name="nickname">The aircraft's new nickname.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="aircraft"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal Task UpdatePilotAircraft(Aircraft aircraft, string nickname)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            if (aircraft == null)
                throw new ArgumentNullException(nameof(aircraft));

            return UpdatePilotAircraft(aircraft.ID, nickname);
        }

        /// <summary>
        /// Adds an aircraft to the pilot's profile.
        /// </summary>
        /// <param name="aircraftId">The aircraft's ID.</param>
        /// <param name="nickname">The aircraft's new nickname.</param>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal async Task UpdatePilotAircraft(string aircraftId, string nickname)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            Href<EmptyEntity> pilotAircraftLink =
                new Href<EmptyEntity>(
                    new Uri(
                        string.Format(AirMap_Pilot_ByID_Aircraft_ByID, AirMap.AuthenticationToken.User.UserID, aircraftId)));

            dynamic patchObject = new ExpandoObject();
            patchObject.nickname = nickname;

            await AirMap.PatchAsync(pilotAircraftLink, patchObject);
        }

        /// <summary>
        /// Deletes an aircraft from the pilot's profile.
        /// </summary>
        /// <param name="aircraft">The aircraft instance.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="aircraft"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal Task DeletePilotAircraft(Aircraft aircraft)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            if (aircraft == null)
                throw new ArgumentNullException(nameof(aircraft));

            return DeletePilotAircraft(aircraft.ID);
        }

        /// <summary>
        /// Deletes an aircraft from the pilot's profile.
        /// </summary>
        /// <param name="aircraftId">The aircraft's ID.</param>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        internal async Task DeletePilotAircraft(string aircraftId)
        {
            if (AirMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!AirMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            Href pilotAircraftLink =
                new Href(
                    new Uri(
                        string.Format(AirMap_Pilot_ByID_Aircraft_ByID, AirMap.AuthenticationToken.User.UserID, aircraftId)));

            await AirMap.DeleteAsync(pilotAircraftLink);
        }
    }
}