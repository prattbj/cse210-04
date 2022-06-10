using System.Collections.Generic;
using Game.Casting;
using Game.Services;


namespace Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

        private Random random = new Random();


        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            videoService.OpenWindow();
            Player player = new Player();
            Score score = new Score();
            score.changeScore(0);
            cast.AddActor("player", player);
            cast.AddActor("score", score);
            while (videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Player player = (Player) cast.GetFirstActor("player");
            int direction = keyboardService.GetDirection();
            player.SetDirection(direction);     
        }

        /// <summary>
        /// Updates the player's position and the position of the falling objects
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            Score score = (Score) cast.GetFirstActor("score");
            Player player = (Player) cast.GetFirstActor("player");
            List<Actor> fallingObject = cast.GetActors("fallingobject");
            if (player.getX() <= 780 && keyboardService.GetDirection() == 1 || player.getX() >= 5 && keyboardService.GetDirection() == -1) {
                player.SetPosition();
            }
            
            int i = 0;
            foreach (Actor actor in fallingObject)
            {
                FallingObject o = (FallingObject) actor;
                o.setPosition();
                if ((480 > o.getY() && o.getY() > 455) && (player.getX() + 15 > o.getX()) && (player.getX() - 15 < o.getX()))
                {
                    score.changeScore(o.getScore());
                    if (score.getScore() < 0)
                    {
                        score.setScore(0);
                    }
                    cast.RemoveActor("fallingobject", o, i);
                } else if (o.getY() == 485)
                {
                    cast.RemoveActor("fallingobject", o, i);
                }
                i++;
            }

            try {
                if (random.Next(1, (2 + 200/(score.getScore() + 1))) == 1)
                {
                    //create gem or rock
                    if (random.Next(1, 3) == 1)
                    {
                        Gem gem = new Gem();
                        cast.AddActor("fallingobject", gem);
                    } else
                    {
                        Rock rock = new Rock();
                        cast.AddActor("fallingobject", rock);
                    }
                }
            } catch (DivideByZeroException) {
                score.changeScore(0);
            }
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }

    }
}