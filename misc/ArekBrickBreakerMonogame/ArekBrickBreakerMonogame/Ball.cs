using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekBrickBreakerMonogame
{
    class Ball
    {
        public Vector2 Position;
        public Vector2 originalPosition;
        public bool isDead = false;
        public Texture2D Image;
        public Vector2 Speed;
        public Vector2 originalSpeed; 
        public int lives = 3; 
        public Vector2 Size;
        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Size.X, (int)Size.Y);
            }
        }
        public Ball(Vector2 position, Texture2D image, Vector2 speed, Vector2 size)
        {
            Position = position;
            Image = image;
            Speed = speed;
            Size = size;
            originalSpeed = speed;
            originalPosition = position; 
        }

        public void Update(Rectangle Screen)
        {
            isDead = false;

            Position += Speed; 
            if (Position.Y + Size.Y >= Screen.Height)
            {
                Speed.Y = -Math.Abs(Speed.Y);
                lives -= 1;
                if (lives <= 0)
                {
                    isDead = true;
                }
            }
            if (Position.Y <= 0)
            {
                Speed.Y = Math.Abs(Speed.Y);
            }
            if (Position.X + Size.X >= Screen.Width)
            {
                Speed.X = -Math.Abs(Speed.X);
            }
            if (Position.X <= 0)
            {
                Speed.X = Math.Abs(Speed.X);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, new Rectangle(Position.ToPoint(), Size.ToPoint()), Color.White);
        }

        public void Reset()
        {
            this.Speed = originalSpeed;
            this.Position = originalPosition; 
        }
    }
}
