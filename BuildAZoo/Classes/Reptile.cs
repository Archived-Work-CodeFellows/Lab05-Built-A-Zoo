using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Reptile : Animal
    {
        public abstract bool Scales { get; set; }
        public abstract bool Feathers { get; set; }


    }
}
