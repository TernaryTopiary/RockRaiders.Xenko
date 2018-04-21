using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock_Raiders.Scripts.Concepts.Gameplay;

namespace Rock_Raiders.Scripts.Concepts.Map.BuildingType
{
    public interface IBuildingType : ISelectable, ITooltipInformationDisplayable, IExpensive, ITakeTimeToCreateable
    {

    }

    public interface IBuildingTypeDamageable : IDamageable, IBuildingType
    {
    }
}
