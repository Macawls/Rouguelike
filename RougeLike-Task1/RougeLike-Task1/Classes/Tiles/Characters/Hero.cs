using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLike.Classes.Tiles;
using RogueLike.Classes.Tiles.Items;

namespace RogueLike.Characters
{
    [Serializable]
    class Hero : Character
    {
        public Hero(int x, int y) : base(x, y, 'H', 2, 50)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            // variable for a move direction, returns idle if no movement in desired direction is possible
            MovementEnum moveDirection = MovementEnum.IDLE;

            switch (move)
            {
                case MovementEnum.UP:
                    if (VisionArray[0].GetType() == typeof(EmptyTile) || VisionArray[0].GetType() == typeof(Gold) || VisionArray[0].GetType() == typeof(Melee) || VisionArray[0].GetType() == typeof(Ranged))
                    {
                        moveDirection = MovementEnum.UP;
                    }
                    break;
                case MovementEnum.DOWN:
                    if (VisionArray[1].GetType() == typeof(EmptyTile) || VisionArray[1].GetType() == typeof(Gold) || VisionArray[1].GetType() == typeof(Melee) || VisionArray[1].GetType() == typeof(Ranged))
                    {
                        moveDirection = MovementEnum.DOWN;
                    }
                    break;
                case MovementEnum.LEFT:
                    if (VisionArray[2].GetType() == typeof(EmptyTile) || VisionArray[2].GetType() == typeof(Gold) || VisionArray[2].GetType() == typeof(Melee) || VisionArray[2].GetType() == typeof(Ranged))
                    {
                        moveDirection = MovementEnum.LEFT;
                    }
                    break;
                case MovementEnum.RIGHT:
                    if (VisionArray[3].GetType() == typeof(EmptyTile) || VisionArray[3].GetType() == typeof(Gold) || VisionArray[3].GetType() == typeof(Melee) || VisionArray[3].GetType() == typeof(Ranged))
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
            // HP: 75/100
            // Current Weapon: Bare Hands 
            // Weapon Range: 1
            // Weapon Damage: 2
            // Gold: 
            // [X, Y]

            
            // no weapon
            if (this.weapon == null)
            {
                return $"Player Stats:\nHP: {this.hp}/{this.maxHP} \nCurrent Weapon: Bare Hands \nDamage: {this.damage} \nWeapon Range: 1 \nWeapon Damage: 2 \nGold: {this.purse}\n[{this.x}, {this.y}]";
            }
            
            // has weapon
            else if (this.weapon != null)
            {
                return $"Player Stats:\nHP: {this.hp}/{this.maxHP} \nCurrent Weapon: {this.weapon} \nDamage: {this.damage} \nWeapon Range: {this.weapon.Range} \nWeapon Damage: {this.weapon.Damage}\nWeapon Durability: {this.weapon.Durability} \nGold: {this.purse}\n[{this.x}, {this.y}]";
            }

            else
            {
                return $"error";
            }




            
        }
    }
}
