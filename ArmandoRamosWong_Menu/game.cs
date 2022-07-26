using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmandoRamosWong_Menu
{
    public partial class game : Form
    {
        gameOver newgame = new gameOver();


        Image[] burd = new Image[3];
        int contador1 = 0;      //IDLE
        int speed = 5;          //Vel mov de pipes
        int grav = 3;          //Gravedad
        int score = 0;
        bool test = false;
        public static string mensaje = "";

        public game()

        {
            burd[0] = ArmandoRamosWong_Menu.Properties.Resources.bird1;
            burd[1] = ArmandoRamosWong_Menu.Properties.Resources.bird2;
            burd[2] = ArmandoRamosWong_Menu.Properties.Resources.bird3;
            InitializeComponent();
        }

        private void game_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer3.Start();
            timer2.Enabled = true;
        }

        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pictureBox1.Top -= grav;

            }
        }

        private void game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pictureBox1.Top += grav;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = burd[contador1];
            if (contador1 == 2)
            {
                contador1 = -1;
            }
            contador1++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += grav;
            pictureBox2.Left -= speed;
            pictureBox4.Left -= speed;
            pictureBox5.Left -= speed;
            pictureBox6.Left -= speed;



            if (pictureBox2.Left < 0)
            {
                pictureBox2.Left += 455;
            }



            if (pictureBox4.Left < 0)
            {
                pictureBox4.Left += 440;
            }

            if (pictureBox5.Left < 0)
            {
                pictureBox5.Left += 445;
            }

            if (pictureBox6.Left < 0)
            {
                pictureBox6.Left += 440;
            }




            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                test = true;
                gameover();
            }

            label2.Text = Convert.ToString(score);
            mensaje = label2.Text;
        }


        private void gameover()
        {
            if (test == true)
            {

                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                newgame.Show();
                this.Hide();

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            score++;
            label2.Text = score.ToString();
        }
    }
}
