using System;
namespace BullsNCows
{
    public class Guess
    {
        public Guess()
        {
            Number = "";
            Bulls = 0;
            Cows = 0;
        }
        public Guess(string Number)
        {
            this.Number = Number;
        }
        public string Number { get; set; }
        public int Bulls { get; set; }
        public int Cows { get; set; }
    }
}
