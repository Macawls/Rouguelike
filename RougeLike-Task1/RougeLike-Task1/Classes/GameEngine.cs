using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RogueLike;
using RogueLike.Characters;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using RogueLike.Classes.Tiles.Items;
using System.Runtime.Serialization;

namespace RogueLike.Classes
{   
    [Serializable]
    class GameEngine
    {



        //chars
        private static readonly char heroTile = 'H';
        private static readonly char emptyTile = ' ';
        private static readonly char obstTile = 'X';
        private static readonly char goblinTile = 'G';
        private static readonly char mageTile = 'M';
        private static readonly char leaderTile = 'L';
        private static readonly char goldTile = '$';
        private static readonly char weaponTile = 'W';
        private static readonly char range = '•';

        private Map map;

        public Map Map
        { 
            get { return map; }
        }

        public GameEngine()
        {
            map = new Map(14, 16, 18, 21, 6, 8);
            
        }

        public override string ToString()
        {
            string stringMap = string.Empty;
            char[,] charMap = new char[map.Width, map.Height];

            for (int i = 0; i < map.Width; i++)
            {
                for (int j = 0; j < map.Height; j++)
                {
                    if (map.TileMap[i, j].GetType() == typeof(EmptyTile))
                    {
                        charMap[i, j] = emptyTile;
                    }

                    // show enemy ranges
                    // I really wish I knew how to do this better, all this hardcoding is sooooooooo bad
                    foreach (var enemy in map.enemyArray)
                    {
                        // normal range
                        //{ 0 = north, 1 = south, 2 = west, 3 = east }
                        charMap[enemy.VisionArray[0].X, enemy.VisionArray[0].Y] = range;
                        charMap[enemy.VisionArray[1].X, enemy.VisionArray[1].Y] = range;
                        charMap[enemy.VisionArray[2].X, enemy.VisionArray[2].Y] = range;
                        charMap[enemy.VisionArray[3].X, enemy.VisionArray[3].Y] = range;

                        // mage range
                        if (enemy.GetType() == typeof(Mage))
                        {
                            // top
                            charMap[enemy.VisionArray[0].X, enemy.VisionArray[0].Y + 1] = range; // top right
                            charMap[enemy.VisionArray[0].X, enemy.VisionArray[0].Y - 1] = range; // top left
                            // bottom
                            charMap[enemy.VisionArray[1].X, enemy.VisionArray[1].Y + 1] = range; // bottom left
                            charMap[enemy.VisionArray[1].X, enemy.VisionArray[1].Y - 1] = range; // bottom right
                        }

                    }

                    if (map.TileMap[i, j].GetType() == typeof(Obstacle))
                    {
                        charMap[i, j] = obstTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(Gold))
                    {
                        charMap[i, j] = goldTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(Ranged) || map.TileMap[i, j].GetType() == typeof(Melee))
                    {
                        charMap[i, j] = weaponTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(Hero))
                    {
                        charMap[i, j] = heroTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(Leader))
                    {
                        charMap[i, j] = leaderTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(Goblin))
                    {
                        charMap[i, j] = goblinTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(Mage))
                    {
                        charMap[i, j] = mageTile;
                    }



                    stringMap += charMap[i, j];
                }

                stringMap += "\n";
            }

            return $"{stringMap}";
        }
    }
}
