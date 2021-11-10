using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RougeLike_Task1;
using RougeLike_Task1.Characters;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RougeLike_Task1.Classes
{
    class DataSerializer
    {
        //https://youtu.be/WHKPcA_xvE0 accessed 10 November 2021
    }
    
    [Serializable]
    class GameEngine
    {
        // saving
        public DataSerializer dataSerializer = new DataSerializer();
        //chars
        private static readonly char heroTile = 'H';
        private static readonly char emptyTile = '.';
        private static readonly char obstTile = 'X';
        private static readonly char goblinTile = 'G';
        private static readonly char mageTile = 'M';
        private static readonly char goldTile = '$';
        private Map map;

        public void Save(object data, string filePath) // serialize
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }

        public object Load(string filePath) // deserialize
        {
            object obj = null;

            FileStream fileStream;
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = binaryFormatter.Deserialize(fileStream);
                fileStream.Close();
            }

            return obj;
        }


        public Map Map
        { 
            get { return map; }
        }
        
        public GameEngine()
        {
            map = new Map(9, 14, 9, 14, 5, 5);
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

                    if (map.TileMap[i, j].GetType() == typeof(Mage))
                    {
                        charMap[i, j] = mageTile;
                    }

                    if (map.TileMap[i, j].GetType() == typeof(Tiles.Items.Gold))
                    {
                        charMap[i, j] = goldTile;
                    }

                    stringMap += charMap[i, j];
                }

                stringMap += "\n";
            }

            return $"{stringMap}";
        }
    }
}
