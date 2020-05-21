using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 245)
            {
                timer1.Stop();
                timer2.Start();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 143)
            {
                timer2.Stop();
                timer3.Start();



            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 324)
            {
                timer3.Stop();
                timer4.Start();
              

            }
        }
    

      private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >= 232)
            {
                timer4.Stop();
                timer5.Start();
            }
            
                
            }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if(pictureBox1.Top<=247)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >= 340)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if(pictureBox1.Top <=61)
            {
                timer7.Stop();
                timer8.Start();
            }

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >=601)
            {
                timer8.Stop();
                timer9.Start();
            }

        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if(pictureBox1.Top >= 271)
            {
                timer9.Stop();
                timer10.Start();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if(pictureBox1.Left <= 521)
            {
                timer10.Stop();
                timer11.Start();
            }

        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if(pictureBox1.Top >= 408)
            {
                timer11.Stop();
                timer12.Start();
            }
            
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >= 693)
            {
                timer12.Stop();
                timer13.Start();
            }

        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if(pictureBox1.Top >= 446)
            {
                timer13.Stop();
            }
        }
    }

        
    }
        
  


