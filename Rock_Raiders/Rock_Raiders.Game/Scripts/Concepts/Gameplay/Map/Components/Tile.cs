using Rock_Raiders.Scripts.Concepts.Gameplay.Map.TileType;
using Rock_Raiders.Scripts.Concepts.Gameplay.Map.TileType.Ground;
using Rock_Raiders.Scripts.Concepts.Gameplay.Shared;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Graphics;
using System;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Map.Components
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
        public event Action<Tile, VertexPositionTexture[]> VerticiesChanged;

        public ITileType TileType { get; set; }

        private VertexPositionTexture[] _verticies = Constants.Constants.DefaultTileVerticies;

        public VertexPositionTexture[] Verticies
        {
            get => _verticies;
            set
            {
                var old = _verticies;
                _verticies = value;
                VerticiesChanged?.Invoke(this, _verticies);
            }
        }

        private short[] _indicies = Constants.Constants.TileIndicies;

        public short[] Indicies
        {
            get => _indicies;
            set => _indicies = value;
        }

        private void SetVertexAt(int index, Vector3 value)
        {
            _verticies[index].Position = value;
            VerticiesChanged?.Invoke(this, _verticies);
        }

        public Vector3 Vertex0
        {
            get => _verticies[0].Position;
            set => SetVertexAt(0, value);
        }

        public Vector3 Vertex1
        {
            get => _verticies[1].Position;
            set => SetVertexAt(1, value);
        }

        public Vector3 Vertex2
        {
            get => _verticies[2].Position;
            set => SetVertexAt(2, value);
        }

        public Vector3 Vertex3
        {
            get => _verticies[3].Position;
            set => SetVertexAt(3, value);
        }

        public Vector3 VertexNorthWest => Vertex0;
        public Vector3 VertexNorthEast => Vertex1;
        public Vector3 VertexSouthEast => Vertex2;
        public Vector3 VertexSouthWest => Vertex3;
        public float AverageTileHeight => (Vertex0.Y + Vertex1.Y + Vertex2.Y + Vertex3.Y) / 4;

        public bool IsGround => TileType is ITileTypeGround;
        public bool IsWall => TileType is ITileTypeWall;
        public bool IsSoil => TileType is TileTypeTypeGroundSoil;
        public bool IsWater => TileType is TileGroundWater;
        public bool IsLava => TileType is TileGroundLava;
    }
}