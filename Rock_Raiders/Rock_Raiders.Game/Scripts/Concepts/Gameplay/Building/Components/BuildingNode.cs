using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Building.Components
{
    public class BuildingNode
    {
    }

    public static class BuildingNodes
    {
        public static BuildingNode BasePlate1x1 = new BuildingNode() { };

        public static BuildingNode BasePlate1x2 = new BuildingNode() { };

        public static BuildingNode ToolstoreBuildingX0Y0 = new BuildingNode() { };

        public static BuildingNode TeleportPadBuildingX0Y0 = new BuildingNode() { };

        public static BuildingNode DocksBuildingX0Y0 = new BuildingNode() { };

    }
}
