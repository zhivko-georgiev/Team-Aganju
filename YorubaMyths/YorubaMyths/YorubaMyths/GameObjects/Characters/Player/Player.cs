namespace YorubaMyths.GameObjects.Characters.Player
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using System;

    public class Player : PlayerCharacter
    {
        public Vector2 position = new Vector2(150,150);
        private float rotation = 0.0f;
        private string spriteName;
        private Texture2D spriteIndex;
        private float scale = 1.0f;

        //MouseState mousePosition;
        //MouseState prevMouse;

        KeyboardState keyboard;
        KeyboardState prevKeyboard;

        
        public Player(int currentHealthPoints, int maxHealthPoints, int movementSpeed, int defensePoints, int attackPoints)
            : base(currentHealthPoints, maxHealthPoints, movementSpeed, defensePoints, attackPoints)
        {

        }

        public virtual void LoadContent(ContentManager Content, string spriteName)
        {
            this.spriteName = spriteName; 
            spriteIndex = Content.Load<Texture2D>("Sprite\\" + spriteName);
        }

        public virtual void Update()
        {
            keyboard = Keyboard.GetState();
            float speed = 2f;

            if (keyboard.IsKeyDown(Keys.A))
            {
                position.X -= speed;
            }
            if (keyboard.IsKeyDown(Keys.D))
            {
                position.X += speed;
            }
            if (keyboard.IsKeyDown(Keys.W))
            {
                position.Y -= speed;
            }
            if (keyboard.IsKeyDown(Keys.S))
            {
                position.Y += speed;
            }
            prevKeyboard = keyboard;
            
           // this.rotation = point_direction(position.X, position.Y, mousePosition.X, mousePosition.Y);
            pushTo(this.MovementSpeed, this.rotation);
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
    }
}
