using System;
namespace BatlleShips.Game.Ships
{
    public class Ship3:Ship
    {
        public const int numberOfShips = 2;
        const int startingHp = 3;
        public Ship3():base(startingHp)
        {
        }
    }
}
