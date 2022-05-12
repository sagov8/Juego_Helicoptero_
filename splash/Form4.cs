using splash.Properties;
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
    public partial class Form4 : Form
    {

        int contador = 0;
        PictureBox[] figura;
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (contador < 5)
            {

                contador++;
                this.Refresh();
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
            timer1.Interval = 1000;
            figura = new PictureBox[5] {pictureBox1,pictureBox2,pictureBox3,
               pictureBox4,pictureBox5};
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

