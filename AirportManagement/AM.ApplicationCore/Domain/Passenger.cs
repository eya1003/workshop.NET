﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public string TelNumber { get; set; }
        public virtual IList<Flight> Flights { get; set; }
        public virtual string PassengerType { get; }

        public override string ToString()
        {
            return " passenger first name : " + FirstName + " last name : " + LastName;
        }
    }

}
