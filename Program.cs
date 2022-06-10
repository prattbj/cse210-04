using Game.Directing;
using Game.Services;
using Game.Casting;

namespace Greed
{
    class Program
    {
        private static Cast cast = new Cast();
        static void Main(string[] args)
        {
            KeyboardService keyboardService = new KeyboardService(15);
            VideoService videoService = new VideoService("Greed", 800, 480, 15, 60, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}