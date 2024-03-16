using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekSnake
{
    class Food
    {
        public int X;
        public int Y;
        public int Size;
        public Brush Color;

        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle(X, Y, Size, Size);
            }
        }

        public Food(int x, int y, int size, Brush color)
        {
            X = x;
            Y = y;
            Size = size;
            Color = color;
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillEllipse(Color, Hitbox);
        }
    }
}
