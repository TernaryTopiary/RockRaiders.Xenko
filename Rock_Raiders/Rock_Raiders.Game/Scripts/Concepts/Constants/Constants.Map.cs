using System.Linq;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Graphics;

namespace Rock_Raiders.Scripts.Concepts.Constants
{
    public static partial class Constants
    {
        public static int TileScale = 1;

        public static readonly VertexPositionTexture[] DefaultTileVerticies =
        {
            new VertexPositionTexture{ Position = new Vector3(0, 0, 0), TextureCoordinate = new Vector2(0, 0)},
            new VertexPositionTexture{ Position = new Vector3(0, 0, TileScale), TextureCoordinate = new Vector2(0, 1)},
            new VertexPositionTexture{ Position = new Vector3(TileScale, 0, TileScale), TextureCoordinate = new Vector2(1, 1)},
            new VertexPositionTexture{ Position = new Vector3(TileScale, 0, 0), TextureCoordinate = new Vector2(1, 0)}
        };

        public static readonly short[] TileIndicies = { 0, 1, 2, 2, 3, 0 };
    }
}