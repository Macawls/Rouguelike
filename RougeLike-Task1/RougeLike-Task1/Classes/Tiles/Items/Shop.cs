using RogueLike.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RogueLike.Classes.Tiles.Items.Melee;
using static RogueLike.Classes.Tiles.Items.Ranged;

namespace RogueLike.Classes.Tiles.Items
{
    class Shop
    {
        public enum TypesofShopWeapons
        {
            Melee,
            Ranged,
        }

        private Random rnd;

        private Weapon[] weaponsArray = new Weapon[3];

        private Character buyer;

        private readonly int amount = 3;

        private readonly int weaponVariations = Enum.GetNames(typeof(TypesofShopWeapons)).Length;

        public Weapon[] WeaponsArray 
        { 
            get { return weaponsArray; } 
            set { weaponsArray = value; }
        }


        public Shop(Character hero)
        {
            buyer = hero;     
            //weaponsArray = new Weapon[amount];

            for (int i = 0; i < weaponsArray.Length; i++)
            {
                weaponsArray[i] = RandomWeapon();

                // this is a workaround to the problem, its not actually random in this case
                // still getting the same issue, no idea how to fix it
               while (i != 0  && weaponsArray[i] == weaponsArray[i - 1])
               {
                        weaponsArray[i] = RandomWeapon();
               }

            }
        }

        public Weapon RandomWeapon()
        {
            // For some reason, this should work, but it doesn't for
            // both ways of writing this method
            // it gives me the same issue 

            // Please please please watch this video where I demonstrate the problem
            // https://youtu.be/msONzs5DKC0

            // This was the old implementation

            //////////////////////////////////////////////////////////////
            //  rnd = new Random();                                     //
            //  int type = rnd.Next(0, 4);                              //
            //  switch (type)                                           //
            //  {                                                       //
            //      case 0:                                             //
            //          return new Melee(Melee.WeaponTypes.DAGGER);     //
            //      case 1:                                             //
            //          return new Melee(Melee.WeaponTypes.LONGSWORD);  //
            //       case 2:                                            //
            //          return new Ranged(Ranged.Types.RIFLE);          //
            //      case 3:                                             //
            //          return new Ranged(Ranged.Types.LONGBOW);        //
            //      default:                                            //
            //          return null;                                    //
            //  }                                                       //
            //////////////////////////////////////////////////////////////
            Item weapon;

            switch (RandomWeaponType())
            {
                case TypesofShopWeapons.Melee:
                    //length of enum, random weapon type within enum
                    switch (rnd.Next(0, Enum.GetNames(typeof(MeleeTypes)).Length)) 
                    {
                        case (int)MeleeTypes.DAGGER: // 0           //casting
                            weapon = new Melee(MeleeTypes.DAGGER);
                            break;
                        
                        case (int)MeleeTypes.LONGSWORD: // 1
                            weapon = new Melee(MeleeTypes.LONGSWORD);
                            break;
                        
                        default:
                            weapon = null;
                            break;        
                    }
                        break;           
                case TypesofShopWeapons.Ranged:
                    switch (rnd.Next(0, Enum.GetNames(typeof(RangedTypes)).Length))
                    {
                        case (int)RangedTypes.RIFLE:
                            weapon = new Ranged(RangedTypes.RIFLE);
                            break;

                        case (int)RangedTypes.LONGBOW:
                            weapon = new Ranged(RangedTypes.LONGBOW);
                            break;

                        default:
                            weapon = null;
                            break;
                    }
                        break;
                default:
                    return null;
            }

            return (Weapon)weapon;

        }

        public TypesofShopWeapons RandomWeaponType()
        {
            rnd = new Random();
            int num = rnd.Next(0, weaponVariations);

            if (num == (int)TypesofShopWeapons.Melee)
            {
                return TypesofShopWeapons.Melee;
            }
            else if (num == (int)TypesofShopWeapons.Ranged)
            {
                return TypesofShopWeapons.Ranged;
            }
            else
            {
                return default;
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
                    buyer.Equip(weaponsArray[i]);
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
                    return $"Buy Dagger for {num}$";
                case 5:
                    return $"Buy Longsword for {num}$";
                case 6:
                    return $"Buy Longbow for {num}$";
                case 7:
                    return $"Buy Rifle for {num}$";
                default:
                    return $"";
                
            }   
        }

        
    }



    
}
