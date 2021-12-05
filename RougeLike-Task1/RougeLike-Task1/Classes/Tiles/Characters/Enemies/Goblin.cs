using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLike.Classes.Tiles;
using RogueLike.Classes.Tiles.Items;

namespace RogueLike.Characters
{
    class Goblin : Enemy
    {
        // Constructor
        public Goblin(int x, int y) : base(x, y, 'G', 1, 10)
        {
            this.weapon = new Melee(Melee.MeleeTypes.DAGGER);
            this.purse = 1;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            // variable for a move direction, returns idle if no movement in desired direction is possible
            MovementEnum moveDirection = MovementEnum.IDLE;

            switch (move)
            {
                case MovementEnum.UP:
                    if (VisionArray[0].GetType() == typeof(EmptyTile) || VisionArray[0].GetType() == typeof(Gold) || VisionArray[0].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[0].GetType() != typeof(Hero))
                        {
                            moveDirection = MovementEnum.UP;
                        }
                    }
                    break;

                case MovementEnum.DOWN:
                    if (VisionArray[1].GetType() == typeof(EmptyTile) || VisionArray[1].GetType() == typeof(Gold) || VisionArray[1].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[1].GetType() != typeof(Hero))
                        {
                            moveDirection = MovementEnum.DOWN;
                        }
                    }
                    break;

                case MovementEnum.LEFT:
                    if (VisionArray[2].GetType() == typeof(EmptyTile) || VisionArray[2].GetType() == typeof(Gold) || VisionArray[2].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[2].GetType() != typeof(Hero))
                        {
                            moveDirection = MovementEnum.LEFT;
                        }
                       
                    }
                    break;
                case MovementEnum.RIGHT:
                    if (VisionArray[3].GetType() == typeof(EmptyTile) || VisionArray[3].GetType() == typeof(Gold) || VisionArray[3].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[3].GetType() != typeof(Hero))
                        {
                            moveDirection = MovementEnum.RIGHT;
                        }
                        
                    }
                    break;
            }

            return moveDirection;
        }


    }
}
