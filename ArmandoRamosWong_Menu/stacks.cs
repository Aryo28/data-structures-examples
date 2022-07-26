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

    
    public partial class stacks : Form
    {
        

        //Crear Stacks
        Stack<string> cocacola = new Stack<string>();
        Stack<string> sidral1 = new Stack<string>();
        Stack<string> sprite1 = new Stack<string>();
        Stack<string> fanta1 = new Stack<string>();
        Stack<string> jugo1 = new Stack<string>();
        Stack<string> ciel1 = new Stack<string>();
        public stacks()
        {
            InitializeComponent();
            //Llenado de Stacks

            //Stack Coca Cola
            cocacola.Push("Coca 1");
            cocacola.Push("Coca 2");
            cocacola.Push("Coca 3");
            cocacola.Push("Coca 4");
            cocacola.Push("Coca 5");


            //Stack sidral
            sidral1.Push("Sidral 1");
            sidral1.Push("Sidral 2");
            sidral1.Push("Sidral 3");
            sidral1.Push("Sidral 4");


            //Stack Sprite
            sprite1.Push("Sprite 1");
            sprite1.Push("Sprite 2");
            sprite1.Push("Sprite 3");
            sprite1.Push("Sprite 4");
            sprite1.Push("Sprite 5");
            sprite1.Push("Sprite 6");


            //Stack Fanta
            fanta1.Push("Fanta 1");
            fanta1.Push("Fanta 2");
            fanta1.Push("Fanta 3");


            //Stack Jugo
            jugo1.Push("Jugo 1");
            jugo1.Push("Jugo 2");
            jugo1.Push("Jugo 3");
            jugo1.Push("Jugo 4");
            jugo1.Push("Jugo 5");
            jugo1.Push("Jugo 6");
            jugo1.Push("Jugo 7");
            jugo1.Push("Jugo 8");


            //Stack Ciel
            ciel1.Push("Ciel 1");
            ciel1.Push("Ciel 2");
            ciel1.Push("Ciel 3");
            ciel1.Push("Ciel 4");
            ciel1.Push("Ciel 5");

        }

        private void stacks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pedido = cocacola.Pop();
            textBox1.Text = pedido;

            int cuenta = cocacola.Count();
            textBox2.Text = cuenta.ToString();


            if (cocacola.Count == 0 || cocacola.Count < 0)
            {
                textBox1.Text = "Producto Insuficiente";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pedido = sprite1.Pop();
            textBox1.Text = pedido;

            int cuenta = sprite1.Count();
            textBox2.Text = cuenta.ToString();


            if (sprite1.Count == 0 || sprite1.Count < 0)
            {
                textBox1.Text = "Producto Insuficiente";
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pedido = sidral1.Pop();
            textBox1.Text = pedido;

            int cuenta = sidral1.Count();
            textBox2.Text = cuenta.ToString();

            if (sidral1.Count == 0 || sidral1.Count < 0)
            {
                textBox1.Text = "Producto Insuficiente";
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pedido = fanta1.Pop();
            textBox1.Text = pedido;

            int cuenta = fanta1.Count();
            textBox2.Text = cuenta.ToString();

            if (fanta1.Count == 0 || fanta1.Count < 0)
            {
                textBox1.Text = "Producto Insuficiente";
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pedido = jugo1.Pop();
            textBox1.Text = pedido;

            int cuenta = jugo1.Count();
            textBox2.Text = cuenta.ToString();

            if (jugo1.Count == 0 || jugo1.Count < 0)
            {
                textBox1.Text = "Producto Insuficiente";
                return;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string pedido = ciel1.Pop();
            textBox1.Text = pedido;

            int cuenta = ciel1.Count();
            textBox2.Text = cuenta.ToString();

            if (ciel1.Count == 0 || ciel1.Count < 0)
            {
                textBox1.Text = "Producto Insuficiente";
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();

            menu.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
