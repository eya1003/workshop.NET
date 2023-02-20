using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HelathInformation { get; set; }
        public string Nationality { get; set; }

        public override string ToString()
        {
            return base.ToString()+ "nationality traveller : "+ Nationality;
        }

        public override string PassengerType => base.PassengerType+ "traveller passenger type";
    }
}
