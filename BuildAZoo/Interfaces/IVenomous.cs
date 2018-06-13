using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    interface IVenomous
    {
        bool Venomous { get; set; }
        string HowDeadly(int scale);
    }
}
