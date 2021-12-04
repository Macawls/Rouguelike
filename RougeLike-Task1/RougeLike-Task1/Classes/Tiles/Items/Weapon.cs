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

        protected int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        protected int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        protected string WeaponType
        {
            get { return weaponType; }
            set { weaponType = value; }
        }

        public Weapon() : base (x: default, y: default, 'W')
        {

        }









    }
}
