using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    /// <summary>
    /// This takes the base class Fish and derives a Sunfish class. It will inherit everything
    /// from Fish and before, it also implements the IVenomous interface. It defines all
    /// abstract properties and either overrides or leaves virtual properties as is.
    /// </summary>
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
            return "I'm so scary!";
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
