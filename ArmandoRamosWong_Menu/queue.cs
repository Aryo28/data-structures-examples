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
    public partial class queue : Form
    {
        

        Queue<string> turnos = new Queue<string>();
        string nturno = "0";

        public queue()
        {
            InitializeComponent();
        }

        private void queue_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rrr = Convert.ToInt32(nturno);
            rrr += 1;

            string qqq = Convert.ToString(rrr);
            nturno = qqq;

            turnos.Enqueue(qqq);

            textBox4.Text = qqq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = turnos.Dequeue();

            int rrr = Convert.ToInt32(nturno);

            if (rrr <= 0)
            {
                textBox1.Text = "--";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int restantes = turnos.Count();
            textBox3.Text = restantes.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();

            menu.Show();
            this.Hide();
        }
    }
}
