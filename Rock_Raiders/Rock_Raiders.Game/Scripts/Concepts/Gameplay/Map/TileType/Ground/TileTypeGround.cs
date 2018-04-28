using Rock_Raiders.Scripts.Miscellaneous;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Map.TileType.Ground
{
    public class TileTypeTypeGroundSoil : Singleton<TileTypeTypeGroundSoil>, ITileTypeSolidGround, ITileTypeBuildable
    {
        public ITileBiome Biome { get; set; }
        public bool CanBeEroded { get; set; } = true;
        public string TooltipText { get; set; } = "Soil";
        public bool IsTooltipVocalized { get; set; } = false;
        public bool IsHighlightedToBuild { get; set; }
    }

    public class TileGroundSlimySlugHole : Singleton<TileGroundSlimySlugHole>, ITileTypeSolidGround
    {
        public ITileBiome Biome { get; set; }
        public bool CanBeEroded { get; set; } = true;
        public string TooltipText { get; set; } = "Slimy Slug Hole";
        public bool IsTooltipVocalized { get; set; } = true;
    }

    public class TileGroundWater : Singleton<TileGroundWater>, ITileTypeLiquidGround
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Water";
        public bool IsTooltipVocalized { get; set; } = true;
    }

    public class TileGroundLava : Singleton<TileGroundLava>, ITileTypeLiquidGround, ITileTypeDamagingGround
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Lava";
        public bool IsTooltipVocalized { get; set; } = true;
    }
}