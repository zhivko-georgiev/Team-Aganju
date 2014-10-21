namespace YorubaMyths
{
    using System.Net.Mime;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    using YorubaMyths.GameObjects.Characters.Player;

    public class HUD
    {

        private int playerCurrentHealth;
        private int playerMaxHealth;

        private int screenWidth;

        private int screenHeight;

        private SpriteFont playerHealthFont;

        private Vector2 playerHealthPos;

        private bool showHud;

        public HUD(Player player)
        {
            this.playerCurrentHealth = player.CurrentHealthPoints;
            this.playerMaxHealth = player.MaxHealthPoints;
            this.showHud = true;
            this.screenWidth = 1024;
            this.screenHeight = 768;
            this.playerHealthFont = null;
            this.playerHealthPos = new Vector2(this.screenWidth / this.screenWidth + 10, 10f);
        }

        public void LoadContent(ContentManager Content)
        {
            playerHealthFont = Content.Load<SpriteFont>("georgia");
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (this.showHud)
            {
                spriteBatch.DrawString(this.playerHealthFont, "Health: " + 
                    this.playerCurrentHealth + "/" + this.playerMaxHealth, playerHealthPos, new Color(255, 0, 0));
            }
        }
    }
}
