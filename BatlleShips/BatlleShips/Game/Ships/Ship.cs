using System;
namespace BatlleShips.Game
{
    public abstract class Ship
    {
        private int hp;
        public const int numberOfShips = 1;
        public Ship(int hp)
        {
            this.hp = hp;
        }
        public virtual void Hit()
        {
            hp--;
        }
        public virtual int GetHP()
        {
            return hp;
        }
        public virtual bool IsRuined()
        {
            return (hp == 0);
        }
    }
}
