using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }

        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual IList<Flight> Flights { get; set; }

        public Plane()
        {}
        public Plane(int C, DateTime ManufactureD, PlaneType PlaneT)
        {
            C = Capacity;
            ManufactureD = ManufactureDate;
            PlaneT = PlaneType;
            
        }

        public override string ToString()
        {
            return "id plane : " + PlaneId + " capacite : " + Capacity;
        }
    }
}
