using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy_Wars.Vehicles;

namespace Galaxy_Wars.Species
{
    class SpeciesClass
    {
        private double _population;
        private string _name;
        public string type;
        private string _solarSystem;

        private VehicleType _vehicleType;

        public VehicleType vehicleType
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                _vehicleType = value;
            }
        }

        public double population
        {
            get
            {
                return _population;
            }
            set
            {
                _population = value;
            }
        }

        public SpeciesClass()
        {
            //starting population of 1 million
            this.population = 1000000;
        }
    }
}
