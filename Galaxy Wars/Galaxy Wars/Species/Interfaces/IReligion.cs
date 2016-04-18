using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
    interface IReligion
    {

        void Convert(SpeciesClass Enemy);
        void Indoctrine(SpeciesClass Enemy);
        string commandment { get; set; }
        double zealotMultiplier { get; set; }
    }
}
