using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RacingCarApp
{
	public partial class form : Form
	{


		// this will store the Deltas
		static Point vectors = new Point();
		static Point newPoint = new Point();
		int dx = 8;
		int dy = 8;
#if DEBUG
		List<int> vs = new List<int>();
#endif
		public form()
		{
#if DEBUG
			vs.Add(0);
#endif
			InitializeComponent();
		}
		//its unnecessary to do this every 5 milisecs, 15ms should be plenty
		//Also, now we can do the controls within only one tick
		private void timer1_Tick_1(object sender, EventArgs e)
		{
#if DEBUG
			SpeedCam();
#endif
			moveline(7);
			newPoint = new Point(car.Location.X + vectors.X,
								car.Location.Y + vectors.Y);
			car.Location = newPoint;
			if (car.Location.X > this.Width - car.Width / 2)
			{
				car.Left = 16;
				return;

			}
			if (car.Location.X < car.Width / 2 * -1)
			{
				// car.Right is a readonly property, so we need to employ a workaround
				car.Left = this.Width - car.Width - 11;
				return;
			}

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
			var eCode = e.KeyCode;

			switch (eCode)
			{
				case Keys.W:
					vectors.Y -= dy;
					break;

				case Keys.S:
					vectors.Y += dy;
					break;

				case Keys.A:
					vectors.X -= dx;
					break;

				case Keys.D:
					vectors.X += dx;
					break;
#if DEBUG
					// place a breakpoint on the break statement, so if you press b, the app will break
					// if you flip the compiler to release, this the lines within the #if block will be thrown out
					// Be careful about what goes into these, only use them in other debug blocks
				case Keys.B:
					break;
#endif
			}


		}

		private void form_KeyUp(object sender, KeyEventArgs e)
		{
			var eCode = e.KeyCode;
			// this block is the exact opposite of the keyDown block, it removes the movement deltas
			switch (eCode)
			{
				case Keys.W:
					vectors.Y += dy;
					break;

				case Keys.S:
					vectors.Y -= dy;
					break;

				case Keys.A:
					vectors.X += dx;
					break;

				case Keys.D:
					vectors.X -= dx;
					break;
			}


		}

#if DEBUG
		void SpeedCam()
		{
			if (vs[vs.Count - 1] != vectors.X)
			{
				vs.Add(vectors.X);
			}
		}
#endif

	}
}

