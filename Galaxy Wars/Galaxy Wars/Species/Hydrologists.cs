using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
    class Hydrologists: SpeciesClass, IScience 
    {
        public bool pHD { get; set; }
        public bool athletic { get; set; }
        public bool hasBeaker { get; set; }
        public bool hasTechnology { get; set; }
        public int significantOthers { get; set; }

        public void Clone ()
        {
            this.population += 5000;
        }
        public double intelligenceMultiplier { get; set; }
        public string alignment { get; set; }
        public string type { get; set; }

        public void Clone(int growth)
        {
            this.population += growth;
        }

        public Hydrologists()
        {
            this.type = "Science";
            this.pHD = true;
            this.significantOthers = 0;
        }
    }
}
