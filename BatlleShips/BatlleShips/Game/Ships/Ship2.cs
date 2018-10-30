using System;
namespace BatlleShips.Game.Ships
{
    public class Ship2:Ship
    {
        public const int numberOfShips = 3;
        const int startingHp = 2;
        public Ship2():base(startingHp)
        {
        }
    }
}
