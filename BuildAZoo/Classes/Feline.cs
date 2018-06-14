using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    /// <summary>
    /// This takes the base class Mammal and derives the Feline class.
    /// Along with what is inherited from Mammal and what Mammal inherited from
    /// Animal, it adds properties and a method that are specific to Feline
    /// </summary>
    public abstract class Feline : Mammal
    {
        public abstract int Size { get; set; }
        public virtual string FurColor { get; set; } = "Orange&Black";
        public override bool Eyes { get; set; } = true;

        public abstract bool Affection();
    }
}