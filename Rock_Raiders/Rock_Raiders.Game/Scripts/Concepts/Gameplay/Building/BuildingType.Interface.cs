using Rock_Raiders.Scripts.Concepts.Gameplay.Shared;
using SiliconStudio.Core.Mathematics;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Building
{
    public interface IBuildingType : ISelectable, ITooltipInformationDisplayable, IExpensive, ITakeTimeToCreateable, IDamageable, IRepairable, IUpgradable
    {
        IBuildingTileLayout[,] DefaultTileLayout { get; set; }
        Point BuildingPivotCoordinates { get; set; }
    }

    public static class BuildingTypeExtensions
    {
        public static int BuildingWidth(this IBuildingType type) => type.DefaultTileLayout.GetLength(0);

        public static int BuildingHeight(this IBuildingType type) => type.DefaultTileLayout.GetLength(1);
    }
}
