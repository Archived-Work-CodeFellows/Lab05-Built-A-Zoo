using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
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
