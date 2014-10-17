using System;

namespace GameRPG
{
#if WINDOWS || XBOX
    static class MainProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (GameWindow game = new GameWindow())
            {
                game.Run();
            }
        }
    }
#endif
}

