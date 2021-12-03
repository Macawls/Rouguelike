using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RougeLike_Task1.Classes;
using RougeLike_Task1.Classes.Tiles.Items;
using RougeLike_Task1.Characters;
using WMPLib; //windows media player library
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace RougeLike_Task1
{

    public partial class Game : Form 
    {
        // game engine class
        GameEngine game = new GameEngine();
        GameEngine newGame = new GameEngine();
        
        WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer(); //background music
        WindowsMediaPlayer effectsPlayer = new WindowsMediaPlayer(); //sound effects

        // bool for tracking if an enemy has been killed
        public bool killedEnemy;
        
        public int playerScore;

        string path = "game.save";

        public Game()
        {
            InitializeComponent();
            musicPlayer.URL = "battle.wav"; //https://opengameart.org/content/the-battle-of-darkness-soundtrack
            musicPlayer.settings.volume = 0; 
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
        }

        private void DrawMap()
        {
            map.Text = game.ToString();

            playerStats.Text = game.Map.Hero.ToString();
            
            //parsing enemy array into combo boxes
            enemyDropdown.DataSource = game.Map.enemyArray;
            itemDropdown.DataSource = game.Map.itemArray;

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
                    game.Map.MoveEnemies();

                    break;
                
                    //left
                case 'a':
                case 'A':

 
                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.LEFT));
                    game.Map.MoveEnemies();

                    break;

                    //right
                case 'd':
                case 'D':
                    
       
                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.RIGHT));
                    game.Map.MoveEnemies();

                    break;

                    //down
                case 's':
                case 'S':

     
                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.DOWN));
                    game.Map.MoveEnemies();

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
                    if (game.Map.enemyArray[enemyDropdown.SelectedIndex] == null) // if the selection is null, do nothing
                    {
                        break;
                    }
                    else
                    {
                        if (game.Map.Hero.CheckRange(game.Map.enemyArray[enemyDropdown.SelectedIndex]))
                        {
                            game.Map.Hero.Attack(game.Map.enemyArray[enemyDropdown.SelectedIndex]);
                            msg.Text = $"Successful attack! {game.Map.enemyArray[enemyDropdown.SelectedIndex].GetType().Name} took {game.Map.Hero.Damage} damage!";
                            msg.Text += $"\n{game.Map.enemyArray[enemyDropdown.SelectedIndex].GetType().Name} is now on {game.Map.enemyArray[enemyDropdown.SelectedIndex].HP}!";

                            if (game.Map.enemyArray[enemyDropdown.SelectedIndex].HP <= 0) //if selected enemy in the enemy array is dead
                            {
                                msg.Text = "You killed an enemy!";
                                enemyDropdown.SelectedItem = null;
                                enemySelected.Text = "none";
                            }

                            
                            game.Map.UpdateMap();

                        }

                        else
                        {
                            msg.Text = "Unsuccessful attack...\nmaybe try moving closer?\nor choosing an enemy? \nlol";
                            
                        }
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

                            msg.Text = $"Alright! you picked up {secAmount - firstAmount} gold!";


                            if (game.Map.itemArray[itemDropdown.SelectedIndex].PickedUp == true)
                            {
                                itemSelected.Text = "none";
                            }

                        }

                        else
                        {
                            msg.Text = $"Try moving closer or selecting \nthe item you wish to pick up";
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
            DrawMap();
        }

        private void enemyDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            enemySelected.Text = enemyDropdown.SelectedItem.ToString();
            // focuses the form
            this.Focus();
            // makes sure the keys work again
            this.KeyPreview = true;

            enemyDropdown.Hide();
        }

        private void itemDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            itemSelected.Text = itemDropdown.SelectedItem.ToString();
            
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            game.Save(game, path);
        }

        private void moveControls_Click(object sender, EventArgs e)
        {
            
        }

        private void attackControls_Click(object sender, EventArgs e)
        {

        }

        private void bugLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
