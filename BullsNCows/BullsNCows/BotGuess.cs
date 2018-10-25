using System;
using System.Collections;
using System.Text;
namespace BullsNCows
{
    public class BotGuess : Player
    {
        #region private fields
        private int position;
        private ArrayList arrayList = new ArrayList();
        private ArrayList numbers;
        #endregion
        #region properties
        public Guess PrevGuess { get; set; }
        public Guess CurrGuess { get; set; }
        public int NumOfGuesses { get; set; }
        #endregion
        public BotGuess()
        {
            CurrGuess = new Guess();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }
            NumOfGuesses = 0;
            position = 0;
        }
        public override void Guess(out Guess outGuess)
        {
            if (NumOfGuesses == 0)
            {
                outGuess = BotHelper.randomGuess();
                for (int i = 0; i < 10; i++)
                {
                    if (outGuess.Number.Contains(numbers[i].ToString()))
                    {
                        numbers.Remove(i);
                    }
                }
            }
            else
            {
                var newNumber = new StringBuilder("");
                for (int i = 0; i < 4; i++)
                {
                    if (i == position)
                    {
                        newNumber.Append(numbers[0]);
                    }
                    else
                    {
                        newNumber.Append(PrevGuess.Number[i]);
                    }

                }
                if (NumOfGuesses == 1)
                {
                    outGuess = new Guess(newNumber.ToString());
                }
                else
                {

                }
            }



        }
    }
}