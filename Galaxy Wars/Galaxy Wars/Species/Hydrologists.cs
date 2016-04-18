using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
    class Hydrologists: Species 
    {
        public bool pHD { get; set; }
        public bool athletic { get; set; }
        public bool hasBeaker { get; set; }
        public bool hasTechnology { get; set; }
        public int significant { get; set; }

        public void clone (Species Enemy)
        {
            this.population += 5000;
        }
        public double intelligenceMultiplier { get; set; }
        public string alignment { get; set; }
        public string type { get; set; }

        public void replenish (Species Enemy)
        {
            this.population += 10000;
            Enemy.population -= 1000;
        }

    }
}
