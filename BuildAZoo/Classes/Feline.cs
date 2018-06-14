using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Feline : Mammal
    {
        public abstract int Size { get; set; }
        public virtual string FurColor { get; set; } = "Orange&Black";
        public override bool Eyes { get; set; } = true;

        public abstract bool Affection();
    }
}