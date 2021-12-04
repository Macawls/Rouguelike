﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Characters
{
    class Mage : Enemy
    {
        public Mage(int x, int y) : base(x, y, 'M', 5, 5)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move) //idle because mages don't move
        {
            return MovementEnum.IDLE;
        }

        public override bool CheckRange(Character target)
        {
            bool canAttack;

            bool checkDiagonal(Character mageTarget) 
            {
                bool isInRange = true; // mage range is all around it

                //checks if the distance between the mage's target and itself is 2(HORIZONTALLY AND VERTICALLY NOT DIAGONALLY)
                if (Math.Abs(this.Y - mageTarget.Y) == 2 || Math.Abs(this.X - mageTarget.X) == 2)
                {
                    isInRange = false;
                }          
                
                return isInRange;
            }
            
            if (DistanceTo(target) == 1) // I.E up, down, left, right is fine
            {
                canAttack = true;
            }

            else if (DistanceTo(target) == 2) // need to cancel out if distance is 2 horizontally or vertically
            {
                //check if distance is 2 horizontally and vertically
                if (checkDiagonal(target))
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


            return canAttack;
        }

    }
}
