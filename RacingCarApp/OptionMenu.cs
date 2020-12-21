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
    public partial class OptionMenu : Form
    {
        public OptionMenu()
        {
            InitializeComponent();
        }

        private void OptionMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mainMenu.wplayer.controls.play();
            btn_sound.Image = Properties.Resources.full_valume;
            mainMenu.wplayer.settings.volume = trackBar1.Value;

            if (trackBar1.Value == 0)
            {
                btn_sound.Image = Properties.Resources.no_sound;
            }
        }
    }
}
