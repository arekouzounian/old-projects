using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ArekPong
{
    class Paddle
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int Speed;
        public Brush Color;
        public Rectangle PaddleHitBox;
        public Paddle(int x, int y, int width, int height, int speed, Brush color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Speed = speed;
            Color = color;
            PaddleHitBox = new Rectangle(X, Y, Width, Height);
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(Color, PaddleHitBox);
        }
    }
}
