using System;
using System.Collections.Generic;
using System.Text;

namespace BussLinjen
{
    class Buss
    {
        public int MaxPassengers { get; set; }
        public List<Passenger> BussCurrentPassenger { get; set; }
        public string Personmarker { get; set; }

        public Buss(int maxPassengers)
        {
            MaxPassengers = maxPassengers;
        }
    }

}
