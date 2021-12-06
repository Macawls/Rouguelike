﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Tiles.Items
{
    class Ranged : Weapon
    {
        public enum RangedTypes
        {
            RIFLE,
            LONGBOW,
        }

        public Ranged(RangedTypes types, int x = 0, int y = 0) :base(x, y)
        {
            switch (types)
            {
                case RangedTypes.RIFLE:
                    durability = 3;
                    range = 3;
                    damage = 5;
                    cost = 7;
                    weaponType = "Rifle";
                    break;
                case RangedTypes.LONGBOW:
                    durability = 3;
                    range = 2;
                    damage = 4;
                    cost = 6;
                    weaponType = "Longbow";
                    break;

            }
        }

        public override string ToString()
        {
            return $"{this.WeaponType}";
        }


    }
}
