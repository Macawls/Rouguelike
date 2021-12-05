using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLike.Classes.Tiles;
using RogueLike.Classes.Tiles.Items;


namespace RogueLike.Characters
{
    class Leader : Enemy
    {
        private Tile target;

        public Tile Target 
        {
            get { return target; }
            set { target = value; }
        }


        public Leader(int x, int y) : base(x, y, 'L', 2, 20)
        {
            this.weapon = new Melee(Melee.WeaponTypes.LONGSWORD);
            this.purse = 2;
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.IDLE)
        {
            // variable for a move direction
            MovementEnum moveDirection = MovementEnum.IDLE;

            int xDist = this.X - target.X;
            int yDist = this.Y - target.Y;

            Random rnd = new Random();
            // 0 is horizontal
            // 1 is veritcal
            int direction = rnd.Next(0, 2);

            switch (direction)
            {
                //{ 0 = north, 1 = south, 2 = west, 3 = east } in VisionArray

                case 0:

                    if (yDist < -1) // neg
                    {
                        if (VisionArray[3].GetType() == typeof(EmptyTile) || VisionArray[3].GetType() == typeof(Gold))
                        {
                            moveDirection = MovementEnum.RIGHT;
                        }
                    }
                    else if (yDist > 1) //pos
                    {
                        if (VisionArray[2].GetType() == typeof(EmptyTile) || VisionArray[2].GetType() == typeof(Gold))
                        {
                            moveDirection = MovementEnum.LEFT;
                        }
                    }

                    else if (yDist == 1 || yDist == -1) //next to hero
                    {
                        moveDirection = MovementEnum.IDLE;
                        goto case 1;
                    }

                    else if (yDist == 0) // same collumn
                    {
                        goto case 1;
                    }

                    break;

                case 1:

                    if (xDist > -1)
                    {
                        if (VisionArray[0].GetType() == typeof(EmptyTile) || VisionArray[0].GetType() == typeof(Gold))
                        {
                            moveDirection = MovementEnum.UP;
                        }
                    }
                    else if (xDist < 1)
                    {
                        if (VisionArray[1].GetType() == typeof(EmptyTile) || VisionArray[1].GetType() == typeof(Item))
                        {
                            moveDirection = MovementEnum.DOWN;
                        }
                    }

                    else if (xDist == 1 || xDist == -1)
                    {
                        moveDirection = MovementEnum.IDLE;
                        goto case 0;      
                    }

                    else if (xDist == 0)
                    {
                        goto case 0;
                    }

                    break;

            }

            return moveDirection;


        }


    }
}
