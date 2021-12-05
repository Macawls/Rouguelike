using RogueLike.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Tiles.Items
{
    class Shop
    {
        private Random rnd; // = new Random();

        public Weapon[] weaponsArray; //= new Weapon[3];

        public Character buyer;
  
        public Shop(Character hero)
        {
            buyer = hero;     
            weaponsArray = new Weapon[3];

            for (int i = 0; i < weaponsArray.Length; i++)
            {
                weaponsArray[i] = RandomWeapon();
            }  
        }

        private Weapon RandomWeapon()
        {
            rnd = new Random();
            int type = rnd.Next(0, 4);
            // 0 is melee
            // 1 is ranged
            switch (type)
            {
                case 0:
                    return new Melee(Melee.WeaponTypes.DAGGER);
                case 1:
                    return new Melee(Melee.WeaponTypes.LONGSWORD);
                case 2:
                    return new Ranged(Ranged.Types.RIFLE);
                case 3:
                    return new Ranged(Ranged.Types.LONGBOW);
                default:
                    return null;
            }
        }

        public bool CanBuy(int num)
        {
            if (buyer.Purse >= num)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Buy(int num)
        {
            buyer.Purse -= num;

            for (int i = 0; i < weaponsArray.Length; i++)
            {
                if (num == weaponsArray[i].Cost)
                {
                    buyer.PickUp(weaponsArray[i]);
                    weaponsArray[i] = RandomWeapon();
                    break;
                }
            }
        }

        public string DisplayWeapon(int num)
        {
            switch (num)
            {
                case 3:
                    return $"Buy Dagger for {num}";
                case 5:
                    return $"Buy Longsword for {num}";
                case 6:
                    return $"Buy Longbow for {num}";
                case 7:
                    return $"Buy Rifle for {num}";
                default:
                    return $"";
                
            }   
        }

        
    }



    
}
