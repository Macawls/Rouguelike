using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1
{
    // denote an empty tile
    class EmptyTile : Tile
    {
        // Constructor for subclass
        public EmptyTile() : base(int x,int y,char symbol)
        {
            this.x = x;

        }
    }
}
