using Raylib_cs;
namespace Game.Casting
{
    class FallingObject : Actor
    {
        private Random random = new Random();
        private int velocity = 0;
        private int scoreIncrement = 0;
        public FallingObject()
        {
            this.velocity = random.Next(1, 5);
            setX(random.Next(1, 800));
        }
        public int getScore()
        {
            return scoreIncrement;
        }
        public int getVelocity()
        {
            return this.velocity;
        }
        public void setScoreIncrement(int scoreIncrement)
        {
            this.scoreIncrement = scoreIncrement;
        }
        public void setPosition()
        {
            setY(velocity);
        }
    }
}