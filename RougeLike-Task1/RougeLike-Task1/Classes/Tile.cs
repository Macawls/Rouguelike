using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1
{
    // Base Class
    abstract class Tile
    {
        //Member Variables
        protected int x;
        protected int y;

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
        }

        //Constructor
        public Tile(int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
        }

        // Public Accessors
        public int X { get; set; }
        public int Y { get; set; }
    }
}
