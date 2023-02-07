using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightService: IFlightService
    {

        ICollection s;

     public FlightService (ICollection source) {
            s = source;
                }

        public void ShowFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach(Flight flight in s)
                    {
                        if (flight.Destination == filterValue) {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "FlightDate":
                    DateTime d = DateTime.Parse(filterValue);
                    foreach (Flight flight in s)
                    {
                   
                        if (flight.FlightDate ==d)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "FlightId":

                    int id = Int32.Parse(filterValue);

                    foreach (Flight flight in s)
                    {

                        if (flight.FlightId == id)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                default:

                    throw new ArgumentException("unkown");
            }


           
           
        }
    }
}
