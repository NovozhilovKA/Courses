using System;
namespace BatlleShips.Game
{
    [Ship]
    public abstract class Ship
    {
        protected int hp;
        public abstract int numberOfShips{ get;}
        public Ship()
        {
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

        public abstract Ship Clone();
    }
}
