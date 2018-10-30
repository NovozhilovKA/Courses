using System;
namespace BatlleShips.Game
{
    public class Map
    {
        public char [,] map;
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
        public void Draw()
        {
            
        }
    }
}
