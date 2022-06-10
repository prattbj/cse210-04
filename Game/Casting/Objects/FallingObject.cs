using Raylib_cs;
namespace Game.Casting
{
    //The objects that fall from the sky.
    //The responsibility of FallingObject is
    //to hold the values of the velocity, score increment,
    //and hold getters and setters.
    class FallingObject : Actor
    {
        private Random random = new Random();
        private int velocity = 0;
        private int scoreIncrement = 0;
        //Construct the falling object with a random velocity and
        //a random start position on the x axis
        public FallingObject()
        {
            this.velocity = random.Next(1, 5);
            setX(random.Next(10, 790));
        }
        // returns the score increment value
        public int getScore()
        {
            return scoreIncrement;
        }
        //returns the velocity
        public int getVelocity()
        {
            return this.velocity;
        }
        //sets the score increment value
        public void setScoreIncrement(int scoreIncrement)
        {
            this.scoreIncrement = scoreIncrement;
        }
        //sets the y position
        public void setPosition()
        {
            setY(velocity);
        }
    }
}