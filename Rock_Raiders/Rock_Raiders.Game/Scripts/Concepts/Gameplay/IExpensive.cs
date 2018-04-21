﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Raiders.Scripts.Concepts.Gameplay
{
    public interface IExpensive
    {
        Dictionary<Type, int> Cost { get; set; }
    }
}
