using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Characters
{
    [Serializable]
    abstract class Enemy : Character
    {
        // random object 
        protected Random rnd = new Random();


        // Constructor 
        public Enemy(int x, int y, char symbol, int damage, int maxHP) : base(x, y, symbol, damage, maxHP)
        {
           
        }

        public override string ToString()
        {
            string equipState;
            bool isEquipped;
            
            if (this.weapon == null)
            {
                equipState = "Barehanded:";
                isEquipped = false;
            }

            else
            {
                equipState = "Equipped:";
                isEquipped = true;
            }
            
            if (isEquipped)
            {
                // Equipped: Leader (20/20HP) at [6, 1] with Longsword
                return $"{equipState} {this.GetType().Name}\n at [{this.x}, {this.y}] with {this.weapon.ToString()}\n({this.weapon.Durability * this.weapon.Damage})";
            }

            else
            {
                // Barehanded: Mage (5/5HP) at [6, 6] (5 DMG)
                return $"{equipState} {this.GetType().Name}\n at [{this.x}, {this.y}] ({this.damage} DMG)";
            }
        }
    }

}
