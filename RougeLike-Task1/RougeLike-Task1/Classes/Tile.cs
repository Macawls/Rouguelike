using RogueLike.Classes.Tiles.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    [Serializable]
    // Base Class
    abstract class Tile
    {
        //Member Variables
        protected int x;
        protected int y;
        protected char symbol;


        public enum TileType
        {
            HERO,
            ENEMY,
            GOLD,
            WEAPON,
            EMPTY,
            LEADER,
        }

        //Constructor
        public Tile(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        // Public Accessors
        public int X 
        {
            get { return x; } 
            set { x = value; } 
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool PickedUp
        {
            get;
            internal set;
        }

        public char getSymbol { get; set; }
    }
}
