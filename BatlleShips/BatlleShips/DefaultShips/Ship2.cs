using System;
using BatlleShips.Game;

namespace DefaultShips
{
    public class Ship2:BatlleShips.Game.Ship
    {
        protected new int hp = 2;

        public override int numberOfShips => 3;

        public override Ship Clone()
        {
            return new Ship2();
        }
    }
}
