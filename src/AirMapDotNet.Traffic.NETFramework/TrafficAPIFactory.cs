using System;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities.FlightAPI;

namespace AirMapDotNet.Traffic
{
    public class TrafficAPIFactory
    {
        /// <summary>
        /// Connects to the AirMap traffic service.
        /// </summary>
        /// <param name="airMap">The current AirMap instance.</param>
        /// <param name="flightId">The flight ID to listen to.</param>
        /// <returns><c>True</c> if the connection was successful, otherwise <c>false</c>.</returns>
        /// <exception cref="AuthenticationException">If the <see cref="AuthenticationToken"/> is not set, or has expired, or the token is not valid for this resource.</exception>
        public static TrafficAPI Create(AirMap airMap, string flightId)
        {
            if (airMap.AuthenticationToken == null)
                throw new AuthenticationException("Authentication token not set.");
            if (!airMap.AuthenticationToken.IsValid)
                throw new AuthenticationException("Authentication token has expired.");

            MqttClient client = new MqttClient(airMap, flightId);

            TrafficAPI tfa = new TrafficAPI(client, flightId);

            return tfa;
        }

        /// <summary>
        /// Connects to the traffic service for traffic alerts for the <paramref name="flight"/>.
        /// </summary>
        /// <param name="airMap">The current AirMap instance.</param>
        /// <param name="flight">The flight to subscribe to.</param>
        /// <returns><c>True</c> if the subscription was successful, otherwise <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="flight"/> is null.</exception>
        public static TrafficAPI Create(AirMap airMap, Flight flight)
        {
            if (flight == null)
                throw new ArgumentNullException(nameof(flight));

            return Create(airMap, flight.ID);
        }
    }
}