using Rock_Raiders.Scripts.Concepts.Gameplay.Shared;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Building.BuildingType
{
    public interface IBuildingType : ISelectable, ITooltipInformationDisplayable, IExpensive, ITakeTimeToCreateable, IDamageable, IRepairable, IUpgradable
    {

    }
}
