using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RougeLike_Task1;
using RougeLike_Task1.Characters;

namespace RougeLike_Task1.Classes
{
    class GameEngine
    {
        //chars
        private static readonly char heroTile = 'H';
        private static readonly char emptyTile = '.';
        private static readonly char obstTile = 'X';
        private static readonly char goblinTile = 'G';

        private Map map;

        public Map Map
        { 
            get { return map; }
        }
        
        public GameEngine()
        {
            map = new Map(9, 14, 9, 14, 5);
        }

        public override string ToString()
        {
            string stringMap = string.Empty;
            char[,] charMap = new char[map.Width, map.Height];

            for (int i = 0; i < map.Width; i++)
            {
                for (int j = 0; j < map.Height; j++)
                {
                    if (map.TileMap[i, j].GetType() == typeof(Obstacle))
                    {
                        charMap[i, j] = obstTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(EmptyTile))
                    {
                        charMap[i, j] = emptyTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(Hero))
                    {
                        charMap[i, j] = heroTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(Goblin))
                    {
                        charMap[i, j] = goblinTile;
                    }

                    stringMap += charMap[i, j];
                }

                stringMap += "\n";
            }

            return $"{stringMap}";
        }
    }
}
