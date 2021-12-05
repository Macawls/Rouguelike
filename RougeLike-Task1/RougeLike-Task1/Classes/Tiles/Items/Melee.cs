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

        public enum WeaponTypes
        {
            DAGGER,
            LONGSWORD,
        }

        public Melee(WeaponTypes types) :base()
        {
            switch (types)
            {
                case WeaponTypes.DAGGER:
                    
                    durability = 10;
                    damage = 3;
                    cost = 3;
                    weaponType = "Dagger";
                    break;

                case WeaponTypes.LONGSWORD:
                    
                    durability = 6;
                    damage = 4;
                    cost = 5;
                    weaponType = "Longsword";
                    break;

            }
        }


        public override string ToString()
        {
            return $"{this.WeaponType}";
        }


    }
}
