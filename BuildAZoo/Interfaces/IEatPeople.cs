using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    /// <summary>
    /// This interface is a template for anything that Eats
    /// People. It has a bool property and a EatingPeople method that
    /// must be defined if implemented
    /// </summary>
    interface IEatPeople
    {
        bool EatPeople { get; set; }
        string EatingPeople();
    }
}
