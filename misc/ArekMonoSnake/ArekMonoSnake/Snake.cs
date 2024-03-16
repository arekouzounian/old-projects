using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekMonoSnake
{
    class Snake
    {
        List<SnakePiece> snakePieces = new List<SnakePiece>();

        public bool isDead = false;
        public Vector2 Position;
        public Color Color;

        public Vector2 originalPosition; 
 

        public SnakePiece Head
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


        public Snake(Vector2 position, Color color, Texture2D image)
        {
            Position = position;
            Color = color;
            snakePieces.Add(new SnakePiece(new Vector2(20), position, image));
            Head.Tint = color;
            originalPosition = position;
        }

        public void Update(Rectangle Screen)
        {
            Head.CheckDirection();

            //move entire snake
            for (int i = 0; i < snakePieces.Count; i++)
            {
                snakePieces[i].Update(Screen);
            }

            for (int i = snakePieces.Count - 1; i > 0; i--)
            {
                snakePieces[i].Direction = snakePieces[i - 1].Direction;
            }

            //intersection between food and head will be in Game1.cs

            for (int i = 1; i < snakePieces.Count; i++)
            {
                if (Head.Hitbox.Intersects(snakePieces[i].Hitbox))
                {
                    isDead = true;
                }
            } 

            if (Head.Hitbox.X + Head.Size.X > Screen.Width)
            {
                isDead = true;
            }
            else if (Head.Hitbox.X < 0)
            {
                isDead = true;
            }
            else if (Head.Hitbox.Y + Head.Size.Y > Screen.Height)
            {
                isDead = true;
            }
            else if (Head.Hitbox.Y < 0)
            {
                isDead = true;
            }

        }

        public void addPiece()
        {
            snakePieces[0] = Head;
            SnakePiece tail = snakePieces[snakePieces.Count - 1];
            SnakePiece newPiece = new SnakePiece(new Vector2(tail.Size.X, tail.Size.Y), new Vector2(tail.Position.X, tail.Position.Y), tail.Image);
            newPiece.Direction = tail.Direction;
            if (tail.Direction == SnakePiece.direction.Right)
            {
                newPiece.Position.X -= tail.Size.X; 
            }
            else if (tail.Direction == SnakePiece.direction.Left)
            {
                newPiece.Position.X += tail.Size.X;
            }
            else if (tail.Direction == SnakePiece.direction.Up)
            {
                newPiece.Position.Y += tail.Size.Y; 
            }
            else if (tail.Direction == SnakePiece.direction.Down)
            {
                newPiece.Position.Y -= tail.Size.Y; 
            }
            snakePieces.Add(newPiece);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < snakePieces.Count; i++)
            {
                snakePieces[i].Draw(spriteBatch);
            }
        }

        public void Restart()
        {
            Head.Position = originalPosition;
            snakePieces[0].Direction = SnakePiece.direction.None;
            for (int i = snakePieces.Count - 1; i > 0; i--)
            {
                snakePieces.RemoveAt(i);
            }
        }
    }
}
