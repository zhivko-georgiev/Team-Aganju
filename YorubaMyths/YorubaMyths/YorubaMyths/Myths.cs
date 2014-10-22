namespace YorubaMyths
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using FuncWorks.XNA.XTiled;

    using YorubaMyths.GameObjects.Characters.Player;

    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Myths : Game
    {
        private const int WindowWidth = 1024;
        private const int WindowHeight = 768;
        float AspectRatio;
        Point OldWindowSize;
        Texture2D BlankTexture;
        RenderTarget2D OffScreenRenderTarget;

        Texture2D customCursor;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle mapView;
        Map map;
        static Player player = new Player(150, 200, 10, 50, 200);
        HUD hud = new HUD(player);

        public Myths()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;
            this.graphics.IsFullScreen = false;
            this.Window.AllowUserResizing = true;
            this.Window.ClientSizeChanged += new EventHandler<EventArgs>(Window_ClientSizeChanged);

            // For full screen
            //this.graphics.IsFullScreen = true;

            this.IsMouseVisible = false;
            Content.RootDirectory = "Content";
        }

        void Window_ClientSizeChanged(object sender, EventArgs e)
        {
            // Remove this event handler, so we don't call it when we change the window size in here
            Window.ClientSizeChanged -= new EventHandler<EventArgs>(Window_ClientSizeChanged);

            if (Window.ClientBounds.Width != OldWindowSize.X)
            { // We're changing the width
                // Set the new backbuffer size
                graphics.PreferredBackBufferWidth = Window.ClientBounds.Width;
                graphics.PreferredBackBufferHeight = (int)(Window.ClientBounds.Width / AspectRatio);
            }
            else if (Window.ClientBounds.Height != OldWindowSize.Y)
            { // we're changing the height
                // Set the new backbuffer size
                graphics.PreferredBackBufferWidth = (int)(Window.ClientBounds.Height * AspectRatio);
                graphics.PreferredBackBufferHeight = Window.ClientBounds.Height;
            }

            graphics.ApplyChanges();

            // Update the old window size with what it is currently
            OldWindowSize = new Point(Window.ClientBounds.Width, Window.ClientBounds.Height);

            // add this event handler back
            Window.ClientSizeChanged += new EventHandler<EventArgs>(Window_ClientSizeChanged);
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
            map = Content.Load<Map>("Level1/Level1");

            customCursor = Content.Load<Texture2D>("mouseCursor");
            AspectRatio = GraphicsDevice.Viewport.AspectRatio;
            OldWindowSize = new Point(Window.ClientBounds.Width, Window.ClientBounds.Height);

            BlankTexture = new Texture2D(GraphicsDevice, 1, 1);
            BlankTexture.SetData(new Color[] { Color.FromNonPremultiplied(255, 255, 255, 255) });
            spriteBatch = new SpriteBatch(GraphicsDevice);

            OffScreenRenderTarget = new RenderTarget2D(GraphicsDevice, Window.ClientBounds.Width, Window.ClientBounds.Height);
            hud.LoadContent(Content);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            if (OffScreenRenderTarget != null)
                OffScreenRenderTarget.Dispose();

            if (BlankTexture != null)
                BlankTexture.Dispose();

            if (spriteBatch != null)
                spriteBatch.Dispose();

            base.UnloadContent();
        }


        protected override bool BeginDraw()
        {
            GraphicsDevice.SetRenderTarget(OffScreenRenderTarget);
            return base.BeginDraw();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            /*if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);*/

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

            MouseManager.Instance.Update();
            
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
            spriteBatch.Draw(BlankTexture, new Rectangle(100, 100, 100, 100), Color.White);
            map.Draw(spriteBatch, mapView);
            hud.Draw(spriteBatch);
            spriteBatch.Draw(this.customCursor, MouseManager.Instance.MousePosition, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);



            // TODO: Add your drawing code here
            /*
                        GraphicsDevice.Clear(Color.CornflowerBlue);

                        spriteBatch.Begin();
                        map.Draw(spriteBatch, mapView);
                        spriteBatch.End();

                        base.Draw(gameTime);*/
        }

        protected override void EndDraw()
        {
            GraphicsDevice.SetRenderTarget(null);
            spriteBatch.Begin();
            spriteBatch.Draw(OffScreenRenderTarget, GraphicsDevice.Viewport.Bounds, Color.White);
            spriteBatch.End();
            base.EndDraw();
        }
    }
}
