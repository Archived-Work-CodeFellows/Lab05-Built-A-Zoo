using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public class Sunfish : Fish, IVenomous
    {
        public override int Legs { get; set; } = 0;
        public bool Fins { get; set; } = true;
        public bool Venomous { get; set; }

        public override string Diet()
        {
            return "some little kelpy things";
        }

        public string HowDeadly(int scale)
        {
            throw new NotImplementedException();
        }

        public override string Sound()
        {
            return "glug glug";
        }

        public override string Speed()
        {
            return "fish speed";
        }

        public override string WaterPreference()
        {
            return "I like saltwater";
        }
    }
}
