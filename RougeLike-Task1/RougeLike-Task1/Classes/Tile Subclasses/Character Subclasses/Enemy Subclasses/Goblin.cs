using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Character_Subclasses
{
    class Goblin : Enemy
    {
        // Constructor
        public Goblin(int x, int y, char symbol, int maxHP, int enemyID) : base(x, y, symbol, 10, 1, maxHP, enemyID)
        {
            // setting hp = 10 and dmg = 1 in constructor
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            //Bool to indicate if the player can move
            bool canMove = false;

            // variable for a valid direction // idle is returned if character cannot move anywhere
            MovementEnum validDirection = MovementEnum.IDLE;

            int RandomDirection()
            {
                Random rnd = new Random();
                return rnd.Next(1, 5); //return 1 to 4, int 0 is IDLE in enum
            }

            int i = RandomDirection();

            while (this.visionArray[i].GetType().Name != "EmptyTile") // while the tile is not empty, keep checking the rest of the tiles randomly(up, down, left, right)
            {
                i = RandomDirection();

                if (visionArray[i].GetType().Name == "EmptyTile") // if tile is empty than character can move
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
