using RougeLike_Task1.Classes.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RougeLike_Task1.Classes.Tiles.Items;

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
        public Tile[] itemArray;

        private Characters.Hero hero;
        private Characters.Leader leader;

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
            itemArray = new Tile[maxGoldDrops]; 

            FillMap();
            
            // Hero
            Hero = (Characters.Hero)Create(Tile.TileType.HERO);
            gameMap[Hero.X, Hero.Y] = Hero;

            // Enemies (randomizes in create function), only one leader
            for (int i = 0; i < enemyArray.Length; i++)
            {
                enemyArray[i] = (Characters.Enemy)Create(Tile.TileType.ENEMY);
                gameMap[enemyArray[i].X, enemyArray[i].Y] = enemyArray[i];
            }

            // Creating Leader
            leader = (Characters.Leader)Create(Tile.TileType.LEADER);
            int leaderIndex = rnd.Next(0, enemyArray.Length); 
            enemyArray[leaderIndex] = leader; //replace random enemy with leader

            gameMap[leader.X, leader.Y] = leader;
            
            //set target of leader
            leader.Target = Hero;


            // Items
            for (int i = 0; i < maxGoldDrops; i++) // maxGoldDrops = itemArray.Length
            {
                itemArray[i] = (Tiles.Item)Create(Tile.TileType.GOLD);
                gameMap[itemArray[i].X, itemArray[i].Y] = itemArray[i];
            }

            for (int i = 0; i < itemArray.Length; i++)
            {
                itemArray[i].PickedUp = false;
            }


            // updating vision
            UpdateVision();  
        }

        public void MoveEnemies()
        {
            Random num = new Random();
            int directionIndicator;

            for (int i = 0; i < enemyArray.Length; i++)
            {
                if (enemyArray[i].GetType() != typeof(Characters.Leader))
                {
                    directionIndicator = num.Next(0, 5); // 0 is idle, 1 is Up, 2 is Down, 3 is Left, 4 is Right
                    enemyArray[i].Move(enemyArray[i].ReturnMove((Character.MovementEnum)directionIndicator)); //casting
                }

                leader.Move(leader.ReturnMove(default));
 
                UpdateVision();
            }


        }

        public void UpdateMap()
        {
            FillMap();
            
            gameMap[Hero.X, Hero.Y] = Hero;
            gameMap[leader.X, leader.Y] = leader;

            

            //checks if enemies are dead
            for (int i = 0; i < enemyArray.Length; i++) 
            {
                if (enemyArray[i].IsDead())
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

            // fills item array with gold
            for (int i = 0; i < itemArray.Length; i++)
            {
                gameMap[itemArray[i].X, itemArray[i].Y] = itemArray[i];
            }

            // checks if gold is picked up
            for (int i = 0; i < itemArray.Length; i++)
            {
                if (GetItemAtPosition(itemArray[i].X, itemArray[i].Y) == null) // remove item in array if its picked up
                {
                    itemArray = itemArray.Where((source, index) => index != i).ToArray();
                }
            }

            // enemies will attack hero and pickup items
            foreach (var enemy in enemyArray)
            {
                if (enemy.CheckRange(Hero))
                {
                    enemy.Attack(Hero);
                }

                if (GetItemAtPosition(enemy.X, enemy.Y) != null)
                {
                    enemy.PickUp((Gold)gameMap[enemy.X, enemy.Y]);
                }
            }

            // Hero Pickup item
            if (GetItemAtPosition(hero.X, hero.Y) != null)
            {
                hero.PickUp((Gold)gameMap[hero.X, hero.Y]);
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

        public Item GetItemAtPosition(int x, int y) 
        {
            Item returnedItem;
            
            for (int i = 0; i < itemArray.Length; i++)
            {
                if (itemArray[i].X == x && itemArray[i].Y == y)
                {
                    returnedItem = (Item)itemArray[i];
                    itemArray[i] = null;

                    itemArray = itemArray.Where(z => z != null).ToArray();
                    return returnedItem;
                }
            }

            return null;

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

                case Tile.TileType.LEADER:
                    do
                    {
                        randomX = rnd.Next(1, gameMap.GetLength(0) - 1);
                        randomY = rnd.Next(1, gameMap.GetLength(1) - 1);

                    } while (isOpenTile(randomX, randomY));

                    return new Characters.Leader(randomX, randomY);


                case Tile.TileType.ENEMY:
                    do
                    {
                        randomX = rnd.Next(1, gameMap.GetLength(0) - 1);
                        randomY = rnd.Next(1, gameMap.GetLength(1) - 1);

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

                case Tile.TileType.EMPTY:
                    do
                    {
                        randomX = rnd.Next(1, gameMap.GetLength(0));
                        randomY = rnd.Next(1, gameMap.GetLength(1));

                    } while (isOpenTile(randomX, randomY));

                    return new EmptyTile(randomX, randomY, '.');
                default:
                    return null;
            }
        }


        public void UpdateVision()
        {
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
                // up
                enemy.VisionArray[0] = gameMap[enemy.X - 1, enemy.Y];
                // down
                enemy.VisionArray[1] = gameMap[enemy.X + 1, enemy.Y];
                // left
                enemy.VisionArray[2] = gameMap[enemy.X, enemy.Y - 1];
                // right
                enemy.VisionArray[3] = gameMap[enemy.X, enemy.Y + 1];

            }   
        }
    }
}
