using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace RogueLike.Classes
{
    public partial class HelpForm : Form
    {
        public WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();

        public HelpForm()
        {
            InitializeComponent();
            this.musicPlayer.URL = "wait.wav"; //https://opengameart.org/content/waiting-room
        }

        private void Help_Load(object sender, EventArgs e)
        {
            musicPlayer.settings.setMode("Loop", true);
            musicPlayer.controls.play();
        }

        private void back_Click(object sender, EventArgs e)
        {
            musicPlayer.controls.stop();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            musicPlayer.controls.stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.behance.net/gallery/45738323/Animationssprites");
            Process.Start(sInfo);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
