namespace Game.Casting
{
    //Rock holds the information about rocks.
    //It sets the values that pertain to rocks
    //whenever a gem is created
    class Rock : FallingObject
    {
        //set the text to 0, set the score increment to
        //the negative of the velocity, set the color to grey
        public Rock()
        {
            setText("0");
            setScoreIncrement(-getVelocity());
            Color color = new Color(50, 50, 50);
            setColor(color);
        }
    }
}