using System;
namespace BatlleShips.Game.Ships
{
    public class Ship1:Ship
    {
        public const int numberOfShips = 4;
        const int startingHp = 1;
        public Ship1():base(startingHp)
        {
        }
    }
}
