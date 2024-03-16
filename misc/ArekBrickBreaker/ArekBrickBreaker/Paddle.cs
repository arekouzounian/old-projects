using System.Drawing;

namespace ArekBrickBreaker
{
    class Paddle
    {
        public int X;
        public int Y;
        public int Width;
        public int Height; 
        public int Xspeed;
        public int Yspeed;
        public Brush Color;
        public Rectangle Hitbox; 
        public Paddle(int x, int y, int width, int height, int xspeed, int yspeed, Brush color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height; 
            Xspeed = xspeed;
            Yspeed = yspeed;
            Color = color;
            Hitbox = new Rectangle(X, Y, Width, Height);
        }
        public  void Draw(Graphics gfx)
        {
            gfx.FillRectangle(Color, Hitbox);
        }
    }
}
