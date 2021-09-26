using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Classes
{
    class Map
    {
        // [rows, collums]
        char[,] charMap;

        int width;
        int height;

        public void fillMapBorder()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; i < height; j++)
                {
                    // i == 0 is first row
                    // j == 0 is first collum
                    // i == width -1 is is last row
                    // j == height - 1 height is last collum
                    
                    if (i == 0 || j == 0 || i == width-1 || j == height -1)
                    {
                        charMap[i, j] = 'X';
                    }

                }
            }
        }


    }
}
