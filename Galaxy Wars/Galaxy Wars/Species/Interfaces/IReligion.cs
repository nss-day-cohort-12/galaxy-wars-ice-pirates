using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
    interface IReligion
    {
        string type { get; set; }
        void Convert(Species Enemy);
        void Indoctrine(Species Enemy);
        string commandment { get; set; }
        double zealotMultiplier { get; set; }
    }
}
