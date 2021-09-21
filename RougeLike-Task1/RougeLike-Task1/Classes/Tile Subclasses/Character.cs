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

        // used for movement, default is idle
        protected MovementState state;

        //Public Accessors
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }

        // Constructor 
        public Character() : base(default, default, default)
        {

        }

        // array for characters vision {0 = up, 1 = down,2 = left, 3 = right}
        Tile[] charVision = new Tile[4];

        //default is idle
        public enum MovementState
        {
            // Idle = no movement
            IDLE,
            UP,
            DOWN,
            LEFT,
            RIGHT,
        }

        
        
        
        
        // Methods

        // attacks a target and decreases its health by attack character's damage.
        public virtual void Attack(Character target)
        {

        }


        public bool IsDead()
        {
            return false;
        }

        // check if target is in range of a character
        // barehand range is 1
        // determine distance via DistanceTo() method
        public virtual bool CheckRange(Character target)
        {
            return false;
        }

        // diagonal is one up and one left or right = 2 steps
        private int DistanceTo(Character target)
        {
            return 0;
        }

        public void Move(MovementState move)
        {
            switch (state)
            {
                case MovementState.UP:
                    break;
                case MovementState.DOWN:
                    break;
                case MovementState.LEFT:
                    break;
                case MovementState.RIGHT:
                    break;
            }
        }

        public MovementState ReturnMove(MovementState move)
        {
          
        }

        public abstract override string ToString();





    }
}
