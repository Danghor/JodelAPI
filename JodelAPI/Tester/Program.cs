﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JodelAPI;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            API.AccessToken = "f863e61d-3548-4d6d-bba7-15253bdc23f6";
            API.Latitude = "47.4635820";
            API.Longitude = "8.3294740";
            API.City = "Wettingen";
            API.CountryCode = "CH";

            var list = API.GetModerationQueue();
            Console.WriteLine(list[0].Message);
            API.FlagJodel(list[0].TaskId, API.Decision.Allow);
            Console.Read();
        }
    }
}