using Rock_Raiders.Scripts.Miscellaneous;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Map.TileType.Wall
{
    public class TileWallSoil : Singleton<TileWallSoil>, ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Soil";
        public bool IsTooltipVocalized { get; set; } = false;
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallDirt : Singleton<TileWallDirt>, ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Dirt";
        public bool IsTooltipVocalized { get; set; } = true;
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallLooseRock : Singleton<TileWallLooseRock>, ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Loose Rock";
        public bool IsTooltipVocalized { get; set; } = true;
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallHardRock : Singleton<TileWallHardRock>, ITileTypeTypeWallHeavyDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Hard Rock";
        public bool IsTooltipVocalized { get; set; } = true;
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallSolidRock : Singleton<TileWallSolidRock>, ITileTypeWall
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Solid Rock";
        public bool IsTooltipVocalized { get; set; } = true;
    }

    public class TileWallOreSeam : Singleton<TileWallOreSeam>, ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Ore Seam";
        public bool IsTooltipVocalized { get; set; } = true;
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallEnergyCrystalSeam : Singleton<TileWallEnergyCrystalSeam>, ITileTypeWallLightDrillable
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Energy Crystal Seam";
        public bool IsTooltipVocalized { get; set; } = true;
        public int DefaultHitpoints { get; set; }
    }

    public class TileWallEnergyCrystalRegeneratorSeam : Singleton<TileWallEnergyCrystalRegeneratorSeam>, ITileTypeWall
    {
        public ITileBiome Biome { get; set; }
        public string TooltipText { get; set; } = "Recharge Seam";
        public bool IsTooltipVocalized { get; set; } = true;
    }
}