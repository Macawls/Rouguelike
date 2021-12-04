using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    // border map with obstacle tiles that no character can move past
    class Obstacle : Tile
    {
        // Constructor for subclass
        public Obstacle(int x, int y) : base(x, y, 'X')
        {

        }
    }
}
