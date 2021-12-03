using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RougeLike_Task1.Classes.Tiles.Items;
using RougeLike_Task1.Classes.Tiles;



namespace RougeLike_Task1
{
    abstract class Character : Tile
    {
        //Member Variables
        protected int hp;
        protected int maxHP;
        protected int damage;
        protected int purse = 0;

        //Public Accessors
        public int Purse
        {
            get { return purse; }
            set { purse = value; }
        }
 
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int MaxHP
        {
            get { return maxHP; }
            set { maxHP = value; }
        }
        public int Damage 
        { 
            get { return damage; }
            set { damage = value; }
        }

        public Tile[] VisionArray
        {
            get { return visionArray; }
            set { visionArray = value; }
        }

        // array for characters vision {0 = north, 1 = south, 2 = west, 3 = east }
        private Tile[] visionArray = new Tile[4];


        //default is idle
        public enum MovementEnum
        {
            // IDLE = no movement
            IDLE,
            UP,
            DOWN,
            LEFT,
            RIGHT,
        }

        // Methods //

        // Constructor 
        public Character(int x, int y, char symbol, int damage, int maxHP) : base(x, y, symbol)
        {
            this.damage = damage;
            this.maxHP = maxHP;
            this.hp = maxHP;
        }

        public void PickUp(Gold item)
        {
            if (item.GetType() == typeof(Gold))
            {
                Random rnd = new Random();
                purse +=  rnd.Next(1, item.MaxGoldAmount + 1);
                item.PickedUp = true;
            }
        }

        public void PickUp(Weapon item)
        {

        }

        // attacks a target and decreases its health by attack character's damage
        public virtual void Attack(Character target)
        {
            target.HP -= this.damage;
        }

        // check if a character is dead
        public bool IsDead()
        {
            if (this.hp <= 0)
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
            bool canAttack;
            // barehand range
            if (DistanceTo(target) == 1)
            {
                canAttack = true;
            }

            else
            {
                canAttack = false;
            }

            return canAttack;
        }
        
        //overload for items
        public virtual bool CheckRange(Gold target)
        {
            bool canPickup;
            // barehand range
            if (DistanceToItem(target) == 1)
            {
                canPickup = true;
            }

            else
            {
                canPickup = false;
            }

            return canPickup;
        }

        public int DistanceTo(Character target) 
        {
            // subtract target x from the character x
            // convert that into a positive number for scalar (no direction)
            // do the same for y

            // add the two distances

            int calcDistance(int origin, int destination)
            {
                int distance = destination - origin;
                return Math.Abs(distance); //converts int to positive 
            }

            return calcDistance(this.x, target.x) + calcDistance(this.y, target.y);
        }

        // overload for items 
        public int DistanceToItem(Tile target)
        {
            int calcDistance(int origin, int destination)
            {
                int distance = destination - origin;
                return Math.Abs(distance); //converts int to positive 
            }
            return calcDistance(this.x, target.X) + calcDistance(this.y, target.Y);
        }




        public void Move(MovementEnum move)
        {
            
            switch (move)
            {
                case MovementEnum.IDLE:
                    break;
                case MovementEnum.UP:
                    this.x -= 1;
                    break;
                case MovementEnum.DOWN:
                    this.x += 1;
                    break;
                case MovementEnum.LEFT:
                    this.y -= 1;
                    break;
                case MovementEnum.RIGHT:
                    this.y += 1;
                    break;
            }
        }

        public abstract MovementEnum ReturnMove(MovementEnum move = MovementEnum.IDLE);
        // defined by character subclasses
        // return a direction based on how the character should move, 
        // based on the validity of the move against a char vision array

        public abstract override string ToString();
        // defined in char subclasses
    }
}
