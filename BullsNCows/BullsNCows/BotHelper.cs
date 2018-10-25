using System;
namespace BullsNCows
{
    public static class BotHelper
    {
        private static Random rand = new Random();
        public static bool ViableNum(string num)
        {
            string temp = "";
            int l = num.Length;
            for (int i = l - 1; i > 0; i--)
            {
                temp = num[i].ToString();
                num = num.Remove(i);
                if(num.Contains(temp))
                {
                    
                    return false;
                }
            }
            return true;
        }
        static public Guess randomGuess()
        {
            string num;
            do
            {
                num = rand.Next(1000, 10000).ToString();
            } while (!BotHelper.ViableNum(num));
            return new Guess(num);
        }
    }
}
