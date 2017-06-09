using AirMapDotNet.Requestors;

namespace AirMapDotNet
{
    public class AirMapFactory
    {
        public static AirMap Create(APIConfiguration config)
        {
            AirMap am = new AirMap(config)
            {
                Requestor = new HTTPRequestor()
            };

            return am;
        }
    }
}