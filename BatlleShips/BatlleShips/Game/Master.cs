using System;
using System.IO;
using BatlleShips.Game;
using BatlleShips.Game.Ships;
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
            for (int i = 0; i < Ship1.numberOfShips; i++)
            {
                Constants.STARTING_SHIPS.Add(new Ship1());
            }

            for (int i = 0; i < Ship2.numberOfShips; i++)
            {
                Constants.STARTING_SHIPS.Add(new Ship2());
            }

            for (int i = 0; i < Ship3.numberOfShips; i++)
            {
                Constants.STARTING_SHIPS.Add(new Ship3());
            }

            for (int i = 0; i < Ship4.numberOfShips; i++)
            {
                Constants.STARTING_SHIPS.Add(new Ship4());
            }

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
                }while(hit);
                Console.Clear();
                do
                {
                    Player2.DrawBoard();
                    shot = Player1.MakeAShot();
                    hit = Player2.Hit(shot);
                } while (hit);

            } while (!(Player1.Lose() || Player2.Lose()));
        }

        public void Reset()
        {
            
        }

    }
}
