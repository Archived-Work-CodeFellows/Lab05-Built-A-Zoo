using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Sunfish : Fish
    {
        public override int Legs { get; set; } = 0;
        public bool Fins { get; set; } = true;

        public override string Diet()
        {
            return "some little kelpy things";
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
