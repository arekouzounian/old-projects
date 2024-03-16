using System.Drawing;

namespace ArekBrickBreaker
{
    class Brick
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public Brush Color;
        public Rectangle Hitbox; 
        public Brick(int x, int y, int width, int height, Brush color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
            Hitbox = new Rectangle(X, Y, Width, Height);
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(Color, Hitbox);
        }
    }
}
