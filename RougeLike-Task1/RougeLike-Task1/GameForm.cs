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
        // bools to indicate the state of key presses
        public bool keyUp = false;
        public bool keyDown = false;
        public bool keyRight = false;
        public bool keyLeft = false;

        // Test Map
        public string[,] map = new string[7, 7];



        //current position of Player, start in middle
        public int xPos = 3;
        public int yPos = 3;



        public GameForm()
        {
            InitializeComponent();
            
        }

        private void Game_Load(object sender, EventArgs e)
        {
            keypressLabel.Text = "";
            DrawMap();

        }

        public void MovePlayer(string direction)
        {
            switch (direction)
            {
                case "up":
                    
                    if (xPos > 0) //cant move further than wall
                    {
                        xPos = xPos - 1;
                    }

                    break;

                case "down":

                    if (xPos < map.GetLength(0) - 1)
                    {
                        xPos = xPos + 1;
                    }

                    break;

                case "left":

                    if (yPos > 0)
                    {
                        yPos = yPos - 1;
                    }
    
                    break;

                case "right":

                    if (yPos < map.GetLength(1) - 1)
                    {
                        yPos = yPos + 1;
                    }

                    break;
            }

        }

        public void ClearPreviousPosition()
        {

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == "H")
                    {
                        map[i, j] = "X";
                    }
                }
            }
        }

        public void DrawMap()
        {
            //clear map completely first
            testMap.Text = string.Empty;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {                    
                    map[xPos, yPos] = "H";

                    if (map[i, j] != "H") // put "ground" 'outside' hero
                    {
                        map[i, j] = "X";
                    }
                    
                    testMap.Text += map[i, j];
                }

                testMap.Text += "\n";
            }
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
                    keypressLabel.Text = "Player last moved up";
                    MovePlayer("up");
                    ClearPreviousPosition();
                    DrawMap();
                    keyUp = false;
                    break;
                //left
                case 'a':
                case 'A':
                    keyLeft = true;
                    keypressLabel.Text = "Player last moved left";
                    MovePlayer("left");
                    ClearPreviousPosition();
                    DrawMap();

                    keyLeft = false;
                    break;
                //down
                case 's':
                case 'S':
                    keyDown = true;
                    keypressLabel.Text = "Player last moved down";
                    MovePlayer("down");
                    ClearPreviousPosition();
                    DrawMap();
                    keyDown = false;
                    break;
                //right
                case 'd':
                case 'D':
                    keyRight = true;
                    keypressLabel.Text = "Player last moved right";
                    MovePlayer("right");
                    ClearPreviousPosition();
                    DrawMap();

                    keyRight = false;
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
