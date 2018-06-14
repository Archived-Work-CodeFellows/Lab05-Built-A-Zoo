using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    /// <summary>
    /// This takes the base class Animal and derives the class Aquatic. It
    /// adds properties that are found in Aquatic animals
    /// </summary>
    public abstract class Aquatic : Animal
    {
        public abstract bool Gills { get; set; }
        public virtual bool SoftBody { get; set; } = true;

        public abstract string Speed();
    }
}
