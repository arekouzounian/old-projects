using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekSnake
{
    class SnakePart
    {
        public enum Direction
        {
            Left,
            Right,
            Up,
            Down,
            None
        }
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
        public Direction direction;

        public SnakePart(int x, int y, int size, Brush color)
        {
            Size = size;
            Color = color;
            X = x;
            Y = y;
            direction = Direction.None;
        }

        public void Move()
        {
            if (direction == Direction.Right)
            {
                X += Size;
            }
            else if (direction == Direction.Left)
            {
                X -= Size; 
            }
            else if (direction == Direction.Down)
            {
                Y += Size;
            }
            else if (direction == Direction.Up)
            {
                Y -= Size; 
            }
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(Color, Hitbox);
        }
    }
}
