using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Characters
{
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
            // EnemyClassName at [X, Y] (Amount DMG)
            return $"{this.GetType().Name} at [{this.x}, {this.y}]\nDamage: {this.damage}";
        }
    }

}
