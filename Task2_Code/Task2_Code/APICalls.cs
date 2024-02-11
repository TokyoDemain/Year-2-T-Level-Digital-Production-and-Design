using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Code
{

    public class Product
    {
        string postHistoricalURL = "https://api.ambeedata.com/latest/by-lat-lng?lat=12&lng=77";

        string apiKey = "e3a8191796554c4cea605527f7028b43d5f788ba5cdd34b494b1c5771117d7a7";

        public List<string> fields = new List<string>()
        {
            "totalPrecipitationAccumulationMax",
            "windSpeedMax",
            "windDirectionAvg",
            "windGustMax",
            "snowAccumulationMax"
        };

        string units = "imperial";

        string timesteps = "1d";

        string now = DateTime.Now.ToLongDateString();

        string timezone = "US/Eastern";

        public Dictionary<string, string> body = new Dictionary<string, string>();

        

    }

    internal class APICalls
    {
    }
}
