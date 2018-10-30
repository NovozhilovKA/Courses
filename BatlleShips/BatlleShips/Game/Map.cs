using System;
namespace BatlleShips.Game
{
    public class Map
    {
        private char [,] map;
        public Map()
        {
            map = new char[Constants.MAP_SIZE, Constants.MAP_SIZE];
            for (int i = 0; i < Constants.MAP_SIZE; i++)
            {
                for (int j = 0; j < Constants.MAP_SIZE; j++)
                {
                    map[i,j] = ' ';
                }
            }
        }

        public void SetShip(int x1, int y1, int x2, int y2)
        {   

            int len, start;
            if ((y2 - y1) == 0)
            {
                if (x2 > x1)
                {
                    start = x1;
                    len = x2 - x1;
                }
                else
                {
                    start = x2;
                    len = x1 - x2;
                }

                for (int i = start; i < start + len; i++)
                {
                    map[y1,i] = 'S';
                }
            }
            else
            {
                if (y2 > y1)
                {
                    start = y1;
                    len = y2 - y1;
                }
                else
                {
                    start = y2;
                    len = y1 - y2;
                }

                for (int i = start; i < start + len; i++)
                {
                    map[i, x1] = 'S';
                }
            }
        }

        public void SetMiss(Tuple<int,int> coords)
        {
            this.map[coords.Item1, coords.Item2] = '0';
        }

        public void SetHit(Tuple<int, int> coords)
        {
            this.map[coords.Item1, coords.Item2] = 'x';
        }

        public void Draw()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
