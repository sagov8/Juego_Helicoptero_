using splash.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splash
{
    public partial class Form3 : Form
    {
        int vidas = 3;
        int puntaje = 0;
        public Form3()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs evento)
        {
            if (evento.KeyCode == Keys.Up)
            {
                helicoptero.Top = helicoptero.Top - 6;
                helicoptero.Image = Resources.ss;
               
            }
            if (evento.KeyCode == Keys.Down)
            {
                helicoptero.Top = helicoptero.Top + 6;
                helicoptero.Image = Resources.ss;
            }
            if (evento.KeyCode == Keys.Right)
            {
                helicoptero.Left = helicoptero.Left + 6;
                helicoptero.Image = Resources.ss;
            }
            if (evento.KeyCode == Keys.Left)
            {
                helicoptero.Left = helicoptero.Left - 6;
                helicoptero.Image = Resources.ss2;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            helicoptero.Top = helicoptero.Top + 2;

            if (helicoptero.Bounds.IntersectsWith(edificio1.Bounds))
            {   
                helicoptero.Image = Resources.explosion;
                timer1.Stop();
                helicoptero.Location = new Point(135, 24);
                control_Vidas();
                timer1.Start();
            }
            if (helicoptero.Bounds.IntersectsWith(edificio2.Bounds))
            {
                helicoptero.Image = Resources.explosion;
                timer1.Stop();
                helicoptero.Location = new Point(135, 24);
                control_Vidas();
                timer1.Start();
            }
            if (helicoptero.Bounds.IntersectsWith(edificio3.Bounds))
            {
                helicoptero.Image = Resources.explosion;
                helicoptero.Location = new Point(135, 24);
                control_Vidas();
            }
            if (helicoptero.Bounds.IntersectsWith(edificio4.Bounds))
            {
                helicoptero.Image = Resources.explosion;
                helicoptero.Location = new Point(135, 24);
                control_Vidas();
            }
            if (helicoptero.Bounds.IntersectsWith(coin.Bounds))
            {
                puntaje+=1;
                lbl_puntos.Text = puntaje.ToString();
                SoundPlayer cancion = new SoundPlayer(@"D:\Santiago\SANTIAGO\Desarrollo de Software\V Semestre\herramientas visuales\Nueva carpeta\Juego_Helicoptero_\splash\Resources\coin.wav");
                cancion.Play();
                Random aleatorio = new Random();
                coin.Location = new Point(aleatorio.Next(500), aleatorio.Next(500));
                if (coin.Bounds.IntersectsWith(edificio1.Bounds) || coin.Bounds.IntersectsWith(edificio2.Bounds) || coin.Bounds.IntersectsWith(edificio3.Bounds) || coin.Bounds.IntersectsWith(edificio4.Bounds))
                {
                    coin.Location = new Point(aleatorio.Next(500), aleatorio.Next(500));
                }
                
            }
        }

        public void control_Vidas()
        {
            vidas--;
            switch (vidas)
            {
                case 2:
                    heart3.Visible = false;
                break;
                case 1:
                    heart2.Visible = false;
                break;
                case 0:
                    heart1.Visible = false;
                    MessageBox.Show("HAS PERDIDO PAPU");
                     timer1.Stop();
                     Form4 win2 = new Form4();
                     win2.Show();
                     this.Close();
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
