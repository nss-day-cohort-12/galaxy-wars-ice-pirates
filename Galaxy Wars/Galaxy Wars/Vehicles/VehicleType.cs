using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Vehicles
{
    class VehicleType
    {
        public int speed { get; set; }
        public double defense { get; set; }
        public double offense { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine("Currently flying");
        }

        public VehicleType()
        {
            this.speed = 100;
            this.defense = 10;
            this.offense = 25;
        }
    }
}
