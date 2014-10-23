namespace YorubaMyths.GameObjects.Characters.Player
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using FuncWorks.XNA.XTiled;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using System;

    public class Player : PlayerCharacter
    {
        public Vector2 position = new Vector2(150,150);
        private Vector2 newPosition = new Vector2(200, 150);
        private float rotation = 0.0f;
        private string spriteName;
        private Texture2D spriteIndex;

        private Rectangle mapView;
        private Rectangle playerBound = new Rectangle();
        private ObjectLayer collisionLayer;
        private float scale = 1.0f;
        private bool isMoving = false;

        //MouseState mousePosition;
        //MouseState prevMouse;

        KeyboardState keyboard;
        KeyboardState prevKeyboard;

        
        public Player(int currentHealthPoints, int maxHealthPoints, int movementSpeed, int defensePoints, int attackPoints)
            : base(currentHealthPoints, maxHealthPoints, movementSpeed, defensePoints, attackPoints)
        {

        }

        public virtual void LoadContent(ContentManager Content, string spriteName, Rectangle mapView, ObjectLayer collisionTileLayer)
        {
            this.spriteName = spriteName;
            this.mapView = mapView;
            this.collisionLayer = collisionTileLayer;
            spriteIndex = Content.Load<Texture2D>("Sprite\\" + spriteName);
            this.playerBound.Width = 16;
            this.playerBound.Height = 16;
        }

        public virtual void Update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();
            int speed = Convert.ToInt32(gameTime.ElapsedGameTime.TotalMilliseconds / 10);
            float mouseY = MouseManager.Instance.MousePosition.Y;
            float mouseX = MouseManager.Instance.MousePosition.X;

            if (MouseManager.Instance.MouseLeftButtonPressed())
            {
                this.newPosition.X = mouseX;
                this.newPosition.Y = mouseY;

                this.isMoving = true;
            }

            if (this.isMoving)
            {
                if (keyboard.IsKeyDown(Keys.Down))
                {
                    this.newPosition.Y -= Convert.ToInt32(gameTime.ElapsedGameTime.TotalMilliseconds / 4);
                }
                if (keyboard.IsKeyDown(Keys.Up))
                {
                    this.newPosition.Y += Convert.ToInt32(gameTime.ElapsedGameTime.TotalMilliseconds / 4);
                }
                if (keyboard.IsKeyDown(Keys.Right))
                {   
                    this.newPosition.X -= Convert.ToInt32(gameTime.ElapsedGameTime.TotalMilliseconds / 4);
                }
                if (keyboard.IsKeyDown(Keys.Left))
                {
                    this.newPosition.X += Convert.ToInt32(gameTime.ElapsedGameTime.TotalMilliseconds / 4);
                }

                Vector2 direction = this.newPosition - this.position;
                direction.Normalize();
                
                if (Vector2.Distance(this.position, this.newPosition) < 1 || this.IsCollision(this.position + direction))
                {
                    this.isMoving = false;
                }
                else
                {
                    this.position += direction * speed;
                    this.playerBound.X = (int)this.position.X;
                    this.playerBound.Y = (int)this.position.Y;
                }
            }

           // this.rotation = point_direction(position.X, position.Y, mousePosition.X, mousePosition.Y);
           // pushTo(this.MovementSpeed, this.rotation);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            Vector2 center = new Vector2(spriteIndex.Width / 2, spriteIndex.Height / 2);
            spriteBatch.Draw(spriteIndex, position, null, Color.White, 
                MathHelper.ToRadians(rotation), center, scale, SpriteEffects.None, 0);
        }

        public void pushTo(float pix, float dir)
        {
            float newX = (float)Math.Cos(MathHelper.ToRadians(dir));
            float newY = (float)Math.Sin(MathHelper.ToRadians(dir));
            position.X += pix * (float)newX;
            position.Y += pix * (float)newY;
        }

        private float point_direction(float x, float y, float x1, float y1)
        {
            float diffX = x - x1;
            float diffY = y - y1;
            float tan = diffY / diffX;

            float result = MathHelper.ToDegrees((float)Math.Atan2(diffY, diffX));

            result = (result - 180) % 360;
            if (result < 0)
            {
                result += 360;
            }

            return result;
        }

        bool IsCollision(Vector2 pos)
        {
            // Initialization.
            bool isExist = false;

            // Verification.
            if (this.collisionLayer != null)
            {
                List<MapObject> collision = this.collisionLayer.MapObjects.Where(p => p.Name.Equals("collision", StringComparison.CurrentCultureIgnoreCase)).Select(p => p).ToList<MapObject>();

                // Wall Collosion.
                for (int i = 0; i < collision.Count; i++)
                {
                    // Wall Collosion.
                    Rectangle wallBound = Map.Translate(collision[i].Bounds, this.mapView);

                    // Setting player bounds.
                    Rectangle playerBound = new Rectangle(Convert.ToInt32(pos.X), Convert.ToInt32(pos.Y), this.playerBound.Width, this.playerBound.Height);

                    // Wall Collosion.
                    if (wallBound.Intersects(playerBound))
                    {
                        isExist = true;
                        return isExist;
                    }
                }
            }

            return isExist;
        }
    }
}
