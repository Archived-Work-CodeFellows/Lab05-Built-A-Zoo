using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Aquatic : Animal
    {
        public abstract bool Gills { get; set; }
        public virtual bool SoftBody { get; set; } = true;

        public abstract string Speed();
    }
}
