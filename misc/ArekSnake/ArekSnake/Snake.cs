using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ArekSnake
{
    class Snake
    {
       
        public List <SnakePart> snakePieces = new List<SnakePart>();
        public int X;
        public int Y;
        Random gen = new Random();
        public Brush Color;
        public bool Dead = false;
        public int userScore = 0;

        public SnakePart Head
        {
            get
            {
                return snakePieces[0];
            }
            set
            {
                snakePieces[0] = value;
            }
        }

        public Snake(int x, int y, Brush color)
        {
            X = x;
            Y = y;
            Color = color;
            snakePieces.Add(new SnakePart(x, y, 18, Color));
        }
        public void Update(Food food, Size screen)
        {

            for (int i = 0; i < snakePieces.Count; i++)
            {
                snakePieces[i].Move();
            }
            
            //alter piece directions
            //loop through snake pieces
            for (int i = snakePieces.Count - 1; i > 0; i--)
            {
                snakePieces[i].direction = snakePieces[i - 1].direction;
            }

            if (Head.Hitbox.IntersectsWith(food.Hitbox))
            {
                food.X = gen.Next(0, screen.Width / 18) * 18;
                food.Y = gen.Next(0, screen.Height / 18) * 18;

                userScore++;
                //add a new snake piece
                //place the new peice at the tail
                //move the piece in the opposite direction of the tail once
                //set the direction of the new piece to the direction of the tail
                SnakePart tail = snakePieces[snakePieces.Count - 1];
                SnakePart newPart = new SnakePart(tail.X, tail.Y, 18, Brushes.White);
                newPart.direction = tail.direction;
                if(tail.direction == SnakePart.Direction.Right)
                {
                    newPart.X -= 18;
                }
                if (tail.direction == SnakePart.Direction.Left)
                {
                    newPart.X += 18;
                }
                if (tail.direction == SnakePart.Direction.Up)
                {
                    newPart.Y += 18;
                }
                if (tail.direction == SnakePart.Direction.Down)
                {
                    newPart.Y -= 18;
                }
                snakePieces.Add(newPart);
            }

            for (int i = 1; i < snakePieces.Count; i++)
            {
                if (snakePieces[0].Hitbox.IntersectsWith(snakePieces[i].Hitbox))
                {
                    Dead = true;
                }
            }
            
            if(Head.X > screen.Width)
            {
                Dead = true;
            }
            if(Head.X < 0)
            {
                Dead = true;
            }
            if (Head.Y > screen.Height)
            {
                Dead = true;
            }
            if (Head.Y < 0)
            {
                Dead = true;
            }
        }

        public void Draw(Graphics gfx)
        {
            for (int i = 0; i < snakePieces.Count; i++)
            {
                gfx.FillRectangle(Color, snakePieces[i].Hitbox);
            }
        }
    }
}
