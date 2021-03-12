using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        void moveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else
            { pictureBox1.Top += speed; }


            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else
            { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else
            { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else
            { pictureBox4.Top += speed; }
        }

        int gamespeed = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Car.Left > 0)
                    Car.Left += -8;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (Car.Right < 380)
                    Car.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21) { gamespeed++; }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0) { gamespeed--; }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gamespeed);
            enemy(gamespeed);
            gameover();
        }

        Random r = new Random();
        int x, y;

        void enemy(int speed)
        {
            if (RandomCar1.Top >= 500)
            {
                x = r.Next(20, 200);
                RandomCar1.Location = new Point(x, 0);
            }
            else
            { RandomCar1.Top += speed; }

            if (RandomCar2.Top >= 500)
            {
                x = r.Next(20, 380);
                RandomCar2.Location = new Point(x, 0);
            }
            else
            { RandomCar2.Top += speed; }

            if (RandomCar3.Top >= 500)
            {
                x = r.Next(200, 350);
                RandomCar3.Location = new Point(x, 0);
            }
            else
            { RandomCar3.Top += speed; }
        }


        void gameover()
        {
            if (Car.Bounds.IntersectsWith(RandomCar1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (Car.Bounds.IntersectsWith(RandomCar2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (Car.Bounds.IntersectsWith(RandomCar3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }
    }
}
