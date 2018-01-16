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
     
    public partial class Form1 : Form
    {

        PictureBox imgPictureBox= new PictureBox();
        Thread th;
        public Form1()
        {
            InitializeComponent();
            perdio.SendToBack();
           
        }
        int puntaje = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (zombie1.Bounds.IntersectsWith(poder1S.Bounds) || zombie2.Bounds.IntersectsWith(poder1S.Bounds) ||
                zombie3.Bounds.IntersectsWith(poder1S.Bounds) || zombie4.Bounds.IntersectsWith(poder1S.Bounds) ||
                zombie5.Bounds.IntersectsWith(poder1S.Bounds))
            {
                puntaje++;
                poder1S.Left = chaosS.Location.X;
                label1.Text = puntaje.ToString();

            }else if(poder1S.Left>=847){
                poder1S.Left = chaosS.Location.X;

            }

            

            imgPictureBox.Left = imgPictureBox.Left + 20;
            
            poder1S.Left = poder1S.Left + 20;

            if (puntaje == 12)
            {
                timer1.Stop();
                timer2.Stop();
                DialogResult respuesta = MessageBox.Show("HAS SUPERADO EL NIVEL 1 \n PRESIONA <SI> PARA PASAR A NIVEL 2 ", "GANASTE", MessageBoxButtons.YesNo);
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
            Application.Run(new Form2());
        }

       

        


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }


        private void timer2_Tick_1(object sender, EventArgs e)
        {
            zombie1.Left = zombie1.Left - 5;
            zombie2.Left = zombie2.Left - 5;
            zombie3.Left = zombie3.Left - 5;
            zombie4.Left = zombie4.Left - 5;
            zombie5.Left = zombie5.Left - 5;
            inciar();


            if (zombie1.Bounds.IntersectsWith(perdio.Bounds) || zombie2.Bounds.IntersectsWith(perdio.Bounds) ||
                zombie3.Bounds.IntersectsWith(perdio.Bounds) || zombie4.Bounds.IntersectsWith(perdio.Bounds) ||
                zombie5.Bounds.IntersectsWith(perdio.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                DialogResult respuesta = MessageBox.Show("PERDISTE \n DESEAS CONTINUAR?", "PERDISTE", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    puntaje = 0;
                    timer1.Start();
                    timer2.Start();
                    reiniciarZombies();



                }
                else if (respuesta == DialogResult.No)
                {
                    this.Close();
                }

            }
        }
            


        public void inciar()
        {
            if (zombie1.Bounds.IntersectsWith(poder1S.Bounds))
            {

                zombie1.Top = 35;
                zombie1.Left = 845;

            }
            else if (zombie2.Bounds.IntersectsWith(poder1S.Bounds))
            {
                
                zombie2.Top = 109;
                zombie2.Left = 845;
            }
            else if (zombie3.Bounds.IntersectsWith(poder1S.Bounds))
            {
                
                zombie3.Top = 183;
                zombie3.Left = 845;

            }
            else if (zombie4.Bounds.IntersectsWith(poder1S.Bounds))
            {
                
                zombie4.Top = 257;
                zombie4.Left = 845;

            }
            else if (zombie5.Bounds.IntersectsWith(poder1S.Bounds))
            {
                
                zombie5.Top = 331;
                zombie5.Left = 845;

            }

           



        }

        public void reiniciarZombies()
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


       
        
        public void crearpicturBox()
        {
             imgPictureBox= new PictureBox();
            imgPictureBox.Location = new System.Drawing.Point(chaosS.Location.X, chaosS.Location.Y);
            imgPictureBox.Size = new System.Drawing.Size(64, 61);
            imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPictureBox.BackColor = Color.Transparent;
            imgPictureBox.Image = Properties.Resources.poder3;
            Controls.Add(imgPictureBox);
            imgPictureBox.Visible = true;

            

            
        }

                
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                poder1S.Top -= 10;
                chaosS.Top -= 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                poder1S.Top += 10;
                chaosS.Top += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                crearpicturBox();
                

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
