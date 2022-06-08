namespace Game.Casting
{
    class Rock : FallingObject
    {
        
        public Rock()
        {
            setText("▯");
            setScoreIncrement(-getVelocity());
        }
    }
}