using Rock_Raiders.Scripts.Concepts.Gameplay.Shared;
using Rock_Raiders.Scripts.Miscellaneous;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Map.TileType
{
    public interface ITileType : ITooltipInformationDisplayable
    {
        ITileBiome Biome { get; set; }
    }

    public interface ITileTypeWall : ITileTypeSemiTraversable
    {
    }

    public interface ITileTypeWallReinforcable : ITileTypeWall
    {
    }

    public interface ITileTypeWallDamageable : ITileTypeWall, ISelectable, IDamageable
    {
    }

    public interface ITileTypeWallLaserable : ITileTypeWallDamageable
    {
    }

    public interface ITileTypeWallDynamitable : ITileTypeWallDamageable
    {
    }

    public interface ITileTypeTraversable : ITileType
    {
    }

    public interface ITileTypeSemiTraversable : ITileType
    {
    }

    public interface ITileTypeBuildable : ITileType
    {
    }

    public interface ITileTypeGround : ITileType
    { 
    }

    public interface ITileTypeSolidGround : ITileTypeGround, ITileTypeTraversable
    {
        bool CanBeEroded { get; set; }
    }

    public interface ITileTypeLiquidGround : ITileTypeGround
    {
    }

    public interface ITileTypeDamagingGround : ITileTypeGround
    {
    }

    public interface ITileTypeWallDrillable : ITileTypeWallReinforcable, ITileTypeWallDamageable
    {
    }

    public interface ITileTypeWallLightDrillable : ITileTypeTypeWallHeavyDrillable
    {
    }

    public interface ITileTypeTypeWallHeavyDrillable : ITileTypeWallDrillable, ITileTypeWallLaserable, ITileTypeWallDynamitable
    {
    }
}