using System;
using System.Collections.Generic;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Shared
{
    public interface IExpensive
    {
        Dictionary<Type, int> Cost { get; set; }
    }
}
