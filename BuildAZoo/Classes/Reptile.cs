using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    /// <summary>
    /// This takes the base class Animal and derives the Reptile Class. It adds
    /// properties that are specific to a Reptile
    /// </summary>
    public abstract class Reptile : Animal
    {
        public abstract bool Scales { get; set; }
        public abstract bool Feathers { get; set; }


    }
}
