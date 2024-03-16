using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekBrickBreakerMonogame
{
    class Brick
    {
        public Vector2 Position;
        public Texture2D Image;
        public Vector2 Size;
        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Size.X, (int)Size.Y);
            }
        }

        public Brick(Vector2 position, Texture2D image, Vector2 size)
        {
            Position = position;
            Image = image;
            Size = size;
        }
        

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, new Rectangle(Position.ToPoint(), Size.ToPoint()), Color.White);
        }
    }
}
