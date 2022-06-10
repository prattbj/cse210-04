namespace Game.Casting
{
    class Gem : FallingObject
    {
        Random random = new Random();
        public Gem()
        {
            setText("*");
            setScoreIncrement(getVelocity());
            Color color = new Color(random.Next(1, 256), random.Next(1, 256), random.Next(1, 256));
            setColor(color);
        }

        
    }
}