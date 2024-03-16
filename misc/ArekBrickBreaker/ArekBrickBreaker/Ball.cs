using System;
using System.Drawing;

namespace ArekBrickBreaker
{
    class Ball
    {
        public int X;
        public int Y;
        public int Size; 
        public int Xspeed;
        public int Yspeed;
        public Brush Color;
        public Rectangle Hitbox; 
        public Ball(int x, int y, int size, int xspeed, int yspeed, Brush color)
        {
            X = x;
            Y = y;
            Size = size; 
            Xspeed = xspeed;
            Yspeed = yspeed;
            Color = color;
            Hitbox = new Rectangle(X, Y, Size, Size);
        }
        public void Move(Size ClientSize)
        {
            Hitbox.X += Xspeed;
            Hitbox.Y += Yspeed; 

            if ((Hitbox.X + Hitbox.Width)>= ClientSize.Width)
            {
                Xspeed = -Math.Abs(Xspeed);
            }
            if (Hitbox.X <= 0)
            {
                Xspeed = Math.Abs(Xspeed);
            }
            if (Hitbox.Y <= 0)
            {
                Yspeed = Math.Abs(Yspeed);
            }
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillEllipse(Color, Hitbox);
        }
    }
}
