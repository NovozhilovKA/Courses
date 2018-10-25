using System;
namespace BullsNCows
{
    public static class PlayerChecker
    {
        public static bool ViableGuess(string guess)
        {
            if (guess.Length != 4)
            {
                return false;
            }
            try
            {
                Convert.ToInt32(guess);
            }
            catch(InvalidOperationException)
            {
                return false;
            }
            return BotHelper.ViableNum(guess);
        }
    }
}
