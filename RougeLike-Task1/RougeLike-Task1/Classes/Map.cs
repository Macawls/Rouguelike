using RogueLike.Classes.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueLike.Classes.Tiles.Items;

namespace RogueLike.Classes
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
            PlaceInMap(Hero);

            // Enemies (randomizes in create function)
            for (int i = 0; i < enemyArray.Length; i++)
            {
                enemyArray[i] = (Characters.Enemy)Create(Tile.TileType.ENEMY);
                PlaceInMap(enemyArray[i]);
            }

            // Creating Leader
            
            //replace random enemy with leader
            leader = (Characters.Leader)Create(Tile.TileType.LEADER);
            int leaderIndex = rnd.Next(0, enemyArray.Length); 
            enemyArray[leaderIndex] = leader;
            
            //set target of leader
            leader.Target = Hero;
            
            PlaceInMap(leader);
            
            // Items
            for (int i = 0; i < maxGoldDrops; i++) // maxGoldDrops = itemArray.Length
            {
                itemArray[i] = (Tiles.Item)Create(Tile.TileType.GOLD);
                itemArray[i].PickedUp = false;
                PlaceInMap(itemArray[i]);
            }

            // updating vision
            UpdateVision();  
        }

        public void PlaceInMap(Tile tile)
        {
            gameMap[tile.X, tile.Y] = tile;
        }

        public void MoveEnemies()
        {
            Random num = new Random();
            int directionIndicator;

            for (int i = 0; i < enemyArray.Length; i++)
            {
                if (enemyArray[i].GetType() != typeof(Characters.Leader)) //move non leader enemies
                {
                    directionIndicator = num.Next(0, 5); // 0 is idle, 1 is Up, 2 is Down, 3 is Left, 4 is Right
                    enemyArray[i].Move(enemyArray[i].ReturnMove((Character.MovementEnum)directionIndicator)); //casting
                } 
            }

            if (!leader.IsDead()) //isn't dead
            {
                leader.Move(leader.ReturnMove(default));
            }

        }

        public void UpdateMap()
        {
            FillMap();
            
            PlaceInMap(Hero);
            PlaceInMap(leader);

            //checks if enemies are dead
            for (int i = 0; i < enemyArray.Length; i++) 
            {
                int count = i;
                
                if (enemyArray[i].IsDead())
                {
                    //makes new array without dead enemies
                    enemyArray = enemyArray.Where((source, index) => index != i).ToArray();
                }
            }
            
            // for some reason all enemies dissapear except the leader even though 
            // if its dead it doesn't exist in the enemy array
            // this is a workaround
            if (leader.IsDead())
            {
                gameMap[leader.X, leader.Y] = new EmptyTile(leader.X, leader.Y, '.');
            }

            // fills item array with gold
            for (int i = 0; i < itemArray.Length; i++)
            {
                gameMap[itemArray[i].X, itemArray[i].Y] = itemArray[i];
            }

            //fills array with enemies
            for (int i = 0; i < enemyArray.Length; i++)
            {
                PlaceInMap(enemyArray[i]);
            }

            PickupItemAtPosition(Hero);
            PlaceInMap(Hero);
            
            // enemies will attack hero and pickup items
            foreach (var enemy in enemyArray)
            {
                if (enemy.CheckRange(Hero))
                {
                    enemy.Attack(Hero);
                }

                PickupItemAtPosition(enemy);
            }

            // mages friendly fire as well as attacking the hero
            foreach (var enemy in enemyArray)
            {
                if (enemy.GetType() == typeof(Characters.Mage))
                {
                    for (int i = 0; i < enemyArray.Length; i++)
                    {
                        if (enemy.CheckRange(enemyArray[i]))
                        {
                            enemy.Attack(enemyArray[i]);
                        }
                    }
                }
            }

            UpdateVision();

        }

        public void FillMap()
        {
            // entire map is filled with empty tiles first
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

        public void PickupItemAtPosition(Character character) 
        {
            for (int i = 0; i < itemArray.Length; i++)
            {
                if (itemArray[i].X == character.X && itemArray[i].Y == character.Y)
                {
                    character.PickUp((Gold)itemArray[i]);
                }

                if (itemArray[i].PickedUp)
                {
                    itemArray = itemArray.Where((source, index) => index != i).ToArray();
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
