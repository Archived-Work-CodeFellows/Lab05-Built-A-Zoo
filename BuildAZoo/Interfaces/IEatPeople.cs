using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    interface IEatPeople
    {
        bool EatPeople { get; set; }
        string EatingPeople();
    }
}
