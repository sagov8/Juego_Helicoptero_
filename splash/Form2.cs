using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splash
{
    public partial class Form2 : Form
    {
        SoundPlayer cancion = new SoundPlayer(@"D:\UNIVERSIDAD\QUINTO SEMESTRE\Herramientas Visuales\herramientas\splash\assets\dino-2.0.wav");

        int porcentaje = 0;
        public Form2()
        {
            InitializeComponent();
            cancion.Play();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Width < 515)
            {
                panel1.Width += 125;
                porcentaje += 25;
                lbl_porcentaje.Text = "" + porcentaje + "%";
            }
            else
            {
                timer1.Stop();
                Form3 win2 = new Form3();
                win2.Show();
                this.Close();
               
            }
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
