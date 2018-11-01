using System;
using BatlleShips.Game;

namespace DefaultShips
{
    public class Ship1: BatlleShips.Game.Ship
    {
        protected int hp = 1;

        public override int numberOfShips => 4;

        public override Ship Clone()
        {
            return new Ship1();
        }
    }
}
