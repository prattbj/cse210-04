using Raylib_cs;
using Game.Casting;

namespace Game.Services
{
    /// The responsibility of the VideoService class is to draw the game state on the screen. 
    public class VideoService
    {
        private int cellSize = 15;
        private string caption = "";
        private int width = 640;
        private int height = 480;
        private int frameRate = 0;
        private bool debug = false;

        /// Constructs a new instance of KeyboardService using the given cell size.
        public VideoService(string caption, int width, int height, int cellSize, int frameRate, 
                bool debug)
        {
            this.caption = caption;
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            this.frameRate = frameRate;
            this.debug = debug;
        }

        /// Closes the window and releases all resources.
        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        /// Clears the buffer in preparation for the next rendering. Called at the beginning each output phase.
        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            // if (debug)
            // {
            //     DrawGrid();
            // }
        }

        /// Draws the given actor on the screen.
        public void DrawActor(Actor actor)
        {
            string text = actor.getText();
            int x = actor.getX();
            int y = actor.getY();
            int fontSize = actor.getFontSize();
            Casting.Color c = actor.getColor();
            Raylib_cs.Color color = ToRaylibColor(c);
            Raylib.DrawText(text, x, y, fontSize, color);
        }

        /// Draws the given list of actors on the screen.
        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }
        
        /// Copies the buffer contents to the screen. This method is called at the end of the output phase.
        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }

        /// Gets the grid's cell size. This function is not used
        // public int GetCellSize()
        // {
        //     return cellSize;
        // }

        /// Gets the screen's height.
        // public int GetHeight()
        // {
        //     return height;
        // }

        /// Gets the screen's width.
        // public int GetWidth()
        // {
        //     return width;
        // }

        /// Whether or not the window is still open. (t/f)
        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }

        /// Opens a new window with the provided title.
        public void OpenWindow()
        {
            Raylib.InitWindow(width, height, caption);
            Raylib.SetTargetFPS(frameRate);
        }

        /// Draws a grid on the screen. This function is not used
        // private void DrawGrid()
        // {
        //     for (int x = 0; x < width; x += cellSize)
        //     {
        //         Raylib.DrawLine(x, 0, x, height, Raylib_cs.Color.GRAY);
        //     }
        //     for (int y = 0; y < height; y += cellSize)
        //     {
        //         Raylib.DrawLine(0, y, width, y, Raylib_cs.Color.GRAY);
        //     }
        // }

        /// Converts the given color to it's Raylib equivalent.
        private Raylib_cs.Color ToRaylibColor(Casting.Color color)
        {
            int r = color.GetRed();
            int g = color.GetGreen();
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r, g, b, a);
        }
    }
}