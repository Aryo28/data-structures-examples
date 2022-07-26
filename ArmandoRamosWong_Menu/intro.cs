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
    public partial class intro : Form
    {
        bool check = false;
        game game = new game();

        public intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check = true;

            if (check == true)
            {
                game.Show();
                this.Hide();
            }
        }

        private void intro_Load(object sender, EventArgs e)
        {

        }
    }
}
