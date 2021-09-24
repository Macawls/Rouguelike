using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Character_Subclasses
{
    abstract class Enemy : Character
    {
        protected int randnum;
        

        public Enemy(int x, int y, char symbol, int hp, int damage) : base(x, y, symbol, hp, damage)
        {


        }

        
    }
        
        
        
        
        
        
  

}
