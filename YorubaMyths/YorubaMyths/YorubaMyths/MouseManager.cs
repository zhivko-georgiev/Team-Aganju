namespace YorubaMyths
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;

    public class MouseManager
    {
        // Fields
        private static MouseManager instance;
        private MouseState currentMouseState, previousMouseState;

        // Constructor for making the class singleton
        private MouseManager()
        {
        }

        static MouseManager()
        {
            MouseManager.instance = new MouseManager();
        }

        // Properties
        /// <summary>
        /// Access to the input manager
        /// </summary>
        public static MouseManager Instance
        {
            get { return MouseManager.instance; }
        }

        /// <summary>
        /// Get the current mouse position coordinates as a vector
        /// </summary>
        public Vector2 MousePosition
        {
            get { return new Vector2(currentMouseState.X, currentMouseState.Y); }
        }

        /// <summary>
        /// Get the rectangle at the current mouse position
        /// </summary>
        public Rectangle MouseRectangle
        {
            get { return new Rectangle(this.currentMouseState.X, this.currentMouseState.Y, 1, 1); }
        }

        // Methods
        /// <summary>
        /// Updates the mouse and keybord states
        /// </summary>
        public void Update()
        {
            this.previousMouseState = currentMouseState;
            this.currentMouseState = Mouse.GetState();
        }

        /// <summary>
        /// Checks if the left mouse button is pressed (up - down)
        /// </summary>
        public bool MouseLeftButtonPressed()
        {
            return this.previousMouseState.LeftButton == ButtonState.Released && this.currentMouseState.LeftButton == ButtonState.Pressed;
        }

        /// <summary>
        /// Checks if the left mouse button is pressed (down - up)
        /// </summary>
        public bool MouseLeftButtonPressedInverted()
        {
            return this.previousMouseState.LeftButton == ButtonState.Pressed && this.currentMouseState.LeftButton == ButtonState.Released;
        }

        /// <summary>
        /// Checks if the left mouse button is pressed
        /// </summary>
        public bool MouseLeftButtonDown()
        {
            return this.currentMouseState.LeftButton == ButtonState.Pressed;
        }

        /// <summary>
        /// Checks if the left mouse button is released
        /// </summary>
        public bool MouseLeftButtonUp()
        {
            return this.currentMouseState.LeftButton == ButtonState.Released;
        }
    }
}
