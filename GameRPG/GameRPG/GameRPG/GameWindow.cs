namespace GameRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FuncWorks.XNA.XTiled;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class GameWindow : Microsoft.Xna.Framework.Game
    {
        private const int WindowWidth = 1024;
        private const int WindowHeight = 768;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle mapView;
        Map map;

        public GameWindow()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;

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
            mapView = graphics.GraphicsDevice.Viewport.Bounds;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            map = Content.Load<Map>("Map/world");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            KeyboardState keys = Keyboard.GetState();

            if (keys.IsKeyDown(Keys.Escape))
                this.Exit();

            Rectangle delta = mapView;
            if (keys.IsKeyDown(Keys.Down))
                delta.Y += Convert.ToInt32(gameTime.ElapsedGameTime.TotalMilliseconds / 4);
            if (keys.IsKeyDown(Keys.Up))
                delta.Y -= Convert.ToInt32(gameTime.ElapsedGameTime.TotalMilliseconds / 4);
            if (keys.IsKeyDown(Keys.Right))
                delta.X += Convert.ToInt32(gameTime.ElapsedGameTime.TotalMilliseconds / 4);
            if (keys.IsKeyDown(Keys.Left))
                delta.X -= Convert.ToInt32(gameTime.ElapsedGameTime.TotalMilliseconds / 4);

            if (map.Bounds.Contains(delta))
                mapView = delta;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            map.Draw(spriteBatch, mapView);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
