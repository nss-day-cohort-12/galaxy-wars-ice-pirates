using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Galaxy_Wars.Vehicles
{
    class Maria: VehicleType
    {
        //number of conedensators onboard
        public int condensator { get; set; }

        //does the Maria fly
        public override void Fly()
        {
            Console.Write("Maria is flying!");
        }

    }
}
