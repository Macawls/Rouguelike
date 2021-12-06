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

namespace RougeLike.Classes.Presentation
{
    public partial class DeathScreen : Form
    {
        public WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();

        public DeathScreen()
        {
            InitializeComponent();
            this.musicPlayer.URL = "evil.wav"; //https://opengameart.org/content/return-of-the-evil-soundtrack
        }

        private void DeathScreen_Load(object sender, EventArgs e)
        {
            musicPlayer.settings.setMode("Loop", true);
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

        private void DeathScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
