using Game.Directing;
using Game.Services;
using Game.Casting;

namespace Greed
{
    //The program Greed is a game in which the player uses the left and right arrow keys 
    //to move the player object in an attempt to catch gems falling from the sky.
    //Rocks also fall which the player must avoid.
    //The score increases or decreases based on what is caught and the velocity of
    //what is caught.
    class Program
    {
        // Create the cast
        private static Cast cast = new Cast();

        static void Main(string[] args)
        {
            // Start the game
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService("Greed", 800, 480, 15, 60, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}