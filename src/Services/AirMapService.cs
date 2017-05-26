namespace AirMapDotNet.Services
{
    /// <summary>
    /// Represents a service exposing methods for the AirMap API.
    /// </summary>
    internal class AirMapService : IAirMapService
    {
#if DEBUG
        protected const bool DEBUG = true;
#else
        protected const bool DEBUG = false;
#endif

        #region SDK URLs
        /// <summary>
        /// Base URL for the AirMap API.
        /// </summary>
        protected const string AirMap_BaseURL = "https://api.airmap.com/";

        #region Aircraft SDK
        /// <summary>
        /// Aircraft SDK version.
        /// </summary>
        protected const string AirMap_Aircraft_Version = "v2/";
        /// <summary>
        /// Base URL for the Aircraft SDK.
        /// </summary>
        protected const string AirMap_Aircraft_BaseURL = AirMap_BaseURL + "aircraft/" + AirMap_Aircraft_Version;
        /// <summary>
        /// Resource location for all known aircraft manufacturers.
        /// </summary>
        protected const string AirMap_Aircraft_Manufacturers = AirMap_Aircraft_BaseURL + "manufacturer/";
        /// <summary>
        /// Resource location for all known aircraft models.
        /// </summary>
        protected const string AirMap_Aircraft_Models = AirMap_Aircraft_BaseURL + "model/";
        /// <summary>
        /// Resource location for a specific aircraft model.  {0} = Model UID
        /// </summary>
        protected const string AirMap_Aircraft_Model = AirMap_Aircraft_Models + "{0}/";
        #endregion

        #region Flight SDK
        /// <summary>
        /// Flight SDK version.
        /// </summary>
        protected const string AirMap_Flight_Version = "v2/";
        /// <summary>
        /// Base URL for the Flight SDK.
        /// </summary>
        protected const string AirMap_Flight_BaseURL = AirMap_BaseURL + "flight/" + AirMap_Flight_Version;
        /// <summary>
        /// Resource location for all flight activity.
        /// </summary>
        protected const string AirMap_Flight_All = AirMap_Flight_BaseURL;
        /// <summary>
        /// Resource location for all flight activity by point.
        /// </summary>
        protected const string AirMap_Flight_Point = AirMap_Flight_BaseURL + "point/";
        /// <summary>
        /// Resource location for all flight activity by path.
        /// </summary>
        protected const string AirMap_Flight_Path = AirMap_Flight_BaseURL + "path/";
        /// <summary>
        /// Resource location for all flight activity by polygon.
        /// </summary>
        protected const string AirMap_Flight_Polygon = AirMap_Flight_BaseURL + "polygon/";
        /// <summary>
        /// Resource location for a particular flight.  {0} = Flight ID.
        /// </summary>
        protected const string AirMap_Flight_ByID = AirMap_Flight_BaseURL + "{0}/";
        /// <summary>
        /// Resource location to delete a particular flight.  {0} = Flight ID.
        /// </summary>
        protected const string AirMap_Flight_DeleteByID = AirMap_Flight_ByID + "delete/";
        /// <summary>
        /// Resource location to end a particular flight.  {0} = Flight ID.
        /// </summary>
        protected const string AirMap_Flight_EndByID = AirMap_Flight_ByID + "end/";
        protected const string AirMap_Flight_StartCommByID = AirMap_Flight_ByID + "start-comm/";
        protected const string AirMap_Flight_EndCommByID = AirMap_Flight_ByID + "end-comm/";
        #endregion

        #region Pilot SDK
        /// <summary>
        /// Pilot SDK Version.
        /// </summary>
        protected const string AirMap_Pilot_Version = "v2/";
        /// <summary>
        /// Base URL for the Pilot SDK.
        /// </summary>
        protected const string AirMap_Pilot_BaseURL = AirMap_BaseURL + "pilot/" + AirMap_Pilot_Version;
        /// <summary>
        /// Resource location for a particular pilot.  {0} = Pilot ID.
        /// </summary>
        protected const string AirMap_Pilot_ByID = AirMap_Pilot_BaseURL + "{0}";
        /// <summary>
        /// Resource location for all aircraft owned by a particular pilot.  {0} = Pilot ID.
        /// </summary>
        protected const string AirMap_Pilot_ByID_Aircraft = AirMap_Pilot_ByID + "/aircraft";
        /// <summary>
        /// Resource location for a particular aircraft owned by a particular pilot.  {0} = Pilot ID.  {1} = Aircraft ID.
        /// </summary>
        protected const string AirMap_Pilot_ByID_Aircraft_ByID = AirMap_Pilot_ByID_Aircraft + "/{1}/";
        /// <summary>
        /// Base URL for phone operations for a particular pilot.  {0} = Pilot ID.
        /// </summary>
        protected const string AirMap_Pilot_ByID_Phone = AirMap_Pilot_ByID + "/phone";
        /// <summary>
        /// Resource location to send a verification token to a particular pilot's phone.  {0} = Pilot ID.
        /// </summary>
        protected const string AirMap_Pilot_ByID_Phone_SendToken = AirMap_Pilot_ByID_Phone + "/send_token";
        /// <summary>
        /// Resource location to verify a token previously sent to a particular pilot's phone.  {0} = Pilot ID.
        /// </summary>
        protected const string AirMap_Pilot_ByID_Phone_VerifyToken = AirMap_Pilot_ByID_Phone + "/verify_token";
        #endregion

        #region Status SDK
        /// <summary>
        /// Status SDK version.
        /// </summary>
        protected const string AirMap_Status_Version = "v2/";
        /// <summary>
        /// Base URL for the Status SDK.
        /// </summary>
        protected const string AirMap_Status_BaseURL = AirMap_BaseURL + "status/" + AirMap_Status_Version;
        /// <summary>
        /// Resource location for status information by a point.
        /// </summary>
        protected const string AirMap_Status_ByPoint = AirMap_Status_BaseURL + "point/";
        /// <summary>
        /// Resource location for status information by a path.
        /// </summary>
        protected const string AirMap_Status_ByPath = AirMap_Status_BaseURL + "path/";
        /// <summary>
        /// Resource location for status information by a polygon.
        /// </summary>
        protected const string AirMap_Status_ByPolygon = AirMap_Status_BaseURL + "polygon/";
        #endregion

        #region Airspace SDK
        /// <summary>
        /// Airspace SDK version.
        /// </summary>
        protected const string AirMap_Airspace_Version = "v2/";
        /// <summary>
        /// Base URL for the Airspace SDK.
        /// </summary>
        protected const string AirMap_Airspace_BaseURL = AirMap_BaseURL + "airspace/" + AirMap_Airspace_Version;
        /// <summary>
        /// Resource location for a particular airspace object.
        /// </summary>
        protected const string AirMap_Airspace_ByID = AirMap_Airspace_BaseURL + "{0}/";
        /// <summary>
        /// Resource location for airspace objects.
        /// </summary>
        protected const string AirMap_Airspace_ByIDs = AirMap_Airspace_BaseURL + "list/";

        #endregion

        #region Traffic SDK
        /// <summary>
        /// Traffic Alert SDK base MQTT URL.
        /// </summary>
        protected const string AirMap_Traffic_MQTTBaseUrl = "ssl://mqtt-prod.airmap.io:8883";
        /// <summary>
        /// Alert channel for a particular flight.  {0} = Flight ID.
        /// </summary>
        protected const string AirMap_Traffic_AlertChannel = "uav/traffic/alert/{0}";
        /// <summary>
        /// Situational awareness channel for a particular flight.  {0} = Flight ID.
        /// </summary>
        protected const string AirMap_Traffic_SituationalAwarenessChannel = "uav/traffic/sa/{0}";
        #endregion

        #region Telemetry SDK
        /// <summary>
        /// Address to the Telemetry SDK server.
        /// </summary>
        protected const string AirMap_Telemetry_BaseURL = "api-udp-telemetry.prod.airmap.com";
        /// <summary>
        /// Telemetry server UDP port.
        /// </summary>
        protected const int AirMap_Telemetry_Port = 16060;
        #endregion
        #endregion

        /// <summary>
        /// The current AirMap instance.
        /// </summary>
        public AirMap AirMap { get; protected set; }

        internal AirMapService(AirMap am)
        {
            AirMap = am;
        }
    }
}