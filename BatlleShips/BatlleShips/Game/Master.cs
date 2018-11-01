using System;
using BatlleShips.Game;
namespace BatlleShips
{
    public class Master
    {
#region private fields
        private Player Player1;
        private Player Player2;
#endregion
        public Master()
        {
            Constants.InitShips();

            Player1 = new Player();
            Player2 = new Player();
            Player1.SetShips();
            Player2.SetShips();
        }

        public void Start()
        {
            Tuple<int, int> shot;
            bool hit = true;
            do
            {
                do
                {
                    Player1.DrawBoard();
                    shot = Player1.MakeAShot();
                    hit = Player2.Hit(shot);
                    if(hit)
                    {
                        Player1.SetHit(shot);
                    }
                    else
                    {
                        Player1.SetMiss(shot);
                    }
                }while(hit);
                Console.Clear();
                do
                {
                    Player2.DrawBoard();
                    shot = Player1.MakeAShot();
                    hit = Player2.Hit(shot);
                    if (hit)
                    {
                        Player2.SetHit(shot);
                    }
                    else
                    {
                        Player2.SetMiss(shot);
                    }
                } while (hit);

            } while (!(Player1.Lose() || Player2.Lose()));
        }

        public void Reset()
        {
            
        }

    }
}
