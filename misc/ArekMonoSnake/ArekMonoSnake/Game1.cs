using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace ArekMonoSnake
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle Screen;
        Snake snake;
        Random gen = new Random();
        Food food;
        Texture2D pixel;
        Texture2D LoseScreen;
        TimeSpan timer = TimeSpan.Zero;
        TimeSpan frameRate = TimeSpan.FromMilliseconds(100);

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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

            IsMouseVisible = true;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            pixel = new Texture2D(GraphicsDevice, 1, 1);
            pixel.SetData(new Color[] { Color.White });
            Screen = GraphicsDevice.Viewport.Bounds;
            food = new Food(new Vector2(gen.Next(0, Screen.Width - 20) / 20 * 20, gen.Next(0, Screen.Height - 20) / 20 * 20), new Vector2(20), pixel, Color.White);
            snake = new Snake(new Vector2(20, 20), Color.White, pixel);

            LoseScreen = Content.Load<Texture2D>("SnakeLoseScreen");
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
            KeyboardState ks = Keyboard.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //intersection between food and head code here

            // TODO: Add your update logic here
            if (!snake.isDead)
            {
                timer += gameTime.ElapsedGameTime;
                if (timer >= frameRate)
                {
                    timer = TimeSpan.Zero;
                    snake.Update(Screen);
                }
            }


            if (food.Hitbox.Intersects(snake.Head.Hitbox))
            {
                food.Jump(Screen);
                snake.addPiece();
            }

            if ((ks.IsKeyDown(Keys.R)) && snake.isDead)
            {
                snake.Restart();
                food.Restart(Screen);
                snake.isDead = false;
                
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            snake.Draw(spriteBatch);
            food.Draw(spriteBatch);

            if (snake.isDead)
            {
                spriteBatch.Draw(LoseScreen, new Rectangle(0, 0, 800, 450), Color.Red);
            }

            spriteBatch.End();
            //checking if dead
            base.Draw(gameTime);
        }
    }
}
