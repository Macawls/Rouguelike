using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Characters
{
    class Goblin : Enemy
    {
        // Constructor
        public Goblin(int x, int y) : base(x, y, 'G', 1, 10)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            //Bool to indicate if the player can move
            bool canMove = false;

            // variable for a valid direction // idle is returned if character cannot move anywhere
            MovementEnum validDirection = MovementEnum.IDLE;

            int RandomDirection()
            {
                return this.rnd.Next(1, 5); //return 1 to 4, int 0 is IDLE in enum
            }

            int i = RandomDirection();

            while (this.VisionArray[i].GetType() != typeof(EmptyTile)) // while the tile is not empty, keep checking the rest of the tiles randomly(up, down, left, right)
            {
                i = RandomDirection();

                if (this.VisionArray[i].GetType() == typeof(EmptyTile)) // if tile is empty than character can move
                {
                    canMove = true;
                    break;
                }

                canMove = false; // can't move if none of the surrounding tiles are empty
                break;
            }

            if (canMove == true) 
            {
                validDirection = (MovementEnum)i; //casting int to enum
            }

            return validDirection;
        }


    }
}
