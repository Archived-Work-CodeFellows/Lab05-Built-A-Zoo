using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    /// <summary>
    /// This takes the base class Feline and derives a HouseCat. It will inherit everything
    /// from Feline and before, it also implements the IEatPeople interface. It defines all
    /// abstract properties and either overrides or leaves virtual properties as is.
    /// </summary>
    public class HouseCat : Feline, IEatPeople
    {
        public override int Size { get; set; }
        public override int Legs { get; set; } = 4;
        public bool EatPeople { get; set; } = true;

        public HouseCat(string furColor, int weight)
        {
            FurColor = furColor;
            Size = weight;
        }

        public HouseCat()
        {
            FurColor = "yellow";
            Size = 10;
        }

        public override string Diet()
        {
            return "Carnovoire";
        }

        public override string Sound()
        {
            return "Meow meow";
        }

        public override bool Affection()
        {
            return true;
        }

        public string EatingPeople()
        {
            return "cough meow cough cough";
        }
    }
}
