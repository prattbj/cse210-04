using Raylib_cs;
namespace Game.Casting
{
    class FallingObject : Actor
    {
        private Random random = new Random();
        private int velocity = 0;
        public FallingObject(int velocity)
        {
            this.velocity = velocity;
            
        }
        public int getVelocity()
        {
            return this.velocity;
        }
    }
}