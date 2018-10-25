using System;
namespace BullsNCows
{
    public class Player
    {
        public Player()
        {
            this.Reset();
        }

        public void Reset()
        {
                
        }

        public virtual void Guess(out Guess outGuess)
        {
            Console.WriteLine("Enter your guess");
            string guess;
            do
            {
                guess = Console.ReadLine();
            } while (!PlayerChecker.ViableGuess(guess));
            outGuess = new Guess(guess);
        }

        public bool Continue()
        {
            string temp;
            do
            {
                temp = Console.ReadLine();
                if (temp == "YES")
                {
                    return true;
                }
                else if (temp == "NO")
                {
                    return false;
                }
            } while (true);
        }
    }
}
