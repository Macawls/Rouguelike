using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace RougeLike_Task1.Classes.Presentation
{
    public partial class WinScreen : Form
    {
        public WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();

        public WinScreen()
        {
            InitializeComponent();
            this.musicPlayer.URL = "unsettling.wav"; //https://opengameart.org/content/horror-unsettling-victory-loop
        }

        private void WinScreen_Load(object sender, EventArgs e)
        {
            musicPlayer.settings.setMode("Loop", true);
            musicPlayer.settings.volume = 60;
            musicPlayer.controls.play();

        }

        private void restartGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void endGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
