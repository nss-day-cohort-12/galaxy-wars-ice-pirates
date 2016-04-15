using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
    class Parched : Species, IReligion
    {

        public string type { get; set; }
        public string commandment { get; set}
        public double zealotMultiplier { get; set; }

        public void Convert(Species Enemy)
        {

        }

        public void Indoctrine(Species Enemy)
        {

        }

        public bool blind { get; set; }
        public bool contraceptives { get; set; }
        public bool thirsty { get; set; }
        public int followers { get; set; }
        public bool worshipNeptune { get; set; }

        public Parched()
        {
            this.type = "Religious";
            this.commandment = "Giveth the water, for your soul to be cleansed";
            this.blind = true;
            this.thirsty = true;
        }
    }
}
