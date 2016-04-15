using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
    class IcePirates : Species, IWarMonger
    {
        public double aggressionMultiplier { get; set; }
        public string alignment { get; set; }
        public string type { get; set; }
        public int vanquishedEars { get; set; }

        public void Berserker(Species Enemy)
        {
            Enemy.population -= 10000;
            this.population -= 2500;
        }

        public bool hasEyePatch { get; set; }
        public bool hasIceHook { get; set; }
        public bool foundTreasure { get; set; }
        public bool literacy { get; set; }
        public int peglegs { get; set; }

        public IcePirates()
        {
            this.hasEyePatch = true;
            this.foundTreasure = false;
            this.vanquishedEars = 0;
            this.type = "Warmonger";
        }
    }
}
