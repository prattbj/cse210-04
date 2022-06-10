using Raylib_cs;
using Game.Casting;

namespace Game.Services
{
    /// The responsibility of a KeyboardService is to detect player key presses and translate them 
    /// into a point representing a direction.
    public class KeyboardService
    {
        /// Constructs a new instance of KeyboardService
        public KeyboardService()
        {
        }

        /// Gets the direction (R/L) based on the currently pressed keys.
        public int GetDirection()
        {
            int dx = 0;


            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                dx = -1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                dx = 1;
            }

            return dx;
        }
    }
}