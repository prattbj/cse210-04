namespace Game.Casting
{
    class Rock : FallingObject
    {
        public Rock()
        {
            setText("0");
            setScoreIncrement(-getVelocity());
            Color color = new Color(50, 50, 50);
            setColor(color);
        }
    }
}