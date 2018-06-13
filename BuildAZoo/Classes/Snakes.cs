using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;


namespace BuildAZoo.Classes
{
    public class Snakes : Reptile, IEatPeople, IVenomous
    {
        public override bool Scales { get; set; } = true;
        public override bool Feathers { get; set; } = false;
        public override bool Eyes { get; set; } = true;
        public override int Legs { get; set; } = 0;
        public bool EatPeople { get; set; }
        public bool Venomous { get; set; }

        public Snakes(bool eatPeople, bool venom)
        {
            Venomous = venom;
            EatPeople = eatPeople;
        }

        public string EatingPeople()
        {
            return "I'm just on a plane, minding my own business";
        }

        public string HowDeadly(int scale)
        {
            return $"Rated: {scale} on the posion scale";
        }

        public bool OnPlane()
        {
            return true;
        }

        public override string Sound()
        {
            return "hissssss";
        }
    }
}
