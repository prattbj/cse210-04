namespace Game.Casting
{
    class Player : Actor
    {
        private int direction = 0;

        public Player() 
        {
            setText("#");
            setY(465);
        }

        public void SetPosition() 
        {
            setX(this.direction * 5);
        }

        public void SetDirection(int direction)
        {
            this.direction = direction;
        }
    }
}