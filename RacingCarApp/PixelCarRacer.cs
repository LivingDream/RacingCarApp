using System;
using System.Drawing;
using System.Windows.Forms;

namespace RacingCarApp
{
    public partial class form : Form
    {
        public form()
        {
            System.Threading.Thread.Sleep(100);
            InitializeComponent();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            moveline(5);
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu main = new mainMenu();
            main.Show();
        }

        private void car_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Up.Enabled = true;
            }
            if (e.KeyCode == Keys.S)
            {
                Down.Enabled = true;
            }
            if (e.KeyCode == Keys.A)
            {
                Left.Enabled = true;
            }
            if (e.KeyCode == Keys.D)
            {
                Right.Enabled = true;
            }
        }

        private void form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Up.Enabled = false;
            }
            if (e.KeyCode == Keys.S)
            {
                Down.Enabled = false;
            }
            if (e.KeyCode == Keys.A)
            {
                Left.Enabled = false;
            }
            if (e.KeyCode == Keys.D)
            {
                Right.Enabled = false;
            }
        }

        int newX = 0;
        int newY = 0;
        int dx = 10;
        int dy = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (car.Location.Y > 0)
            {
                newY = car.Location.Y - dy;
                car.Location = new Point(car.Location.X, newY);

            }
        }

        private void Down_Tick(object sender, EventArgs e)
        {
            if (car.Location.Y < this.Height - 90)
            {
                newY = car.Location.Y + dy;
                car.Location = new Point(car.Location.X, newY);
            }
        }

        private void Left_Tick(object sender, EventArgs e)
        {
            if (car.Location.X > 0)
            {
                newX = car.Location.X - dx;
                car.Location = new Point(newX, car.Location.Y);
            }
        }

        private void Right_Tick(object sender, EventArgs e)
        {
            if (car.Location.X < this.Width - 115)
            {
                newX = car.Location.X + dx;
                car.Location = new Point(newX, car.Location.Y);
            }
        }
    }
}
