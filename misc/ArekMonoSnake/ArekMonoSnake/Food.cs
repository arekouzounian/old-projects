using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekMonoSnake
{
    class Food
    {
        public Vector2 Position;
        public Vector2 Size;
        public Random RandomPos = new Random();
        public Texture2D Image;
        public Color Color;
        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Size.X, (int)Size.Y);
            }
        }
        public Food(Vector2 position, Vector2 size, Texture2D image, Color color)
        {
            Position = position;
            Size = size;
            Image = image;
            Color = color;
        }

        public void Jump(Rectangle Screen)
        {
            Position.X = RandomPos.Next(0, Screen.Width-20) / 20 * 20;
            Position.Y = RandomPos.Next(0, Screen.Height-20) / 20 * 20;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, new Rectangle(Position.ToPoint(), Size.ToPoint()), Color.Red);
        }

        public void Restart(Rectangle Screen)
        {
            Jump(Screen);
        }
    }
}
