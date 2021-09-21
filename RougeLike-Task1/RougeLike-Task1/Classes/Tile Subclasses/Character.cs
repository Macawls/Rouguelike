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
            // attacked character's hp = attacked character's hp - attacker's dmg
            this.hp = this.hp - target.damage;

        }

        // check if a character is dead
        public bool IsDead()
        {
            // if health is less than or equal to zero then

            if (hp <= 0)
            {
                return true;
            }
            
            else
            {
                return false;
            }
            
        }

        // check if target is in range of a character
        // barehand range is 1
        // determine distance via DistanceTo() method
        public virtual bool CheckRange(Character target)
        {
            // barehand range
            if (DistanceTo(target) == 1)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        private int DistanceTo(Character target) 
        {
            
            // 2D array [rows][collumns]
            // x=> rows // y=>collums

            // get the x the character
            // get the x of the of target
            // minus the target x from the character x
            // convert that into a positive number for scalar (no direction) for e.g 0-2 = -2 => 2
            // do the same for y

            // add the two distances

            int calcDistance(int origin, int destination)
            {
                int distance = destination - origin;
                return Math.Abs(distance); //converts int to positive 
            }

            return ( calcDistance(this.x, target.x) + calcDistance(this.y, target.y) );
        }

        public void Move(MovementState move)
        {
            switch (move)
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
