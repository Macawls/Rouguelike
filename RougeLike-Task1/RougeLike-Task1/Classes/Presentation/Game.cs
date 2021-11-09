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
using RougeLike_Task1.Characters;
using WMPLib; //windows media player library

namespace RougeLike_Task1
{
    public partial class Game : Form 
    {
        // game engine class
        GameEngine game = new GameEngine();
        
        WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer(); //background music
        WindowsMediaPlayer effectsPlayer = new WindowsMediaPlayer(); //sound effects



        // bool for tracking if an enemy has been killed
        public bool killedEnemy;
        
        public int playerScore;
        
        public Game()
        {
            InitializeComponent();
            musicPlayer.URL = "battle.wav"; //https://opengameart.org/content/the-battle-of-darkness-soundtrack
            musicPlayer.settings.volume = 50; 
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //display stats and map
            DrawMap();
            //hides enemy window selection
            enemyDropdown.Hide();
            //player hasn't selected anything on start yet
            enemyDropdown.Enabled = false;
            //enables controls
            this.KeyPreview = true;
            musicPlayer.settings.setMode("Loop", true);
            musicPlayer.controls.play();
        }

        private void DrawMap()
        {
            map.Text = game.ToString();
            playerStats.Text = game.Map.Hero.ToString();
            //parsing enemy array into enemy dropdown
            enemyDropdown.DataSource = game.Map.enemyArray;

        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            char controls = e.KeyChar;

            // wasd movement, case insensitive
            switch (controls)
            {
                    //up
                case 'w':
                case 'W':
                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.UP));
                    break;
                
                    //left
                case 'a':
                case 'A':
                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.LEFT));
                    break;

                
                    //right
                case 'd':
                case 'D':
                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.RIGHT));
                    break;

                
                    //down
                case 's':
                case 'S':
                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.DOWN));
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
                            attackState.Text = $"Successful attack! {game.Map.enemyArray[enemyDropdown.SelectedIndex].GetType().Name} took {game.Map.Hero.Damage} damage!";
                            attackState.Text += $"\n{game.Map.enemyArray[enemyDropdown.SelectedIndex].GetType().Name} is now on {game.Map.enemyArray[enemyDropdown.SelectedIndex].HP}!";

                            if (game.Map.enemyArray[enemyDropdown.SelectedIndex].HP <= 0) //if selected enemy in the enemy array is dead
                            {
                                attackState.Text = "You killed an enemy!";
                                enemyDropdown.SelectedItem = null;
                                enemySelected.Text = "none";
                            }

                            game.Map.UpdateMap();

                        }

                        else
                        {
                            attackState.Text = "Unsuccessful attack...\nmaybe try moving closer?\nor choosing an enemy? \nlol";
                        }
                    }
                    break;

                //Pickup
                case 'P':
                case 'p':

                    //for (int i = 0; i < game.Map.itemArray.Length; i++)
                    //{
                    //    if (game.Map.Hero.Check)
                    //    {

                    //    }
                    //}
                    
                    //if (game.Map.Hero.CheckRange)
                    //{

                    //}
                    
                    effectsPlayer.URL = "pickup.wav"; //https://opengameart.org/content/coin-sounds-0
                    effectsPlayer.controls.play();

                    break;
                 
            }

            game.Map.UpdateMap();
            DrawMap();
        }

        private void enemyDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
 
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

        private void musicCheckBox_CheckedChanged(object sender, EventArgs e) //music check box
        {
            if (musicCheckBox.Checked == true)
            {
                musicPlayer.controls.pause();
            }

            else if (musicCheckBox.Checked == false)
            {
                musicPlayer.controls.play();
            }
        }
    }
}
