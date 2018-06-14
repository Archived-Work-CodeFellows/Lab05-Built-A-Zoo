using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Mammal : Animal
    {
        public virtual bool Hair { get; set; } = false;
        public virtual bool Fur { get; set; } = true;
        
    }
}
