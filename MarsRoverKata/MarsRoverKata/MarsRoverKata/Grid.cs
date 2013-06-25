namespace MarsRoverKata
{
    public class Grid   
    {
        private readonly int width;
        private readonly int height;

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }
    }
}