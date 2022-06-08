namespace Game.Casting
{
    class Gem : FallingObject
    {
        public Gem()
        {
            setText("*");
            setScoreIncrement(getVelocity());
        }

        
    }
}