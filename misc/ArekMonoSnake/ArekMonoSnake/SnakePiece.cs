using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekMonoSnake
{
    class SnakePiece
    {
        public enum direction
        {
            Up, 
            Down, 
            Left, 
            Right,
            None
        }
        public Vector2 Speed;
        public direction Direction;
        public Vector2 Size;
        public Vector2 Position;
        public Texture2D Image;
        public Color Tint;
        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Size.X, (int)Size.Y);
            }
        }
        public SnakePiece(Vector2 size, Vector2 position, Texture2D image)
        {
            Speed = size;
            Size = size;
            Position = position;
            Image = image;
            Direction = direction.None;
            Tint = Color.White;
        }

        public void CheckDirection()
        {
            //change enum direction 

            KeyboardState ks = Keyboard.GetState();
            //moving up
            if ((ks.IsKeyDown(Keys.Up)) && (Direction != direction.Down))
            {
                Direction = direction.Up;
            }
            //moving down
            if ((ks.IsKeyDown(Keys.Down)) && (Direction != direction.Up))
            {
                Direction = direction.Down;
            }
            //moving left
            if ((ks.IsKeyDown(Keys.Left)) && (Direction != direction.Right))
            {
                Direction = direction.Left;
            }
            //moving right
            if ((ks.IsKeyDown(Keys.Right)) && (Direction != direction.Left))
            {
                Direction = direction.Right;
            }
        }

        public void Update(Rectangle Screen)
        {

            //apply direction change
            if (Direction == direction.Up)
            {
                Position.Y -= Speed.Y; 
            }
            if (Direction == direction.Down)
            {
                Position.Y += Speed.Y;
            }
            if (Direction == direction.Left)
            {
                Position.X -= Speed.X; 
            }
            if (Direction == direction.Right)
            {
                Position.X += Speed.X; 
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, new Rectangle(Position.ToPoint(), Size.ToPoint()), Tint);
        }
    }
}
