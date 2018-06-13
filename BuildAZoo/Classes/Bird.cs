using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Bird : Reptile
    {
        public override bool Eyes { get; set; } = false;
        public override int Legs { get; set; } = 2;
        public override bool Scales { get; set; } = false;
        public override bool Feathers { get; set; } = true;


        public override string Diet()
        {
            return "Dirt and stuff";
        }

        public override string Sound()
        {
            return "Tweet tweet";
        }
    }
}
