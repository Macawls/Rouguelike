using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1
{
    abstract class Character : Tile
    {
        //Member Variables
        protected int hp;
        protected int maxHP;
        protected int damage;

        //Public Accessors
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }


        public Character() : base(0, 0)
        {

        }


    }
}
