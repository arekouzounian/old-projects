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
    class Paddle
    {
        public Vector2 originalPosition;
        public int originalSpeed; 

        public Vector2 Position;
        public int Speed;
        public Texture2D Image;
        public Vector2 Size; 
        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Size.X, (int)Size.Y);
            }
        }
        public Paddle(Vector2 position, int speed, Texture2D image, Vector2 size)
        {
            Position = position;
            Speed = speed;
            Image = image;
            Size = size;
            originalPosition = position;
            originalSpeed = speed;
        }

        public void Update(Rectangle Screen)
        {
            //paddle movement
            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.Left) && Position.X > 0)
            {
                Position.X -= Speed;
            }
            if (ks.IsKeyDown(Keys.Right) && (Position.X + Size.X < Screen.Width))
            {
                Position.X += Speed; 
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, new Rectangle(Position.ToPoint(), Size.ToPoint()), Color.White);
        }

        public void Reset()
        {
            this.Position = originalPosition;
            this.Speed = originalSpeed;
        }
    }
}
