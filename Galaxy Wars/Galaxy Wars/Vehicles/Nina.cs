using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Vehicles
{
    class Nina:VehicleType
    {
        //number of iceChests onboard
        public int iceChests { get; set; }

        //does the ship have a wetbar
        public bool wetbar { get; set; }

        public override void Fly()
        {
            Console.Write("Nina is flying!");
        }

        public Nina()
        {
            iceChests = 0;
            wetbar = true;
        }
    }
}
