using System;
namespace BullsNCows
{
    public static class Game
    {
        static private BotGuess player;
        static private Bot bot;
        static private Guess guess;
        static private bool win;
        public static void Start()
        {
            player = new BotGuess();
            bot = new Bot();
            Console.WriteLine("Starting game");
            while (Process())
            {
                Restart();
            }
            End();
        }

        private static bool Process()
        {
            do
            {
                player.Guess(out guess);
                win = bot.Process(ref guess);
                player.PrevGuess = player.CurrGuess;
                player.CurrGuess = guess;
                Console.WriteLine(string.Format("{0} bulls and {1} cows", guess.Bulls, guess.Cows));
            } while (!win);
            return player.Continue();
        }

        private static void Restart()
        {
            bot.Reset();
            player.Reset();
        }

        private static void End()
        {
            Console.WriteLine("Hope to see you again:)");
        }
    }
}
