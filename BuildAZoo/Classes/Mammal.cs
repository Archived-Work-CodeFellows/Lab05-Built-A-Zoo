using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    /// <summary>
    /// This takes the base of Animal and derives a new class
    /// called Mammal and adds properties that can be found in mammals
    /// </summary>
    public abstract class Mammal : Animal
    {
        public virtual bool Hair { get; set; } = false;
        public virtual bool Fur { get; set; } = true;
        
    }
}
