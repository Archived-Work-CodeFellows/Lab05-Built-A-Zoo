using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    /// <summary>
    /// This interface is a template for anything that is Venomous. 
    /// It has a bool property and a HowDeadly method that
    /// must be defined if implemented
    /// </summary>
    interface IVenomous
    {
        bool Venomous { get; set; }
        string HowDeadly(int scale);
    }
}
