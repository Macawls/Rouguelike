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
            // variable for a move direction, returns idle if no movement in desired direction is possible
            MovementEnum moveDirection = MovementEnum.IDLE;

            switch (move)
            {
                case MovementEnum.UP:
                    if (VisionArray[0].GetType() == typeof(EmptyTile))
                    {
                        moveDirection = MovementEnum.UP;
                    }
                    break;
                case MovementEnum.DOWN:
                    if (VisionArray[1].GetType() == typeof(EmptyTile))
                    {
                        moveDirection = MovementEnum.DOWN;
                    }
                    break;
                case MovementEnum.LEFT:
                    if (VisionArray[2].GetType() == typeof(EmptyTile))
                    {
                        moveDirection = MovementEnum.LEFT;
                    }
                    break;
                case MovementEnum.RIGHT:
                    if (VisionArray[3].GetType() == typeof(EmptyTile))
                    {
                        moveDirection = MovementEnum.RIGHT;
                    }
                    break;
            }

            return moveDirection;
        }


    }
}
