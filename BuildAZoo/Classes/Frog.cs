using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    /// <summary>
    /// This takes the base class Aquatic and derives a Frog class. It will inherit everything
    /// from Aquatic and before, it also implements theIVenomous interface. It defines all
    /// abstract properties and either overrides or leaves virtual properties as is.
    /// </summary>
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
