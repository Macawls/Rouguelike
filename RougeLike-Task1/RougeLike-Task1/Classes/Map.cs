using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Classes
{
    class Map
    {
        // variables for map width and height
        private int width;
        private int height;

        //amount of enemies
        private int enemyAmount;
        
        // Arrays
        // Ascii Map [rows, collums]
        private char[,] charMap;
        // Enemy object array
        Character_Subclasses.Enemy[] enemyArray;

        // Hero object
        Character_Subclasses.Hero hero = new Character_Subclasses.Hero(default, default, 'H', default, 2, default);


        // Constructor
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyAmount)
        {
            Random rnd = new Random();

            this.height = rnd.Next(minHeight, maxHeight + 1); // plus 1 because it rnd.Next returns max-1
            this.width = rnd.Next(minWidth, maxWidth + 1);
            this.enemyAmount = enemyAmount;

            charMap = new char[width, height];

            Character_Subclasses.Enemy[] enemyArray = new Character_Subclasses.Enemy[enemyAmount];

            
            FillMapBorder();
            // creating Tiles
            Create(Tile.TileType.HERO);
            
            for (int i = 0; i < enemyAmount; i++)
            {
                Create(Tile.TileType.ENEMY);
            }

        }

        // general logic to fill the map border with obstacle char 'X', although will be changed to Obstacle class later
        public void FillMapBorder() 
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; i < height; j++)
                {
                    // i == 0 is first row
                    // j == 0 is first collum
                    // i == width -1 is is last row
                    // j == height - 1 height is last collum

                    if (i == 0 || j == 0 || i == width - 1 || j == height - 1)
                    {
                        charMap[i, j] = 'X';
                    }

                }
            }
        }

        public void UpdateVision()
        {
            // update vision for each character(hero and enemy) //vision array is in tile class
            // setting it to empty tile THEN replacing objects with enemy afterwards
            // enum is up, down, left, right starting from 1


            hero.visionArray[0] = new EmptyTile(hero.getX - 1,default, default);    //up
            hero.visionArray[1] = new EmptyTile(hero.getX + 1, default, default);   //down
            hero.visionArray[2] = new EmptyTile(default, hero.getY - 1, default);   //left
            hero.visionArray[3] = new EmptyTile(default, hero.getY + 1, default);   //right
            
            for (int i = 0; i < enemyArray.Length; i++)
            {
                // putting enemies into Enemy Array, added 'enemyID' for differentiating enemies
                enemyArray[i] = new Character_Subclasses.Goblin(default, default, 'G', default, i + 1);
                
            }

            //typeof(Character_Subclasses.Goblin).GetProperty(string name)

            foreach (var goblin in enemyArray)
            {
                goblin.visionArray[0] = new EmptyTile(goblin.getX - 1, default, default);    //up
                goblin.visionArray[1] = new EmptyTile(goblin.getX + 1, default, default);   //down
                goblin.visionArray[2] = new EmptyTile(default, goblin.getY - 1, default);   //left
                goblin.visionArray[3] = new EmptyTile(default, goblin.getY + 1, default);   //right
            }
        }



        private Tile Create(Tile.TileType tileType)
        {

            int Randomizer(int maxValue) // min value is 1 because if its 0, the object will be placed on the border
            {
                Random rnd = new Random();
                int minValue = 1;

                return rnd.Next(minValue, maxValue);
            }

            // Hero = 0, Enemy = 1, Gold = 2, Weapon = 3

            switch (tileType)
            {
                case Tile.TileType.HERO: // Hero
                    Character_Subclasses.Hero hero = new Character_Subclasses.Hero(Randomizer(width), Randomizer(height), 'H', default, default, default);
                    return hero;

                case Tile.TileType.ENEMY: // Enemy

                    Character_Subclasses.Enemy enemy = new Character_Subclasses.Goblin(Randomizer(width), Randomizer(height), 'G', default, default);
                    return enemy;

                case Tile.TileType.GOLD: // Gold will go here
                    return null;

                case Tile.TileType.WEAPON: // MeleeWeapon will go here
                    return null;

                default: throw new ArgumentOutOfRangeException();
            }

            //random position for each enemy
            //foreach (var enemy in enemyArray)
            //{
            //    enemy.getX = Randomizer(width);
            //    enemy.getY = Randomizer(height);
            //}

            // checks if enemies are in the same position, if yes, then randomize cords again
            //for (int i = 0; i < enemyAmount; i++)
            //{
            //    while (enemyArray[i].getY == enemyArray[i+1].getY)
            //    {
            //        enemyArray[i].getY = Randomizer(height);
            //    }
            //    while (enemyArray[i].getX == enemyArray[i + 1].getX)
            //    {
            //        enemyArray[i].getX = Randomizer(width);
            //    }
            //}
        }
    }
}
