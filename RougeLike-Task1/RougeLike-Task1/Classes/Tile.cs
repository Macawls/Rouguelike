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
        protected char symbol;

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon, 
        }

        //Constructor
        public Tile(int xPos, int yPos)
        {
            this.x = xPos;
            this.y = yPos;
        }

        // Public Accessors
        public int getX { get; set; }
        public int getY { get; set; }
        public char getSymbol { get; set; } 

    }
}
