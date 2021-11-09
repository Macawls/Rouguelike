﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Classes.Tiles
{
    abstract class Item : Tile 
    {
        public Item(int x, int y, char symbol): base(x, y, symbol)
        {

        }

        public abstract override string ToString();
    }
}