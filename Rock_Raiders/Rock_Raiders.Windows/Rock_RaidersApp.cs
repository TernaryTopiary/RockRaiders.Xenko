using SiliconStudio.Xenko.Engine;

namespace Rock_Raiders
{
    class Rock_RaidersApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
