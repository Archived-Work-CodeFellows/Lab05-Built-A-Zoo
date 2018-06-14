using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    /// <summary>
    ///This takes the base class Aquatic and derives a Fish class. It overrides 
    ///abstract properties and also adds a new abstract method.
    /// </summary>
    public abstract class Fish : Aquatic
    {
        public override bool Eyes { get; set; } = true;
        public override bool Gills { get; set; } = true;

        public abstract string WaterPreference();
    }
}
