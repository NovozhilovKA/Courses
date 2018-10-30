using System;
using System.Collections.Generic;

namespace BatlleShips.Game
{
    public class Player
    {
#region private fields
        private Map Enemy;
        private Map Self;
        private Dictionary<Tuple<int, int>, Ship> MapOfShips;
        private List<Ship> Ships;
        private List<Tuple<int, int>> Shots;
#endregion

#region public Properties
        public string Name { get; set; }
#endregion

#region private methods
        private bool EnterCoords(out int x, out int y)
        {
            x = -1;
            y = -1;
            string cin1 = Console.ReadLine();
            string cin2 = Console.ReadLine();
            return int.TryParse(cin1, out x) && int.TryParse(cin2, out y);
        }
#endregion

#region public methods
        public Player()
        {
            this.Reset();
        }

        public void Reset()
        {
            Ships = new List<Ship>(Constants.STARTING_SHIPS);
            Enemy = new Map();
            Self = new Map();
            MapOfShips = new Dictionary<Tuple<int, int>, Ship>();
            Shots = new List<Tuple<int, int>>();
        }

        public bool Lose()
        {
            return (!(Ships.Count == 0));
        }

        public Tuple<int, int> MakeAShot()
        {
            int x, y;
            Tuple<int, int> shot;
            do
            {
                while (!EnterCoords(out x, out y))
                {
                    Console.WriteLine("Incorrect Coordinates");
                }
                shot = new Tuple<int, int>(x, y);
            } while (!Shots.Contains(shot));
            Shots.Add(shot);
            return shot;
        }

        public bool Hit(Tuple<int, int> shot)
        {
            if (MapOfShips.ContainsKey(shot))
            {
                Self.SetHit(shot);
                MapOfShips[shot].Hit();
                if (MapOfShips[shot].IsRuined())
                {
                    Ships.Remove(MapOfShips[shot]);
                } 
                MapOfShips.Remove(shot);
                return true;
            }
            else
            {
                Self.SetMiss(shot);
                return false;
            }
        }

        public void SetShips()
        {
            bool shipSet = false;
            foreach(var ship in Ships)
            {
                Console.WriteLine(ship.GetType());
                int x1 = -1, y1 = -1, x2 = -1, y2 = -1;
                shipSet = false;
                while (!shipSet)
                {
                    while (!EnterCoords(out x1, out y1))
                    {
                        Console.WriteLine("Incorrect Coordinates");
                    }
                    while (!EnterCoords(out x2, out y2))
                    {
                        Console.WriteLine("Incorrect Coordinates");
                    }
                    if (((x2 - x1) == 0) || ((y2 - y1) == 0))
                    {
                        if ((((x2 - x1) == (ship.GetHP() - 1)) || ((y2 - y1) == (ship.GetHP() - 1))))
                        {
                            shipSet = true;
                        }
                    }
                }
                Self.SetShip(x1, y1, x2, y2);
            }
        }

        public void SetHit(Tuple<int,int> shot)
        {
            Enemy.SetHit(shot);
        }

        public void SetMiss(Tuple<int, int> shot)
        {
            Enemy.SetMiss(shot);
        }

        public void DrawBoard()
        {
            Self.Draw();
            Enemy.Draw();
        }
#endregion
    }
}
