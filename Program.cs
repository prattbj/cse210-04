﻿using System;
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
            Gem gem = new Gem();
            cast.AddActor("fallingobject", gem);
            while (!Raylib.WindowShouldClose())
            {
                // Set up canvas to start drawing and set the background to black
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib_cs.Color.BLACK);
                // Display Current FPS
                Raylib.DrawFPS(0, 0); 

                // Draw rocks and gems (x, y, font-size)
                Raylib.DrawText("*", 12, 10, 20, Raylib_cs.Color.WHITE);
                Raylib.DrawText("O", 100, 20, 20, Raylib_cs.Color.BLUE);
                
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}