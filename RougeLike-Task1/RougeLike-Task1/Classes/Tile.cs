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
        // Position
        protected int x;
        protected int y;

        // Symbol
        protected char symbol;

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
        }

        //Constructor
        public Tile(int xVal, int yVal, char posSymbol)
        {
            x = xVal;
            y = yVal;
            symbol = posSymbol;

        }

        // Public Accessors
        public int X { get; set; }
        public int Y { get; set; }
    }
}
