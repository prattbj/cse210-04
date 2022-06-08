namespace Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    /// space.
    /// </para>
    /// </summary>
    public class Actor
    {
        private int x = 0;
        private int y = 0;
        private int font = 20;
        private Color color = new Color(255, 0, 0);

        private string text = "";
        public Actor()
        {

        }

        public void setX(int change)
        {
            x += change;
        }
        public void setY(int change)
        {
            y += change;
        }

        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }
        public int getFontSize()
        {
            return this.font;
        }
        public string getText()
        {
            return this.text;
        }
        public Color getColor()
        {
            return this.color;
        }
        public void setText(string text)
        {
            this.text = text;
        }
    }
}