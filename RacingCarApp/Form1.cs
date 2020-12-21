using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCarApp
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
            wplayer.URL = (@"C:\Users\user\source\repos\RacingCarApp\Resources\melodyloops-preview-happy-days-ahead-2m30s.mp3");
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.PixelCarRacerLogo;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\user\source\repos\RacingCarApp\Resources\button-3.wav");
            sound.Play();
        }

        private void btn_option_MouseHover(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.Settingbtn;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\user\source\repos\RacingCarApp\Resources\button-09.wav");
            sound.Play();
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exitsign;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\user\source\repos\RacingCarApp\Resources\button-10.wav");
            sound.Play();
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.press_start_menu;
        }

        private void btn_option_MouseLeave(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.setting_menu;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_button;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            form pixel= new form();
            pixel.Show();
        }
        private void btn_option_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionMenu option = new OptionMenu();
            option.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
