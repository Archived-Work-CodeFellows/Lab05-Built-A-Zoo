using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    /// <summary>
    /// This is the start of Class layout
    /// </summary>
    public abstract class Animal
    {
        public virtual bool Eyes { get; set; }
        public abstract int Legs { get; set; }

        public virtual string Diet()
        {
            return "food";
        }

        public abstract string Sound();
    }
}
