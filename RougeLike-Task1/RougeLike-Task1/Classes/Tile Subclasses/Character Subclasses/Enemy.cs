using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Character_Subclasses
{
    abstract class Enemy : Character
    {

        public int enemyID; // used to differentiate enemies
        
        // Constructor 
        public Enemy(int x, int y, char symbol, int hp, int damage, int maxHP,int objectNumber) : base(x, y, symbol, hp, damage, maxHP)
        {
            this.enemyID = objectNumber;
        }

        public override string ToString()
        {
            // EnemyClassName at [X, Y] (Amount DMG)
            return $"{this.GetType().Name} at [{this.x}, {this.y}] ({this.damage})";
        }


    }

}
