using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace ArekBrickBreakerMonogame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle Screen;
        Ball ball;
        Paddle paddle;
        List<Brick> bricks = new List<Brick>();
        SpriteFont deadFont;
        SpriteFont livesFont;
        bool createBricks = true; 
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 1600;
            graphics.PreferredBackBufferHeight = 900;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

        }
        //int paddlePos = -Math.Abs(Screen.Height);
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            deadFont = Content.Load<SpriteFont>("font");
            livesFont = Content.Load<SpriteFont>("lives");
            Screen = GraphicsDevice.Viewport.Bounds;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ball = new Ball(new Vector2(Screen.Width / 2 - 130, Screen.Height - 260), Content.Load<Texture2D>("cookie"), new Vector2(6, 6), new Vector2(100, 100));
            paddle = new Paddle(new Vector2(Screen.Width / 2 - 115, Screen.Height - 50), 10, Content.Load<Texture2D>("pongsprite2"), new Vector2(230, 40));


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.L))
            {
                for (int i = 0; i < bricks.Count; i++)
                {
                    bricks.RemoveAt(i);
                }
            }

            // TODO: Add your update logic here
            //collision
            ball.Update(Screen);
            paddle.Update(Screen);
            if (ball.Hitbox.Intersects(paddle.Hitbox))
            {
                ball.Speed.Y = -Math.Abs(ball.Speed.Y);
            }

            //collision cont
            for (int i = 0; i < bricks.Count; i++)
            {
                if (ball.Hitbox.Intersects(bricks[i].Hitbox))
                {
                    bricks.RemoveAt(i);
                    ball.Speed.Y = Math.Abs(ball.Speed.Y);
                    break;
                }
            }
            //restarting game
            if (((Keyboard.GetState().IsKeyDown(Keys.R)) && ball.isDead) || ((Keyboard.GetState().IsKeyDown(Keys.R))  && bricks.Count == 0))
            {
                createBricks = true;
                ball.Reset();
                paddle.Reset();
                ball.lives = 3;
            }

            //printing bricks
            if (createBricks)
            {
                ball.isDead = false;
                int dy = 0;
                for (int j = 0; j < 5; j++)
                {
                    int dx = 0;
                    for (int i = 0; i < 14; i++)
                    {
                        bricks.Add(new Brick(new Vector2(dx + 20, dy + 15), Content.Load<Texture2D>("bricktexture"), new Vector2(100, 80)));
                        dx += 100 + 12;
                    }
                    dy += 80 + 10;
                }
                createBricks = false;
            }

            //winning code 
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            ball.Draw(spriteBatch);
            paddle.Draw(spriteBatch);
            for (int i = 0; i < bricks.Count; i++)
            {
                bricks[i].Draw(spriteBatch);
            }
            //losing
            if (ball.isDead == true)
            {
                ball.Speed = new Vector2(0, 0);
                spriteBatch.DrawString(deadFont, "You Died!", new Vector2(Screen.Width/2 - 175, Screen.Height/2 - 300), Color.Black);
                spriteBatch.DrawString(deadFont, "Press 'R' to Restart or ESC to exit.", new Vector2(Screen.Width/2 - 650, Screen.Height/2 - 50), Color.Black);
                bricks.Clear();
            }
            else
            {
                spriteBatch.DrawString(livesFont, $"lives: {ball.lives}", new Vector2(Screen.Width - 100, Screen.Height - 100), Color.Black);
            }
            //winning
            if ((bricks.Count == 0) && (ball.lives > 0))
            {
                ball.Speed = new Vector2(0, 0);
                spriteBatch.DrawString(deadFont, "You Win!", new Vector2(Screen.Width / 2 - 175, Screen.Height / 2 - 300), Color.Black);
                spriteBatch.DrawString(deadFont, "Press 'R' to Restart or ESC to exit.", new Vector2(Screen.Width / 2 - 650, Screen.Height / 2 - 50), Color.Black);
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
