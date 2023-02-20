using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployeDate { get; set; }
        public string Function { get;set; }
        public double salary { get; set; }

        public override string ToString()
        {
            return base.ToString()+ " salary staff :  "+salary;
        }

        public override string PassengerType => base.PassengerType+"Staff passenger type";
    }


}
