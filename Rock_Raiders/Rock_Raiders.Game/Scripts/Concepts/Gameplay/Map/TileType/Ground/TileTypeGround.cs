namespace Rock_Raiders.Scripts.Concepts.Gameplay.Map.TileType.Ground
{
    public class TileTypeTypeGroundSoil : ITileTypeSolidGround, ITileTypeBuildable
    {
        public ITileBiome Biome { get; set; }
        public bool CanBeEroded { get; set; } = true;
        public string TooltipText { get; set; } = "Soil";
        public bool IsTooltipVocalized { get; set; } = false;
        public bool IsHighlightedToBuild { get; set; }
    }

    public class TileTypeTypeGroundSlimySlugHole : ITileTypeSolidGround
    {
        public ITileBiome Biome { get; set; }
        public bool CanBeEroded { get; set; } = true;
        public string TooltipText { get; set; } = "Slimy Slug Hole";
        public bool IsTooltipVocalized { get; set; } = true;
    }

    public class TileTypeTypeGroundWater : ITileTypeLiquidGround
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Water";
        public bool IsTooltipVocalized { get; set; } = true;
    }

    public class TileTypeTypeGroundLava : ITileTypeLiquidGround, ITileTypeDamagingGround
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Lava";
        public bool IsTooltipVocalized { get; set; } = true;
    }
}