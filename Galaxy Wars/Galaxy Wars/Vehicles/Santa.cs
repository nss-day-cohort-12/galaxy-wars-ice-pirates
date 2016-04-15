using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Vehicles
{
    class Santa : VehicleType
    {
        //number of condensators onboard
        public int condensator { get; set; }

        public override void Fly()
        {
            Console.Write("Santa is flying!");
        }

        public Santa()
        {
            condensator = 0;
        }
    }
}
