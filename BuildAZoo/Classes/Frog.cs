using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Frog : Aquatic
    {
        public override bool Eyes { get; set; } = true;
        public override int Legs { get; set; } = 4;
        public override bool Gills { get; set; } = true;
        public override bool SoftBody { get; set; } = true;

        public override string Diet()
        {
            return "Bugs";
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
