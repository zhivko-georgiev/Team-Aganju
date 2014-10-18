using System;

namespace YorubaMyths
{
#if WINDOWS || XBOX
    static class YorubaMythsGame
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Myths game = new Myths())
            {
                game.Run();
            }
        }
    }
#endif
}

