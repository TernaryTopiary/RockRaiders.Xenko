using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Shared
{
    class IDependent
    {
        private Dictionary<Type, int> Requirements { get; set; }
    }
}
