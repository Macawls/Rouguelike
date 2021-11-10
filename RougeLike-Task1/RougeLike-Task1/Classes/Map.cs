using RougeLike_Task1.Classes.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike_Task1.Classes
{
    class Map
    {
        //obj for randomizing enemy
        Random rnd = new Random();
        
        // map width and height
        private int mapWidth;
        private int mapHeight;

        //amount of enemies
        private int enemyAmount;

        public Tile[,] gameMap;
        public Characters.Enemy[] enemyArray;
        public Tiles.Item[] itemArray;

        private Characters.Hero hero;

        public Characters.Hero Hero
        {
            get { return hero; }
            set { hero = value;}
        }

        public int EnemyAmount
        {
            get { return enemyAmount; }
            set { enemyAmount = value; }
        }

        public int Width
        {
            get { return mapWidth;  }
            set { mapWidth = value; }
        }

        public int Height
        {
            get { return mapHeight;  }
            set { mapHeight = value; }
        }
        
        
        public Tile[,] TileMap
        {
            get { return gameMap; }
            set { gameMap = value; }
        }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyAmount, int maxGoldDrops)
        {
            Random rnd = new Random();
           
            // +1 1 because 'maxValue' in rnd.Next is max - 1
            mapHeight = rnd.Next(minHeight, maxHeight + 1); 
            mapWidth = rnd.Next(minWidth, maxWidth + 1);
            this.enemyAmount = enemyAmount;

            gameMap = new Tile[mapWidth, mapHeight];
            enemyArray = new Characters.Enemy[enemyAmount];
            
            //amount of gold drops used as initial size of items array
            itemArray = new Tiles.Item[maxGoldDrops]; 

            FillMap();
            
            // Hero
            Hero = (Characters.Hero)Create(Tile.TileType.HERO);
            gameMap[Hero.X, Hero.Y] = Hero;

            // Enemies (randomizes in create function
            for (int i = 0; i < enemyArray.Length; i++)
            {
                enemyArray[i] = (Characters.Enemy)Create(Tile.TileType.ENEMY);
                gameMap[enemyArray[i].X, enemyArray[i].Y] = enemyArray[i];
            }

            // Items
            for (int i = 0; i < itemArray.Length; i++) // for the each element in the item array
            {
                // creates a gold tile at a random index between the start and end of the array i.e max gold drops.
                // If it already exists in the itemArray at that index, it will be replaced at that specific 
                // index, so therefore, its random. Create() will check if the space is open
                itemArray[rnd.Next(0, maxGoldDrops)] = (Tiles.Item)Create(Tile.TileType.GOLD);

                itemArray = itemArray.Where((source, index) => index != i).ToArray(); //if the element is null, its removed

                gameMap[itemArray[i].X, itemArray[i].Y] = itemArray[i];
            }


            // updating vision
            UpdateVision();  
        }

        public void UpdateMap()
        {
            FillMap();
            gameMap[Hero.X, Hero.Y] = Hero;

            //checks if enemies are dead
            for (int i = 0; i < enemyArray.Length; i++) 
            {
                if (enemyArray[i].HP <= 0)
                {
                    //makes new array WITHOUT dead enemies
                    enemyArray = enemyArray.Where((source, index) => index != i).ToArray();
                    // https://stackoverflow.com/questions/457453/remove-element-of-a-regular-array/25794168
                    // accessed 08 November 2021
                }
            }
            
            //fills array with enemies
            for (int i = 0; i < enemyArray.Length; i++)
            {
                gameMap[enemyArray[i].X, enemyArray[i].Y] = enemyArray[i];
            }

            // Item array
            for (int i = 0; i < itemArray.Length; i++)
            {
                gameMap[itemArray[i].X, itemArray[i].Y] = itemArray[i];
            }


            UpdateVision();

        }

        public void FillMap()
        {
            // entire 2d map is filled with empty tiles first
            for (int i = 0; i < gameMap.GetLength(0); i++)
            {
                for (int j = 0; j < gameMap.GetLength(1); j++)
                {
                    gameMap[i, j] = new EmptyTile(i, j, '.');
                }
            }

            // next, it fills border of the 2d map array with obstacles
            for (int i = 0; i < gameMap.GetLength(0); i++)
            {
                for (int j = 0; j < gameMap.GetLength(1); j++)
                {
                    // i == 0 first row
                    // j == 0 first collum
                    // width -1 is last row
                    // height -1 is last collum 
                    if (i == 0 || j == 0 || i == mapWidth - 1 || j == mapHeight - 1)
                    {
                        gameMap[i, j] = new Obstacle(i, j);
                    }
                }
            }
        }


        // not setting the element in the array to null and not returning a tile, it would break my logic.
        // reason why is because the map needs to be filled at all times
        // Instead going to make a new item array for the same effect
        public void GetItem(int x, int y) 
        {
            for (int i = 0; i < itemArray.Length; i++)
            {
                if (x == itemArray[i].X && y == itemArray[i].Y)
                {
                    Hero.PickUp(itemArray[i]); //picks up item
                    itemArray = itemArray.Where((source, index) => index != i).ToArray(); // new array with removed item    
                }
            }
        }

        public Tile Create(Tile.TileType charType)
        {
            Random rnd = new Random();
            int randomX;
            int randomY;
           
            bool isOpenTile(int x, int y)
            {
                if (gameMap[x, y].GetType() != typeof(EmptyTile))
                {
                    return true;
                }

                else
                {
                    return false;
                }
                
            }

            switch (charType)
            {
                case Tile.TileType.HERO:
                    do
                    {
                        randomX = rnd.Next(1, gameMap.GetLength(0));
                        randomY = rnd.Next(1, gameMap.GetLength(1));

                    } while (isOpenTile(randomX, randomY));
                    
                    return new Characters.Hero(randomX, randomY);
                
                case Tile.TileType.ENEMY:
                    // Note: more enemies in future
                    do
                    {
                        randomX = rnd.Next(1, gameMap.GetLength(0));
                        randomY = rnd.Next(1, gameMap.GetLength(1));

                    } while (isOpenTile(randomX, randomY));

                    // random enemy type
                    int indicator = rnd.Next(0, 2);
                    switch (indicator)
                    {
                        case 0:
                            return new Characters.Goblin(randomX, randomY);
                        case 1:
                            return new Characters.Mage(randomX, randomY);
                        default:
                            return null;
                    }
                case Tile.TileType.GOLD: 
                    do
                    {
                        randomX = rnd.Next(1, gameMap.GetLength(0));
                        randomY = rnd.Next(1, gameMap.GetLength(1));

                    } while (isOpenTile(randomX, randomY));

                    return new Tiles.Items.Gold(randomX, randomY);

                default: // default is an empty tile
                    do
                    {
                        randomX = rnd.Next(1, gameMap.GetLength(0));
                        randomY = rnd.Next(1, gameMap.GetLength(1));

                    } while (isOpenTile(randomX, randomY));

                    return new EmptyTile(randomX, randomY, '.');
            }
        }


        public void UpdateVision()
        {
            //Array.Clear(hero.VisionArray, 0, hero.VisionArray.Length);
            
            // up
            hero.VisionArray[0] = gameMap[hero.X - 1, hero.Y];
            // down
            hero.VisionArray[1] = gameMap[hero.X + 1, hero.Y];
            //left
            hero.VisionArray[2] = gameMap[hero.X, hero.Y - 1];
            //right
            hero.VisionArray[3] = gameMap[hero.X, hero.Y + 1];

            foreach (Characters.Enemy enemy in enemyArray)
            {
                //Array.Clear(enemy.VisionArray, 0, enemy.VisionArray.Length);
                
                // up
                enemy.VisionArray[0] = gameMap[enemy.X - 1, enemy.Y];
                // down
                enemy.VisionArray[1] = gameMap[enemy.X + 1, enemy.Y];
                //left
                enemy.VisionArray[2] = gameMap[enemy.X, enemy.Y - 1];
                //right
                enemy.VisionArray[3] = gameMap[enemy.X, enemy.Y + 1];

            }

        }
    }
}
