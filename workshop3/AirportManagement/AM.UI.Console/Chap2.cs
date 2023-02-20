using AM.ApplicationCore;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Console
{
    public static class Chap2
    {
        public static ShowLine showLine = System.Console.WriteLine;

        public static void Test1()
        {
            FlightService flightService = new FlightService(InMemorySource.Flights,showLine);
            flightService.ShowFlights("Destination", "Paris");
            flightService.ShowFlights("Destination", "Madrid");
            flightService.ShowFlights("FlightId", "3");


        }

            
    }
    
}
