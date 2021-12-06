using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLike.Classes.Tiles.Items;
using RogueLike.Classes.Tiles;
using RogueLike.Characters;

namespace RogueLike
{
    [Serializable]
    abstract class Character : Tile
    {
        //Member Variables
        protected int hp;
        protected int maxHP;
        protected int damage;
        protected int purse = 0;

        protected Weapon weapon;

        public Weapon Weapon
        {
            get { return weapon; }
        }

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

        // overload for weapon
        public void PickUp(Weapon item)
        {
            if (item.GetType() == typeof(Weapon))
            {
                item.PickedUp = true;
            }
        }

        public void Equip(Weapon weapon)
        {
            this.weapon = weapon;
            
        }

        // attacks a target and decreases its health by attack character's damage
        public virtual void Attack(Character target)
        {
            // no weapon
            if (this.weapon == null)
            {
                target.HP -= this.damage;
            }
            
            // weapon
            else if (this.weapon != null)
            {
                target.HP -= this.weapon.Damage;
                this.weapon.Durability -= 1;

                if (this.weapon.Durability == 0)
                {
                    this.weapon = null;
                }

            }

            // Looting
            // Mages only pick up gold
            // rest of them dont

            if (this.GetType() == typeof(Mage) && target.IsDead())
            {
                this.purse += target.purse; //gold
            }

            else if (target.IsDead())
            {
                if (target.weapon != null) // if weapon exists, take it
                {
                    this.weapon = target.weapon;
                }

                this.purse += target.purse;
            }
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
            bool canAttack = false;

            // barehand range
            if (weapon == null)
            {
                if (DistanceTo(target) == 1 || DistanceTo(target) == 0)
                {
                    canAttack = true;
                }
            }

            else if (weapon.GetType() == typeof(Melee))
            {
                if (DistanceTo(target) == 1 || DistanceTo(target) == 0)
                {
                    canAttack = true;
                }
            }
            
            // ranged weapon ranges // barehand is melee range already so that doesnt matter
            else if (weapon.GetType() == typeof(Ranged))
            {
                // xx-xx
                // xx-xx    long bow
                // --C--
                // xx-xx
                // xx-xx
                
                //   xxx    mage
                //   xMx
                //   xxx
                
                // xxxxxxx
                // xxxxxxx  rifle
                // xxxxxxx
                // xxxCxxx
                // xxxxxxx
                // xxxxxxx
                // xxxxxxx

                bool checkDiags(Character weaponTarget, int range)
                {
                    // Really really hard to explain, basically my DistanceTo method only works for 
                    // up, down, left, right, i.E horizontally and verticaly, sooo in other words

                    // Basically we're cancelling out the stuff that we dont need through a bunch of if statements

                    // It isn't easy to read at all
                    // If I had more programing knowledge I would make a much much more modular and simpler solution
                    // but I really wanted the ranged weapons to feel like ranged weapons
                    // The mage class has the same logic, just simplified

                    bool isInRange = true;

                    // cant attack if the range is just outside horizontally and vertically only
                    if (Math.Abs(this.Y - weaponTarget.Y) == range + 1 || Math.Abs(this.X - weaponTarget.X) == range + 1)
                    {
                        isInRange = false;
                    }

                    return isInRange;
                }

                // This is how I differentiate weapons. 

                // if its a LongBow
                if (this.weapon.Range == 2)
                {
                    if (DistanceTo(target) <= 2)
                    {
                        canAttack = true;
                    }

                    else if (DistanceTo(target) == 3)
                    {
                        if (checkDiags(target, this.weapon.Range + 1))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }

                    else if (DistanceTo(target) == 4)
                    {
                        if (checkDiags(target, this.weapon.Range + 2))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }

                    else
                    {
                        canAttack = false;
                    }
                }

                // Rifle
                else if (this.weapon.Range == 3)
                {
                    if (DistanceTo(target) <= this.weapon.Range)
                    {
                        canAttack = true;
                    }

                    else if (DistanceTo(target) == 4)
                    {
                        if (checkDiags(target, this.weapon.Range + 1))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }

                    else if (DistanceTo(target) == 5)
                    {
                        if (checkDiags(target, this.weapon.Range + 2))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }

                    else if (DistanceTo(target) == 6)
                    {
                        if (checkDiags(target, this.weapon.Range + 3))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }
                }
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
