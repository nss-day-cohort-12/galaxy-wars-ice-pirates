using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
    interface IWarMonger
    {
        void Berserker(Species Enemy);
        string type { get; set; }
        string alignment { get; set; }
        int vanquishedEars { get; set; }
        double aggressionMultiplier { get; set; }
    }
}
