using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Characters
{
    class Hero : Character
    {
        public Hero(int x, int y) : base(x, y, 'H', 2, 10)
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
                default:
                    moveDirection = MovementEnum.IDLE;
                    break;
            }

            return moveDirection;
        }

        public override string ToString()
        {
            // Player Stats:
            // HP: HP/Max HP
            // Damage: 2
            // Gold:
            // [X, Y]
            return $"Player Stats:\nHP: {this.hp}/{this.maxHP} \nDamage: {this.damage} \nGold: {this.purse}\n[{this.x}, {this.y}]";
        }
    }
}
