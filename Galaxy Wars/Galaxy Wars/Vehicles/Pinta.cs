using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Vehicles
{
    class Pinta : VehicleType
    {
        // Does ship have altar
        public bool h2oAlter { get; set; }

        public override void Fly()
        {
            Console.Write("Pinta is flying!");
        }

        public Pinta()
        {
            h2oAlter = true;
        }
    }
}
