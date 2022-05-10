using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splash
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_KeyDown(object sender, KeyEventArgs evento)
        {
            if (evento.KeyCode == Keys.Up)
            {
                helicoptero.Top = helicoptero.Top - 5;
                helicoptero.Image = Properties.Resources.helicoptero__1_derecha;
               
            }
            if (evento.KeyCode == Keys.Down)
            {
                helicoptero.Top = helicoptero.Top + 5;
                helicoptero.Image = Properties.Resources.helicoptero__1_derecha;
            }
            if (evento.KeyCode == Keys.Right)
            {
                helicoptero.Left = helicoptero.Left + 5;
                helicoptero.Image = Properties.Resources.helicoptero__1_derecha;
            }
            if (evento.KeyCode == Keys.Left)
            {
                helicoptero.Left = helicoptero.Left - 5;
                helicoptero.Image = Properties.Resources.helicoptero;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void movimiento()
        {
            pictureBox2.Left += 4;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            helicoptero.Top = helicoptero.Top + 2;
            movimiento();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
