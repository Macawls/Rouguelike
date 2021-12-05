using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Tiles.Items
{
    abstract class Weapon : Item
    {
       protected int damage;
       protected int range;
       protected int durability;
       protected int cost;
       protected string weaponType;

        
        public virtual int Range
        {
            get { return range; }
            set { range = value; }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        public string WeaponType
        {
            get { return weaponType; }
            set { weaponType = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }


        public Weapon(int x = 0, int y = 0) : base (x, y , 'W')
        {

        }

        //public Weapon() : base(x: default, y: default, 'W')
        //{

        //}









    }
}
