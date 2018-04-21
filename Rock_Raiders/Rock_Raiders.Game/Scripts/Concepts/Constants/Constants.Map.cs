using SiliconStudio.Core.Mathematics;

namespace Rock_Raiders.Scripts.Concepts.Constants
{
    public static partial class Constants
    {
        public static int TileScale = 1;

        public static readonly Vector3[] DefaultTileVerticies =
        {
            new Vector3(0, 0, 0),
            new Vector3(0, 0, TileScale),
            new Vector3(TileScale, 0, TileScale),
            new Vector3(TileScale, 0, 0)
        };

        public static readonly int[] TileIndicies = { 0, 1, 2, 2, 3, 0 };
    }
}