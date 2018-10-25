using System;
namespace BullsNCows
{
    public class Bot
    {
        private string number;
        public Bot()
        {
            this.Reset();
        }

        public void Reset()
        {
            number = BotHelper.randomGuess().Number;
        }

        public bool Process(ref Guess guess)
        {
            if (guess.Number == number)
            {
                guess.Bulls = 4;
                guess.Cows = 4;
                return true;
            }
            else
            {
                guess.Bulls = 0;
                guess.Cows = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    if (guess.Number[i] == number[i])
                    {
                        guess.Bulls++;
                    }
                }
                for (int i = 0; i < number.Length; i++)
                {
                    if(number.Contains(guess.Number[i].ToString()))
                    {
                        guess.Cows++;
                    }
                }
                return false;
            }
        }
    }
}
