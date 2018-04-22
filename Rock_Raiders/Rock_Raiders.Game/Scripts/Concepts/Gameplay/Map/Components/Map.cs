using System.Threading.Tasks;
using SiliconStudio.Xenko.Engine;
using SiliconStudio.Xenko.Extensions;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Graphics.GeometricPrimitives;
using SiliconStudio.Xenko.Rendering;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Map.Components
{
    public class Map : AsyncScript
    {
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
            // Initialization of the script.


            // Create an entity and add it to the scene.
            var entity = new Entity();
            SceneSystem.SceneInstance.RootScene.Entities.Add(entity);

            // Create a model and assign it to the model component.
            var model = new Model();
            entity.GetOrCreate<ModelComponent>().Model = model;

            // Create a mesh using your own vertex and index buffers.
            var mesh = new Mesh { Draw = new MeshDraw { /* Vertex buffer and index buffer setup */ } };
            model.Meshes.Add(mesh);

        }

        public override Task Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
