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
        }

        public bool Lose()
        {
            return (!(Ships.Count == 0));
        }

        public Tuple<int, int> MakeAShot()
        {
            int x, y;
            while (!EnterCoords(out x, out y))
            {
                Console.WriteLine("Incorrect Coordinates");
            }
            return new Tuple<int, int>(x, y);
        }

        public bool Hit(Tuple<int, int> shot)
        {
            if (MapOfShips.ContainsKey(shot))
            {
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
                return false;
            }
        }

        public void SetShips()
        {
            bool shipSet = false;
            foreach(var ship in Ships)
            {
                int x1, y1, x2, y2;
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
                        if ((((x2 - x1) == 0) || ((y2 - y1) == 0)))
                        {
                            shipSet = true;
                        }
                    }
                }
            }
        }

        public void DrawBoard()
        {
            Self.Draw();
            Enemy.Draw();
        }
#endregion
    }
}
