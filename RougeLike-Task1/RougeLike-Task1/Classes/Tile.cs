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
        public GameForm gameForm = new GameForm();
        
        //Member Variables
        protected int x;
        protected int y;
        protected char symbol;

        // written in caps because they're constants 
        public enum TileType
        {
            HERO,
            ENEMY,
            GOLD,
            WEAPON, 
        }

        //Constructor
        public Tile(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        // Public Accessors
        public int getX { get; set; }
        public int getY { get; set; }
        public char getSymbol { get; set; }

    }
}
