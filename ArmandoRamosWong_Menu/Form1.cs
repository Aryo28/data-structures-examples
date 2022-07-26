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
    public partial class Form1 : Form
    {
        stacks stack = new stacks();
        queue queue = new queue();
        intro intro = new intro();
        //string array = "https://arreglosestructuradatos.000webhostapp.com/";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stack.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "https://arreglosestructuradatos.000webhostapp.com/";
            richTextBox2.Text = "https://arraysdatastruct.000webhostapp.com/";

        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);

        }

        private void richTextBox2_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queue.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            intro.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
