using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public class Tiger : Feline, IEatPeople
    {
        public override int Size { get; set; }
        public override int Legs { get; set; }
        public string FurColor { get; set; }
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
