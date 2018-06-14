using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    /// <summary>
    /// This takes the base class Feline and derives a Tiger. It will inherit everything
    /// from Feline and before, it also implements the IEatPeople interface. It defines all
    /// abstract properties and either overrides or leaves virtual properties as is.
    /// </summary>
    public class Tiger : Feline, IEatPeople
    {
        public override int Size { get; set; } = 20;
        public override int Legs { get; set; } = 4;
        public bool EatPeople { get; set; } = true;

        public override bool Affection()
        {
            return false;
        }
        public string EatingPeople()
        {
            return "sometimes things get complicated";
        }

        public override string Sound()
        {
            return "Rawwwwr";
        }
    }
}
