using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RogueLike.Classes;
using RogueLike.Classes.Tiles.Items;
using RogueLike.Characters;
using WMPLib; //windows media player library
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using RougeLike.Classes.Presentation;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RogueLike
{

    public partial class Game : Form 
    {
        // game engine class
        GameEngine game = new GameEngine();
        //GameEngine newGame = new GameEngine();
        
        WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer(); //background music
        WindowsMediaPlayer effectsPlayer = new WindowsMediaPlayer(); //sound effects

        // bool for tracking if an enemy has been killed
        public bool killedEnemy;
        
        public int playerGold;
        public int playerScore;

        IFormatter formatter = new BinaryFormatter();
        Stream stream;

        bool hasMoved; // at least once //using for changing save button colours


        public Game()
        {
            InitializeComponent();
            musicPlayer.URL = "dungeon.wav"; //https://opengameart.org/content/dungeon-04
            musicPlayer.settings.volume = 40;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            // load save file
            //newGame = (GameEngine)game.Load(path);

            //display stats and map
            DrawMap();
            
            //hides enemy window selection
            enemyDropdown.Hide();
            itemDropdown.Hide();
            
            //player hasn't selected anything on start yet
            enemyDropdown.Enabled = false;
            itemDropdown.Enabled = false;
            
            //enables controls
            this.KeyPreview = true;
            musicPlayer.settings.setMode("Loop", true);
            musicPlayer.controls.play();

            ItemMsg.Visible = false;
            AttackMsg.Text = "";
            //AttackMsg.Visible = false;

        }

        private void DrawMap()
        {
            // map
            map.Text = game.ToString();

            // player
            playerStats.Text = game.Map.Hero.ToString();

            //parsing enemy and item arrays into combo boxes
            enemyDropdown.DataSource = game.Map.enemyArray;
            itemDropdown.DataSource = game.Map.itemArray;

            playerGold = game.Map.Hero.Purse;

            if (hasMoved)
            {
                saveButton.ForeColor = Color.LightGreen;
                loadButton.ForeColor = Color.Salmon;
            }

            // Shop
            // Tried having a List of Buttons instead to prevent hardcoding
            // Not exactly sure how to implement that 
            
            itemOneButton.Text = game.Map.shop.DisplayWeapon(game.Map.shop.WeaponsArray[0].Cost);
            itemTwoButton.Text = game.Map.shop.DisplayWeapon(game.Map.shop.WeaponsArray[1].Cost);
            itemThreeButton.Text = game.Map.shop.DisplayWeapon(game.Map.shop.WeaponsArray[2].Cost);

            CheckCost();
            CheckGoldDiff();
            CheckLossCondition();
            CheckWinCondition();
        }

        // Chagning colors to indicate if the player can buy. Visual cues 
        private void CheckCost()
        {
            if (game.Map.shop.WeaponsArray[0].Cost <= game.Map.Hero.Purse)
            {
                itemOneButton.ForeColor = Color.LightGreen;
            }
            else
            {
                itemOneButton.ForeColor = Color.DimGray;
            }
            if (game.Map.shop.WeaponsArray[1].Cost <= game.Map.Hero.Purse)
            {
                itemOneButton.ForeColor = Color.LightGreen;
            }
            else
            {
                itemOneButton.ForeColor = Color.DimGray;
            }
            if (game.Map.shop.WeaponsArray[2].Cost <= game.Map.Hero.Purse)
            {
                itemOneButton.ForeColor = Color.LightGreen;
            }
            else
            {
                itemOneButton.ForeColor = Color.DimGray;
            }

        }

        private void CheckLossCondition()
        {
            if (game.Map.Hero.IsDead())
            {
                DeathScreen deathScreen = new DeathScreen();
                musicPlayer.controls.stop();
                deathScreen.Show();
                this.Hide();
            }
        }

        private void CheckWinCondition()
        {
            if (game.Map.enemyArray.Length == 0)
            {
                WinScreen winScreen = new WinScreen();
                musicPlayer.controls.stop();
                winScreen.Show();
                this.Hide();
            }
        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            char controls = e.KeyChar;

            // wasd movement, controls are case insensitive
            switch (controls)
            {
                    //up
                case 'w':
                case 'W':
                    
                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.UP));
                    hasMoved = true;
                    game.Map.MoveEnemies();

                    break;
                
                    //left
                case 'a':
                case 'A':

                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.LEFT));
                    game.Map.MoveEnemies();
                    hasMoved = true;

                    break;

                    //right
                case 'd':
                case 'D':
                    
                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.RIGHT));
                    game.Map.MoveEnemies();
                    hasMoved = true;

                    break;

                    //down
                case 's':
                case 'S':

                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.DOWN));
                    game.Map.MoveEnemies();
                    hasMoved = true;

                    break;
                
                    // Enemy Dropdown Menu
                case 'j':
                case 'J':
                    
                    if (!enemyDropdown.Visible)
                    {
                        this.KeyPreview = false;
                        enemyDropdown.Enabled = true;
                        enemyDropdown.Show();
                        enemyDropdown.DroppedDown = true;
                        enemyDropdown.Focus();
                    }
                    break;
                
                    //Attacking
                case 'F':
                case 'f':
                    if (game.Map.enemyArray.Length == 0) // if there are no enemies, break
                    {
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < game.Map.enemyArray.Length; i++)
                        {
                            // attack first attackable enemy in enemy array
                            if (game.Map.Hero.CheckRange(game.Map.enemyArray[i]))
                            {
                                game.Map.Hero.Attack(game.Map.enemyArray[i]);
                                
                                game.Map.MoveEnemies();
                                
                                AttackMsg.Visible = true;
                                AttackMsg.Text = $"Successful attack! {game.Map.enemyArray[i].GetType().Name} took {game.Map.Hero.Damage} damage!";
                                AttackMsg.Text += $"\n{game.Map.enemyArray[i].GetType().Name} is now on {game.Map.enemyArray[i].HP} HP!";

                                if (game.Map.enemyArray[i].IsDead())
                                {
                                    AttackMsg.Text = "You killed an enemy!";
                                    effectsPlayer.URL = "win.wav"; //https://opengameart.org/content/win-sound-effect
                                    effectsPlayer.settings.volume = 40;
                                    effectsPlayer.controls.play();
                                    playerScore++;
                                }
                                
                                break;  //stops at the first attackable enemy
                            }

                            else
                            {
                                AttackMsg.Text = "Unsuccessful attack...\nmaybe try moving closer?\nlol";
                            }
                        }

                        // This does work, but picking enemies from a menu just doesn't feel good at all
                        // instead players can view enemies and their stats // leaving it here cos? idk

                        // Manually Indicating
                        
                        //if (game.Map.Hero.CheckRange(game.Map.enemyArray[enemyDropdown.SelectedIndex]))
                        //{
                        //    game.Map.Hero.Attack(game.Map.enemyArray[enemyDropdown.SelectedIndex]);
                            
                        //    AttackMsg.Visible = true;
                        //    AttackMsg.Text = $"Successful attack! {game.Map.enemyArray[enemyDropdown.SelectedIndex].GetType().Name} took {game.Map.Hero.Damage} damage!";
                        //    AttackMsg.Text += $"\n{game.Map.enemyArray[enemyDropdown.SelectedIndex].GetType().Name} is now on {game.Map.enemyArray[enemyDropdown.SelectedIndex].HP}!";

                        //    if (game.Map.enemyArray[enemyDropdown.SelectedIndex].HP <= 0) //if selected enemy in the enemy array is dead
                        //    {
                        //        AttackMsg.Text = "You killed an enemy!";
                        //        enemyDropdown.SelectedItem = null;
                        //        enemySelected.Text = "none";
                        //    }

                            
                        //    game.Map.UpdateMap();

                        //}

                        //else
                        //{
                        //    AttackMsg.Text = "Unsuccessful attack...\nmaybe try moving closer?\nor choosing an enemy? \nlol";
                            
                        //}
                    }
                    
                    DrawMap();
                    
                    break;

                //Pickup
                case 'P':
                case 'p':
                    
                    if (game.Map.itemArray[itemDropdown.SelectedIndex] == null)
                    {
                        break;
                    }
                    else
                    {
                        if (game.Map.Hero.CheckRange((Gold)game.Map.itemArray[itemDropdown.SelectedIndex]))
                        {

                            int firstAmount = game.Map.Hero.Purse;
                            
                            game.Map.Hero.PickUp((Gold)game.Map.itemArray[itemDropdown.SelectedIndex]);
                            
                            int secAmount = game.Map.Hero.Purse;
                            
                            game.Map.itemArray[itemDropdown.SelectedIndex].PickedUp = true;

                            effectsPlayer.URL = "pickup.wav"; //https://opengameart.org/content/coin-sounds-0
                            effectsPlayer.controls.play();

                            ItemMsg.Text = $"Alright! you picked up {secAmount - firstAmount} gold!";


                            if (game.Map.itemArray[itemDropdown.SelectedIndex].PickedUp == true)
                            {
                                itemSelected.Text = "none";
                            }

                        }

                        else
                        {
                            ItemMsg.Text = $"Try moving closer or selecting \nthe item you wish to pick up";
                        }

                        game.Map.UpdateMap();
                    }
      
                    
                    break;
                case 'i':
                case 'I':
                    if (!itemDropdown.Visible)
                    {
                        this.KeyPreview = false;
                        itemDropdown.Enabled = true;
                        itemDropdown.Show();
                        itemDropdown.DroppedDown = true;
                        itemDropdown.Focus();
                    }
                    break;

            }

            game.Map.UpdateMap();
            //HideText();
            CheckGoldDiff();
            
            DrawMap();
        }

        private void CheckGoldDiff()
        {
            int newAmount = game.Map.Hero.Purse;
            int diff = newAmount - playerGold;

            if (diff < 0)
            {
                ItemMsg.Visible = true;
                ItemMsg.Text = $"You bought a {game.Map.Hero.Weapon}!";
            }

            else if (diff != 0)
            {
                ItemMsg.Visible = true;
                ItemMsg.Text = $"Alright! you picked up {diff} gold!";
            }


        }

        private void msg_TextChanged(object sender, EventArgs e)
        {
            if (game.Map.Hero.Purse != 0)
            {
                effectsPlayer.URL = "pickup.wav"; //https://opengameart.org/content/coin-sounds-0
                effectsPlayer.settings.volume = 50;
                effectsPlayer.controls.play();
            }
            
        }

        private void enemyDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (enemySelected == null) // doesnt matter cos if enemies are dead you win but anyway
            {
                enemySelected.Text = "No more enemies";
            }

            else if (enemySelected.Text != null)
            {
                if (enemyDropdown.SelectedItem != null)
                {
                    enemySelected.Text = enemyDropdown.SelectedItem.ToString();
                }
                
            }

            // focuses the form
            this.Focus();
            // makes sure the keys work again
            this.KeyPreview = true;

            enemyDropdown.Hide();
        }

        private void itemDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (itemSelected == null)
            {
                itemSelected.Text = "No more items";
            }

            else if (itemSelected.Text != null)
            {
                if (itemDropdown.SelectedItem != null)
                {
                    itemSelected.Text = itemDropdown.SelectedItem.ToString();
                }        
            }

            this.Focus();
            this.KeyPreview = true;

            itemDropdown.Hide();
        }

        // nothing to do with the POE, just for fun :)
        private void musicCheckBox_CheckedChanged(object sender, EventArgs e) //music check box
        {
            if (musicCheckBox.Checked)
            {
                musicPlayer.controls.pause();
            }

            else if (!musicCheckBox.Checked)
            {
                musicPlayer.controls.play();
            }
        }

        private void tutorial_CheckedChanged(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.FormClosed += HelpForm_FormClosed; // adding helpform close event

            if (!tutorial.Checked)
            {
                helpForm.musicPlayer.controls.stop();
            }

            if (tutorial.Checked)
            {
                this.Hide();
                helpForm.Show();
                this.musicPlayer.controls.pause();
            }
              
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            this.musicPlayer.controls.play();

            tutorial.Checked = false;
        }

        private void itemOneButton_Click(object sender, EventArgs e)
        {
            // can buy
            if (game.Map.shop.CanBuy(game.Map.shop.WeaponsArray[0].Cost))
            {
                game.Map.shop.Buy(game.Map.shop.WeaponsArray[0].Cost);

                effectsPlayer.settings.volume = 80;
                
                // I combined these 
                //      https://opengameart.org/content/coin-drop
                //      https://opengameart.org/content/cloth-swing-sounds

                effectsPlayer.URL = "buyandequip.wav";
                effectsPlayer.controls.play();

                ItemMsg.Text = $"You bought a {game.Map.shop.WeaponsArray[0]}!";

                DrawMap();
            }

            // cant buy
            else
            {
                
                effectsPlayer.URL = "negative.wav"; //https://opengameart.org/content/gui-sound-effects
                effectsPlayer.controls.play();

                ItemMsg.Visible = true;
                ItemMsg.Text = $"You cant afford a {game.Map.shop.WeaponsArray[0]}!";

                DrawMap();

            }
            
        }


        private void itemTwoButton_Click(object sender, EventArgs e)
        {
            // can buy
            if (game.Map.shop.CanBuy(game.Map.shop.WeaponsArray[1].Cost))
            {
                game.Map.shop.Buy(game.Map.shop.WeaponsArray[1].Cost);

                effectsPlayer.settings.volume = 80;

                // I combined these 
                //      https://opengameart.org/content/coin-drop
                //      https://opengameart.org/content/cloth-swing-sounds

                effectsPlayer.URL = "buyandequip.wav";
                effectsPlayer.controls.play();

                ItemMsg.Text = $"You bought a {game.Map.shop.WeaponsArray[1]}!";

                DrawMap();
            }

            // cant buy
            else
            {

                effectsPlayer.URL = "negative.wav"; //https://opengameart.org/content/gui-sound-effects
                effectsPlayer.controls.play();

                ItemMsg.Visible = true;
                ItemMsg.Text = $"You cant afford a {game.Map.shop.WeaponsArray[1]}!";

                DrawMap();

            }
        }

        private void itemThreeButton_Click(object sender, EventArgs e)
        {
            // can buy
            if (game.Map.shop.CanBuy(game.Map.shop.WeaponsArray[2].Cost))
            {
                game.Map.shop.Buy(game.Map.shop.WeaponsArray[2].Cost);

                effectsPlayer.settings.volume = 80;

                // I combined these 
                //      https://opengameart.org/content/coin-drop
                //      https://opengameart.org/content/cloth-swing-sounds

                effectsPlayer.URL = "buyandequip.wav";
                effectsPlayer.controls.play();

                ItemMsg.Text = $"You bought a {game.Map.shop.WeaponsArray[2]}!";

                DrawMap();
            }

            // cant buy
            else
            {

                effectsPlayer.URL = "negative.wav"; //https://opengameart.org/content/gui-sound-effects
                effectsPlayer.controls.play();

                ItemMsg.Visible = true;
                ItemMsg.Text = $"You cant afford a {game.Map.shop.WeaponsArray[2]}!";

                DrawMap();

            }
        }

        private void youtubeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://youtu.be/msONzs5DKC0");
            Process.Start(sInfo);
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/Macawls");
            Process.Start(sInfo);
        }

        
        // Save
        private void saveButton_Click(object sender, EventArgs e)
        {
            stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "Savedata.dat", FileMode.Create, FileAccess.Write);
            
            formatter.Serialize(stream, game);
            
            stream.Close();

            ItemMsg.Text = "Your game has been saved";
        }

        // Load
        private void button1_Click(object sender, EventArgs e) 
        {
            stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "Savedata.dat", FileMode.Open, FileAccess.Read);

            game = (GameEngine)formatter.Deserialize(stream);
            game.Map.UpdateMap();
            DrawMap();
            
            stream.Close();

            ItemMsg.Text = "Your old game save has been loaded";
        }
    }
}
