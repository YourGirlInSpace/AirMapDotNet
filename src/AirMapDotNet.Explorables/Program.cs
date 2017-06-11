using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using AirMapDotNet.Authentication;
using AirMapDotNet.Entities.PilotAPI;
using AirMapDotNet.Entities.AircraftAPI;
using System.Collections.Generic;
using AirMapDotNet.Entities.FlightAPI;
using AirMapDotNet.Traffic;

namespace AirMapDotNet.Explorables
{
    [SuppressMessage("ReSharper", "UnusedParameter.Local")]
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task task = Task.Run(async () => await MainAsync(args));
            task.ConfigureAwait(false);

            try
            {
                task.Wait();
            } catch (AggregateException ae)
            {
                if (ae.InnerException != null)
                    throw ae.InnerException;
            }
        }
        
        private static async Task MainAsync(string[] args)
        {
            try
            {
                APIConfiguration config = await APIConfiguration.LoadFromFileAsync("airmap.config.json");

                AirMap airMap = new AirMap(config);
                
                airMap.AuthenticationToken = await AuthenticationService.LoginAsync(airMap, DebugData.username, DebugData.password);
                
                /*PilotProfile profile = await airMap.GetProfile();
                var ac = await airMap.GetPilotAircraft();
                
                FlightCreationParameters fcp = new FlightCreationParameters
                {
                    AircraftID = ac.First().ID,
                    Buffer = 100,
                    StartTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow + TimeSpan.FromHours(4),
                    Geometry = GeoUtilities.CreateCircle(new LatLon(26.958075, -80.787470), 100),
                    IsPublic = false,
                    Latitude = 26.958075,
                    Longitude = -80.787470,
                    MaxAltitude = 1,
                    Notify = false
                };

                var flt = await airMap.CreateFlight(fcp);*/

                string flightID = "flight|eedovmDCY48yEZtlXPdJwfeayNK5";

                TrafficAPI traf = TrafficAPIFactory.Create(airMap, flightID);
                bool ok = await traf.Connect();
            }
            catch (AirMapException ex)
            {
                Console.WriteLine(@"ERROR: " + ex.Message);
            }
        }
    }
}
