namespace Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Actor is to keep track of its appearance and position in 2d 
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

        // Increase or decrease the x value based on the change
        public void setX(int change)
        {
            x += change;
        }

        //increase or decrease the y value based on the change
        public void setY(int change)
        {
            y += change;
        }

        //sets the color of the object
        public void setColor(Color color)
        {
            this.color = color;
        }

        //returns the current x value
        public int getX()
        {
            return this.x;
        }

        //returns the current y value
        public int getY()
        {
            return this.y;
        }

        //returns the current font size
        public int getFontSize()
        {
            return this.font;
        }

        //returns the current text string
        public string getText()
        {
            return this.text;
        }

        //returns the current color object which contains rgb values
        public Color getColor()
        {
            return this.color;
        }

        //sets the text
        public void setText(string text)
        {
            this.text = text;
        }
    }
}