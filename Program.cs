using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Game.Directing;
using Game.Services;
using Game.Casting;
using Raylib_cs;

namespace Greed
{
    class Program
    {
        private static Cast cast = new Cast();
        static void Main(string[] args)
        {

            Raylib.InitWindow(800, 480, "Greed");
            Raylib.SetTargetFPS(60); 
            int yMax = 15;
            
            int y = 0;

            

            while (!Raylib.WindowShouldClose())
            {
                // Object drops by 1 pixel each frame
                y += 1;

                // Begin output phase
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                Raylib.DrawFPS(0, 0); 
                // VideoService videoService = new VideoService();
 
                Raylib.DrawText("*", 12, y, 20, Color.WHITE);
                Raylib.DrawText("O", 100, y, 20, Color.BLUE);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}