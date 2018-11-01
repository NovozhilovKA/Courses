using System;
using BatlleShips.Game;
namespace Ship1
{
    [Ship]
    public class Ship1:Ship
    {
        protected new int hp = 1;
        public Ship1()
        {
        }

        public override int numberOfShips { get; } = 1;

        public override Ship Clone()
        {
            return new Ship1();
        }
    }
}
