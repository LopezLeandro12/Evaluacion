using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartProgress(); 
               
 
          
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private async void StartProgress()
        {
            progressBar1.Value = 0;
            lbl_nombre_evo.Text = "V-Mon!";

            while (progressBar1.Value < 100)
            {
                progressBar1.Value++;

                if (progressBar1.Value < 45)
                {
                    pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_09_23_at_10_29_32_PM;
                }
                else if (progressBar1.Value < 75)
                {
                    pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_09_23_at_10_31_02_PM;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_09_23_at_10_35_21_PM;
                }

                if (progressBar1.Value == 45)
                {
                    lbl_nombre_evo.Text = "XV-Mon!!!";
                }
                else if (progressBar1.Value == 75)
                {
                    lbl_nombre_evo.Text = "Paildramon!!!";

                }
                await Task.Delay(500); 
            }
        }

       

        private void lbl_nombre_evo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
