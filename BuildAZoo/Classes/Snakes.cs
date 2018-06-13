using System;
using System.Collections.Generic;
using System.Text;


namespace BuildAZoo.Classes
{
    public class Snakes : Reptile
    {
        public override bool Scales { get; set; } = true;
        public override bool Feathers { get; set; } = false;
        public override bool Eyes { get; set; } = true;
        public override int Legs { get; set; } = 0;

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
