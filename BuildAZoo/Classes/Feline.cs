using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Feline : Mammal
    {
        public abstract int Size { get; set; }
        public override bool Fur { get; set; } = true;
        public override bool Eyes { get; set; } = true;

        public abstract bool Affection();
    }
}