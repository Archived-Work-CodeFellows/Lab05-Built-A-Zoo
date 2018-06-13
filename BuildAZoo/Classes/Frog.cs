using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public class Frog : Aquatic, IVenomous
    {
        public override bool Eyes { get; set; } = true;
        public override int Legs { get; set; } = 4;
        public override bool Gills { get; set; } = true;
        public override bool SoftBody { get; set; } = true;
        public bool Venomous { get; set; }

        public override string Diet()
        {
            return "Bugs";
        }

        public string HowDeadly(int scale)
        {
            return $"{scale} is how posionous I am";
        }

        public override string Sound()
        {
            return "Croaaaak";
        }

        public override string Speed()
        {
            return "However fast hopping is";
        }
    }
}
