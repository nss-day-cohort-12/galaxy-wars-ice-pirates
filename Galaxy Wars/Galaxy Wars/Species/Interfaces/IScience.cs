﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
    interface IScience
    {
        double intelligenceMultiplier { get; set; }
        void Clone();
        
        string alignment { get; set; }
        void Clone(int growth);
    }
}