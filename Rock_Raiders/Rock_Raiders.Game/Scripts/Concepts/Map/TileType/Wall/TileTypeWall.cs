namespace Rock_Raiders.Scripts.Concepts.Map.TileType.Wall
{
    public class TileWallSoil : ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Soil";
        public bool IsTooltipVocalized { get; set; } = false;
        public bool IsHighlightedToReinforce { get; set; }
        public bool IsHighlightedToDrill { get; set; }
        public bool IsHighlightedToDynamite { get; set; }
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallDirt : ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Dirt";
        public bool IsTooltipVocalized { get; set; } = true;
        public bool IsHighlightedToReinforce { get; set; }
        public bool IsHighlightedToDrill { get; set; }
        public bool IsHighlightedToDynamite { get; set; }
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallLooseRock : ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Loose Rock";
        public bool IsTooltipVocalized { get; set; } = true;
        public bool IsHighlightedToReinforce { get; set; }
        public bool IsHighlightedToDrill { get; set; }
        public bool IsHighlightedToDynamite { get; set; }
        public int DefaultHitpoints { get; set; }
    }

    public class TileTypeTypeWallHardRock : ITileTypeTypeWallHeavyDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Hard Rock";
        public bool IsTooltipVocalized { get; set; } = true;
        public bool IsHighlightedToReinforce { get; set; }
        public bool IsHighlightedToDrill { get; set; }
        public bool IsHighlightedToDynamite { get; set; }
        public int DefaultHitpoints { get; set; }
    }

    public class TileTypeTypeWallSolidRock : ITileTypeWall
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Solid Rock";
        public bool IsTooltipVocalized { get; set; } = true;
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallOreSeam : ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Ore Seam";
        public bool IsTooltipVocalized { get; set; } = true;
        public bool IsHighlightedToReinforce { get; set; }
        public bool IsHighlightedToDrill { get; set; }
        public bool IsHighlightedToDynamite { get; set; }
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallEnergyCrystalSeam : ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Energy Crystal Seam";
        public bool IsTooltipVocalized { get; set; } = true;
        public bool IsHighlightedToReinforce { get; set; }
        public bool IsHighlightedToDrill { get; set; }
        public bool IsHighlightedToDynamite { get; set; }
        public int DefaultHitpoints { get; set; }
    }

    public class TileTypeTypeWallEnergyCrystalRegeneratorSeam : ITileTypeWall
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Recharge Seam";
        public bool IsTooltipVocalized { get; set; } = true;
    }
}