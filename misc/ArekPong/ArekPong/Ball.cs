using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekPong
{
    class Ball
    {
        public int X;
        public int Y;
        public int Size;
        public Brush Color;
        public int Xspeed;
        public int Yspeed;
        public bool Fail = false;
        public Rectangle HitBox;
        public Ball(int x, int y, int size, Brush color, int xspeed, int yspeed)
        {
            X = x;
            Y = y;
            Size = size;
            Color = color;
            Xspeed = xspeed;
            Yspeed = yspeed;
            HitBox = new Rectangle(X, Y, Size, Size);
        }
        //height is y, width is x
        public void Move(Size ClientSize)
        {
            HitBox.X += Xspeed;
            HitBox.Y += Yspeed;
            if ((HitBox.X + Size) > ClientSize.Width) 
            {
                //Xspeed *= -1;
                Fail = true; 
            }
            else if ((HitBox.Y + Size) > ClientSize.Height)
            {
                Yspeed *= -1;
            }
            else if (HitBox.X < 0)
            {
                //Xspeed *= -1;
                Fail = true;
            }
            else if (HitBox.Y < 0)
            {
                Yspeed *= -1;
            }
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillEllipse(Color, HitBox);
        }
    }
}
