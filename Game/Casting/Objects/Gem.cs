namespace Game.Casting
{
    //Gem holds the information about gems.
    //It sets the values that pertain to gems
    //whenever a gem is created
    class Gem : FallingObject
    {
        Random random = new Random();
        //set the text to *, set score increment to the velocity,
        //set it to a random color
        public Gem()
        {
            setText("*");
            setScoreIncrement(getVelocity());
            Color color = new Color(random.Next(1, 256), random.Next(1, 256), random.Next(1, 256));
            setColor(color);
        }

        
    }
}