using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Fish : Aquatic
    {
        public override bool Eyes { get; set } = true;
        public override bool Gills { get; set; } = true;

        public abstract string WaterPreference();
    }
}
