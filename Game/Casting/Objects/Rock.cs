namespace Game.Casting
{
    class Rock : FallingObject
    {
        public Rock()
        {
            setText("0");
            setScoreIncrement(-getVelocity());
        }
    }
}