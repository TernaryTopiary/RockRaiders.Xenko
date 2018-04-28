using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Rock_Raiders.Scripts.Concepts.Cosmic.Array;
using Rock_Raiders.Scripts.Concepts.Exceptions;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Engine;
using SiliconStudio.Xenko.Extensions;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Graphics.GeometricPrimitives;
using SiliconStudio.Xenko.Rendering;
using Buffer = SiliconStudio.Xenko.Graphics.Buffer;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Map.Components
{
    public class Map : AsyncScript
    {
        public event Action MapDrawn;
        public Tile[,] Tiles;

        public Map()
        {
            InitializeComponent();
        }

        public Map(Tile[,] preloadMapTiles)
        {
            Tiles = preloadMapTiles;

            InitializeComponent();
        }

        private void InitializeComponent()
        {

            var inputFilePath = "";
            var mapFileRawData = File.ReadAllLines(inputFilePath);
            Tiles = LoadMapFromFile();
            DrawMapTiles();

        }

        private Tile[,] LoadMapFromFile()
        {
            var lines = new string[] { };
            int x = 0, y = 0;

            var lineDataArray = lines.First().Split('|');
            if (!int.TryParse(lineDataArray[Constants.Constants.MapWidthIndex], out var mapDimensionWidth)) throw new MapFormatException();
            if (!int.TryParse(lineDataArray[Constants.Constants.MapHeightIndex], out var mapDimensionHeight)) throw new MapFormatException();
            var dimensions = new Index2(mapDimensionWidth, mapDimensionHeight);

            var tiles = new Tile[dimensions.X, dimensions.Y];

            foreach (var line in lines.Skip(2).Where(line => line.StartsWith("BLOCK")))
            {
                var currentTileLine = line;
                lineDataArray = currentTileLine.Split('|');
                var lineDataArrayNumeric = lineDataArray.Select(data =>
                {
                    if (!int.TryParse(data, out var result)) throw new MapFormatException();
                    return result;
                }).ToList();
                if(lineDataArrayNumeric.Count != 10) throw new MapFormatException();

                var tileType = Constants.Constants.GetTileType(lineDataArrayNumeric[Constants.Constants.MapTileTypeIndex]);
                var tileAverageHeight = lineDataArrayNumeric[Constants.Constants.MapTileAverageHeightIndex];

                tiles[(dimensions.X - 1) - x, y] = new Tile {TileType = tileType};

                x++;
                if (x != dimensions.X) continue;
                x = 0;
                y++;
            }

            return tiles;
        }

        private void DrawMapTiles()
        {
            foreach (var tile in Tiles)
            {
                var entity = new Entity();
                var model = new Model();
                entity.GetOrCreate<ModelComponent>().Model = model;

                // Create a vertex layout with position and texture coordinate
                var layout = new VertexDeclaration(VertexElement.Position<Vector3>(), VertexElement.TextureCoordinate<Vector2>());
                // Create the vertex buffer from an array of vertices
                var vertices = tile.Verticies;
                var vertexBuffer = Buffer.Vertex.New(GraphicsDevice, vertices);
                // Create a vertex buffer binding
                var vertexBufferBinding = new VertexBufferBinding(vertexBuffer, layout, vertices.Length);

                // Create the index buffer
                var indices = tile.Indicies;
                var indexBuffer = Buffer.Vertex.New(GraphicsDevice, tile.Indicies);
                var indexBufferBinding = new IndexBufferBinding(indexBuffer, false, indices.Length);

                var mesh = new Mesh
                {
                    Draw = new MeshDraw
                    {
                        VertexBuffers = new[] { vertexBufferBinding },
                        IndexBuffer = indexBufferBinding
                    }
                };
                model.Meshes.Add(mesh);
            }

            MapDrawn?.Invoke();
        }

        public override Task Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
