using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace juegoPvsZ
{
    public partial class Form2 : Form
    {
        Thread th;
        public Form2()
        {
            InitializeComponent();
            perdio.SendToBack();
        }
        int puntaje = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (zombie1.Bounds.IntersectsWith(poder2S.Bounds) || zombie2.Bounds.IntersectsWith(poder2S.Bounds) ||
                zombie3.Bounds.IntersectsWith(poder2S.Bounds) || zombie4.Bounds.IntersectsWith(poder2S.Bounds) ||
                zombie5.Bounds.IntersectsWith(poder2S.Bounds))
            {
                puntaje++;
                poder2S.Left = gokuS.Location.X;
                label1.Text = puntaje.ToString();

            }
            else if (poder2S.Left >= 847)
            {
                poder2S.Left = gokuS.Location.X;

            }


            poder2S.Left = poder2S.Left + 20;

            if (puntaje == 1)
            {
                timer1.Stop();
                timer2.Stop();
                DialogResult respuesta = MessageBox.Show("GANASTE..!! \n PRESIONA <SI> PARA PASAR A NIVEL 3 ", "GANASTE", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
        }

        private void opennewform(object obj)
        {
            Application.Run(new nivel3());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            zombie1.Left = zombie1.Left - 7;
            zombie2.Left = zombie2.Left - 7;
            zombie3.Left = zombie3.Left - 7;
            zombie4.Left = zombie4.Left - 7;
            zombie5.Left = zombie5.Left - 7;
            inciar();


            if (zombie1.Bounds.IntersectsWith(perdio.Bounds) || zombie2.Bounds.IntersectsWith(perdio.Bounds) ||
                zombie3.Bounds.IntersectsWith(perdio.Bounds) || zombie4.Bounds.IntersectsWith(perdio.Bounds) ||
                zombie5.Bounds.IntersectsWith(perdio.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                DialogResult respuesta = MessageBox.Show("perdiste \n desea continuar?", "perdiste", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    puntaje = 0;
                    timer1.Start();
                    timer2.Start();
                    reiniciarJuego();
                    


                }
            }
        }


        public void inciar()
        {
            if (zombie1.Bounds.IntersectsWith(poder2S.Bounds))
            {

                zombie1.Top = 35;
                zombie1.Left = 845;

            }
            else if (zombie2.Bounds.IntersectsWith(poder2S.Bounds))
            {

                zombie2.Top = 109;
                zombie2.Left = 845;
            }
            else if (zombie3.Bounds.IntersectsWith(poder2S.Bounds))
            {

                zombie3.Top = 183;
                zombie3.Left = 845;

            }
            else if (zombie4.Bounds.IntersectsWith(poder2S.Bounds))
            {

                zombie4.Top = 257;
                zombie4.Left = 845;

            }
            else if (zombie5.Bounds.IntersectsWith(poder2S.Bounds))
            {

                zombie5.Top = 331;
                zombie5.Left = 845;

            }





        }

        public void reiniciarJuego()
        {


            zombie1.Top = 35;
            zombie1.Left = 845;

            zombie2.Top = 109;
            zombie2.Left = 845;

            zombie3.Top = 183;
            zombie3.Left = 845;

            zombie4.Top = 257;
            zombie4.Left = 845;

            zombie5.Top = 331;
            zombie5.Left = 845;



        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                poder2S.Top -= 10;
                gokuS.Top -= 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                poder2S.Top += 10;
                gokuS.Top += 10;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void perdio_Click(object sender, EventArgs e)
        {

        }

        private void zombie5_Click(object sender, EventArgs e)
        {

        }

        private void zombie4_Click(object sender, EventArgs e)
        {

        }

        private void zombie3_Click(object sender, EventArgs e)
        {

        }

        private void zombie1_Click(object sender, EventArgs e)
        {

        }

        private void zombie2_Click(object sender, EventArgs e)
        {

        }

        private void gokuS_Click(object sender, EventArgs e)
        {

        }

        private void poder2S_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




    }
}
