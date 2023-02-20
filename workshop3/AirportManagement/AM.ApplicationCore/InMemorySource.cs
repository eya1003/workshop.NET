using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public static class InMemorySource
    {
        public static Plane Boeing1 { get; set; }
        public static readonly Plane Boeing2 = new Plane(150, new DateTime(2015, 2, 3), PlaneType.Boeing)
        {
            PlaneId = 2,
            Flights = new List<Flight>() { flight3, flight4 }
        };
        public static readonly Plane Airbus = new Plane
        {
            PlaneId = 3,
            PlaneType = PlaneType.Airbus,
            Capacity = 250,
            ManufactureDate = new DateTime(2020, 11, 11),
            Flights = new List<Flight> { flight5, flight6 }
        };
      
        static Plane GetFirstPlane()
        {
            Plane plane = new Plane();
            plane.PlaneId = 1;
            plane.PlaneType = PlaneType.Boeing;
            plane.Capacity = 200;
            plane.ManufactureDate = new DateTime(2019, 12, 13);
            plane.Flights = new List<Flight>() { flight2,flight1};
            return plane;
        }

        public static readonly Staff staffCaptain = new Staff
        {
            FirstName = "captain",
            LastName = "Captain",
            EmailAddress = "captain@gmail.com",
            BirthDate = new DateTime(1965, 01, 01),
            EmployeDate = new DateTime(1999, 01, 01),
            salary = 10000,
            Flights= new List<Flight>() { flight1}
        };

        public static readonly Staff staffHostess1 = new Staff
        {
            FirstName = "hostess1",
            LastName = "Hostess1",
            EmailAddress = "hostess1@gmail.com",
            BirthDate = new DateTime(1995, 01, 01),
            EmployeDate = new DateTime(2019, 01, 01),
            salary = 5000,
            Flights =  new List<Flight>() { flight1}
        };

        public static readonly Staff staffHostess2 = new Staff
        {
            FirstName = "hostess2",
            LastName = "Hotess2",
            EmailAddress = "hostess2@gmail.com",
            BirthDate = new DateTime(1996, 01, 01),
            EmployeDate = new DateTime(2018, 01, 01),
            salary = 6100,
            Flights = new List<Flight>() { flight1,flight3}
        };

        public static readonly Traveller traveller1 = new Traveller
        {
            FirstName = "traveller1",
            LastName = "Traveller1",
            BirthDate = new DateTime(1980, 01, 01),
            HelathInformation = "No troubles",
            Nationality = "Americain",
            Flights= new List<Flight>() { flight2,flight3}
        };

        public static readonly Traveller traveller2 = new Traveller
        {
            FirstName = "traveller2",
            LastName = "Traveller2",
            BirthDate = new DateTime(1981, 01, 01),
            HelathInformation = "Some troubles",
            Nationality = "French",
            Flights= new List<Flight>() { flight2,flight3}
        };
        public static readonly Traveller traveller3 = new Traveller
        {
            FirstName = "traveller3",
            LastName = "Traveller3",
            BirthDate = new DateTime(1982, 01, 01),
            HelathInformation = "No troubles",
            Nationality = "Tunisien",
            Flights= new List<Flight>() { flight2,flight3}
        };
        public static readonly Traveller traveller4 = new Traveller
        {
            FirstName = "traveller4",
            LastName = "Traveller4",
            BirthDate = new DateTime(1983, 01, 01),
            HelathInformation = "Some troubles",
            Nationality = "Americain",
            Flights = new List<Flight>() { flight2,flight3}
        };
        public static readonly Traveller traveller5 = new Traveller
        {
            FirstName = "traveller5",
            LastName = "Traveller5",
            BirthDate = new DateTime(1984, 01, 01),
            HelathInformation = "Some troubles",
            Nationality = "Spanish",
            Flights= new List<Flight>() { flight2,flight3}
        };
        public static List<Traveller> Travellers = new List<Traveller> { traveller3, traveller1,traveller2,traveller4,traveller5 };
        public static List<Staff> Staffs = new List<Staff> { staffCaptain, staffHostess1, staffHostess2 };

        public static readonly Flight flight1 = new Flight
        {
            FlightId = 1,
            FlightDate = new DateTime(2022, 01, 01, 15, 10, 0),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01, 17, 10, 0),
            EstimatedDuration = 2,
            pplane = Boeing1,
            Passengers = new List<Passenger>() { staffCaptain,staffHostess1,staffHostess2 }
        };
        public static readonly Flight flight2 = new Flight
         {
              FlightId = 2,
              FlightDate = new DateTime(2022, 02, 01, 21, 10, 0),
              Destination = "Paris",
              EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 0),
              EstimatedDuration = 2,
              pplane = Boeing1,
              Passengers= new List<Passenger>() { traveller1,traveller2,traveller3,traveller4,traveller5}
                };

       public static readonly Flight flight3 = new Flight
        {
            FlightId = 3,
            FlightDate = new DateTime(2022, 01, 01, 05, 10, 0),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 03, 01, 07, 10, 0),
            EstimatedDuration = 2,
            pplane= Boeing2,
            Passengers = new List<Passenger>() { traveller1,traveller2,traveller3,traveller4,traveller5,staffCaptain,staffHostess1,staffHostess2}
        };
       public static readonly Flight flight4 = new Flight
        {
            FlightId = 4,
            FlightDate = new DateTime(2022, 04, 01, 06, 10, 0),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 02, 01, 08, 40, 0),
            EstimatedDuration = 2.5f,
            pplane= Boeing2
        };
       public static readonly Flight flight5 = new Flight
        {
            FlightId = 5,
            FlightDate = new DateTime(2022, 05, 01, 17, 10, 0),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 02, 01, 19, 40, 0),
            EstimatedDuration = 2.5f,
            pplane=Airbus
        };
        public static readonly Flight flight6 = new Flight
        {
            FlightId = 6,
            FlightDate = new DateTime(2022, 06, 01, 20, 10, 0),
            Destination = "Lisbonne",
            EffectiveArrival = new DateTime(2022, 02, 01, 2, 10, 0),
            EstimatedDuration = 3,
            pplane=Airbus

        };

        public static List<Flight> Flights = new List<Flight> { flight1, flight2, flight3, flight4, flight5, flight6 };
        }
}
