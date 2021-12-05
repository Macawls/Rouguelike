using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Tiles.Items
{
    class Melee : Weapon
    {
        public override int Range
        {
            get { return this.range; }
            set { this.range = 1; }     // range of melee is 1
        }

        public enum MeleeTypes
        {
            DAGGER,
            LONGSWORD,
        }
        // public Ranged(RangedTypes types, int x = 0, int y = 0) :base(x, y)
        public Melee(MeleeTypes types, int x = 0, int y = 0) :base(x, y)
        {
            switch (types)
            {
                case MeleeTypes.DAGGER:
                    
                    durability = 10;
                    damage = 3;
                    cost = 3;
                    weaponType = "Dagger";
                    break;

                case MeleeTypes.LONGSWORD:
                    
                    durability = 6;
                    damage = 4;
                    cost = 5;
                    weaponType = "Longsword";
                    break;

            }
        }


        public override string ToString()
        {
            return $"{this.WeaponType} at [{this.X}, {this.Y}]";
        }


    }
}
