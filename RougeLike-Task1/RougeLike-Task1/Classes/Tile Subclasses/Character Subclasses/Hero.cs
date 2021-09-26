using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Character_Subclasses
{
    class Hero : Character
    {

        public Hero(int x, int y, char symbol, int hp, int damage, int maxHP) : base(x, y, symbol, hp, 2, maxHP)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            // N.B Calling this method under the KeyPress event method in the Game Form

            // variable for a move direction, returns idle if no movement in desired direction is possible
            MovementEnum moveDirection = MovementEnum.IDLE;

            if (gameForm.keyUp)
            {
                if (visionArray[0].GetType().Name == "EmptyTile")
                {
                    moveDirection = MovementEnum.UP;
                }
                gameForm.keyUp = false;
            }

            else if (gameForm.keyDown)
            {
                if (visionArray[1].GetType().Name == "EmptyTile")
                {
                    moveDirection = MovementEnum.DOWN;
                }
                gameForm.keyDown = false;
            }

            else if (gameForm.keyLeft)
            {
                if (visionArray[2].GetType().Name == "EmptyTile")
                {
                    moveDirection = MovementEnum.LEFT;
                }
                gameForm.keyLeft = false;
            }

            else if (gameForm.keyRight)
            {
                if (visionArray[3].GetType().Name == "EmptyTile")
                {
                    moveDirection = MovementEnum.RIGHT;
                }
                gameForm.keyRight = false;
            }

            return moveDirection;
        }

        public override string ToString()
        {
            // Player Stats:
            // HP: HP/Max HP
            // Damage: 2
            // [X, Y]
            return $"Player Stats:\nHP: {this.hp}/{this.maxHP} \nDamage: {this.damage} \n[{this.x}, {this.y}]";
        }
    }
}
