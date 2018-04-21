using Rock_Raiders.Scripts.Concepts.Gameplay;
using Rock_Raiders.Scripts.Concepts.Map;
using Rock_Raiders.Scripts.Concepts.Map.TileType;
using Rock_Raiders.Scripts.Concepts.Map.TileType.Ground;
using SiliconStudio.Core.Mathematics;

namespace Rock_Raiders.Scripts.Map.Components
{
    public interface ITile : IPositionable
    {
        ITileType TileType { get; set; }
        Vector3 Vertex0 { get; set; }
        Vector3 Vertex1 { get; set; }
        Vector3 Vertex2 { get; set; }
        Vector3 Vertex3 { get; set; }
    }

    public class Tile : ITile
    {
        public ITileType TileType { get; set; }
        public Vector3 Vertex0 { get; set; }
        public Vector3 Vertex1 { get; set; }
        public Vector3 Vertex2 { get; set; }
        public Vector3 Vertex3 { get; set; }
        public Vector3 VertexNorthWest => Vertex0;
        public Vector3 VertexNorthEast => Vertex1;
        public Vector3 VertexSouthEast => Vertex2;
        public Vector3 VertexSouthWest => Vertex3;
        public float AverageTileHeight => (Vertex0.Y + Vertex1.Y + Vertex2.Y + Vertex3.Y) / 4;

        public bool IsGround => TileType is ITileTypeGround;
        public bool IsWall => TileType is ITileTypeWall;
        public bool IsSoil => TileType is TileTypeTypeGroundSoil;
        public bool IsWater => TileType is TileTypeTypeGroundWater;
        public bool IsLava => TileType is TileTypeTypeGroundLava;
    }
}