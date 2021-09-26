using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RougeLike_Task1
{
    public partial class GameForm : Form
    {
        public bool keyUp = false;
        public bool keyDown = false;
        public bool keyRight = false;
        public bool keyLeft = false;

        // bools to indicate the state of key presses, made false after the move method. 

        public GameForm()
        {
            InitializeComponent();
            
        }
        private void Game_Load(object sender, EventArgs e)
        {
            keypressLabel.Text = "";
        }

        public void GameKeyPress(object sender, KeyPressEventArgs e)
        {
            keypressLabel.Text = "Key pressed: " + e.KeyChar;

            char controls = e.KeyChar; 

            switch (controls) // call move method here, // works regardless of caps lock
            {
                //up 
                case 'w':
                case 'W':
                    keyUp = true;
                    keypressLabel.Text = "Player moved up";
                    break;
                //left
                case 'a':
                case 'A':
                    keyLeft = true;
                    keypressLabel.Text = "Player moved left";
                    break;
                //down
                case 's':
                case 'S':
                    keyDown = true;
                    keypressLabel.Text = "Player moved down";
                    break;
                //right
                case 'd':
                case 'D':
                    keyRight = true;
                    keypressLabel.Text = "Player moved right";
                    break;
 
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            // clears label after key was pressed
            //keypressLabel.Text = "";
        }

        private void KeyPress_Click(object sender, EventArgs e)
        {

        }

        private void GameMap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
