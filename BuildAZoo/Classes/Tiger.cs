using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    class Tiger : Feline
    {
        public override int Size { get; set; }
        public override int Legs { get; set; }
        public string FurColor { get; set; }

        public override bool Affection()
        {
            return false;
        }

        public override string Diet()
        {
            return "Carnovoire";
        }

        public override string Sound()
        {
            return "Rawwwwr";
        }
    }
}
