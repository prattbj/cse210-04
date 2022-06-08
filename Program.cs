// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Game.Directing;
using Game.Services;
using Game.Casting;

namespace Greed
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Raylib.InitWindow(800, 480, "Greed");
            Raylib.SetTargetFPS(60); 
            int yMax = 15;

            while (!Raylib.WindowShouldClose())
            {
                // Set up canvas to start drawing and set the background to black
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                // Display Current FPS
                Raylib.DrawFPS(0, 0); 

                // Draw rocks and gems (x, y, font-size)
                Raylib.DrawText("*", 12, 10, 20, Color.WHITE);
                Raylib.DrawText("O", 100, 20, 20, Color.BLUE);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
=======
            Cast cast = new Cast();
            
>>>>>>> 28cae7084b3df27192ff6ffce9d16a0f0167adc5
        }
    }
}