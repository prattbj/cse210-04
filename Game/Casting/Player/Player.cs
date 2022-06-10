namespace Game.Casting
{
    class Player : Actor
    {
        private int direction = 0;

        // Creates an instance of the player with the given values
        public Player() 
        {
            setText("#");
            setY(465);
            Color color = new Color(255, 255, 255);
            setColor(color);
        }

        // Sets the x position of the player
        public void SetPosition() 
        {
            setX(this.direction * 5);
        }

        // Used in GetInputs to change the direction the player moves
        public void SetDirection(int direction)
        {
            this.direction = direction;
        }
    }
}