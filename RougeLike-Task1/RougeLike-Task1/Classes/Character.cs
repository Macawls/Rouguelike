using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1
{
    abstract class Character : Tile
    {
        //Member Variables
        protected int hp;
        protected int maxHP;
        protected int damage;

        //Public Accessors
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }

        // Constructor for subclass
        public Character() : base(0, 0, default)
        {

        }

        // Array
        Tile[] charVision;

        public enum Movement
        {
            // Idle = no movement
            Idle,
            Down,
            Left,
            Right,
        }

        // Methods

        public virtual Attack(int yPos, int xPos)
        {


        }

        public bool IsDead()
        {

        }

        public virtual bool CheckRange()
        {

            return false;
        }

        private int DistanceTo()
        {

        }

        public void Move(Movement move)
        {

        }

        public Movement ReturnMove(Movement move)
        {
          
        }

        public abstract override string ToString();





    }
}
