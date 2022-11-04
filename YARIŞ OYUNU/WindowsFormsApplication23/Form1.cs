using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carcesici1.Ctlcontrols.stop();
            carcesici2.Ctlcontrols.stop();
            carcesici3.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            button1.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel5.BackColor = Color.GreenYellow;
            panel6.BackColor = Color.Linen;
            panel7.BackColor = Color.Linen;
            panel8.BackColor = Color.Linen;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel7.BackColor = Color.Linen;
            panel8.BackColor = Color.Linen;
            panel6.BackColor = Color.GreenYellow;
            panel5.BackColor = Color.Linen;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            panel7.BackColor = Color.GreenYellow;
            panel8.BackColor = Color.Linen;
            panel6.BackColor = Color.Linen;
            panel5.BackColor = Color.Linen;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel8.BackColor = Color.GreenYellow;
            panel7.BackColor = Color.Linen;
            panel5.BackColor = Color.Linen;
            panel6.BackColor = Color.Linen;
        }
        string tahmin;
        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            carcesici1.Ctlcontrols.stop();
            carcesici2.Ctlcontrols.stop();
            carcesici3.Ctlcontrols.stop();
            carsesi.URL = "yarışses.mp4";
            pictureBox1.ImageLocation = "zaman.gif";
            timer1.Start();

            if (radioButton1.Checked)
            {
                tahmin = "araba2";
            }
            if (radioButton2.Checked)
            {
                tahmin = "araba4";
            }
            if (radioButton3.Checked)
            {
                tahmin = "araba1";
            }
            if (radioButton5.Checked)
            {
                tahmin = "araba3";
            }
            
            

        }
           
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Random hadi = new Random();
            int ar1 = hadi.Next(2, 17);
            int ar2 = hadi.Next(2, 17);
            int ar3 = hadi.Next(2, 17);
            int ar4 = hadi.Next(2, 17);

            pictureBox2.Left += ar1;
            pictureBox3.Left += ar2;
            pictureBox4.Left += ar3;
            pictureBox5.Left += ar4;

            if (pictureBox2.Left >= 789)
            {
                timer1.Stop();
                if (tahmin == "araba1")
                {
                    carsesi.Ctlcontrols.stop();
                    pictureBox1.ImageLocation = "kazanma.gif";
                    axWindowsMediaPlayer1.URL = "kazanmamüzik.mp3";
                    MessageBox.Show("TEBRİKLER KAZANDINIZ!!!");
                    this.Height = 616;             
                }
                else
                {
                    carsesi.Ctlcontrols.stop();
                    pictureBox1.ImageLocation = "üzülme.gif";
                    axWindowsMediaPlayer1.URL = "kaybetmemüzik.mp3";
                    MessageBox.Show("MALESEF KAZANAMADINIZ!!!");
                    this.Height = 616;
                    
                }
            }
            else if (pictureBox3.Left >= 789)
            {
                timer1.Stop();
                if (tahmin == "araba2")
                {
                    carsesi.Ctlcontrols.stop();
                    pictureBox1.ImageLocation = "kazanma.gif";
                    axWindowsMediaPlayer1.URL = "kazanmamüzik.mp3";
                    MessageBox.Show("TEBRİKLER KAZANDINIZ!!!");
                    this.Height = 616;
                    
                }
                else
                {
                    carsesi.Ctlcontrols.stop();
                    pictureBox1.ImageLocation = "üzülme.gif";
                    axWindowsMediaPlayer1.URL = "kaybetmemüzik.mp3";
                    MessageBox.Show("MALESEF KAZANAMADINIZ!!!");
                    this.Height = 616;
                   
                }
            }
            else if (pictureBox4.Left >= 789)
            {
                timer1.Stop();
                if (tahmin == "araba3")
                {
                    carsesi.Ctlcontrols.stop();
                    pictureBox1.ImageLocation = "kazanma.gif";
                    axWindowsMediaPlayer1.URL = "kazanmamüzik.mp3";
                    MessageBox.Show("TEBRİKLER KAZANDINIZ!!!");
                    this.Height = 616;
                    
                }
                else
                {
                    carsesi.Ctlcontrols.stop();
                    pictureBox1.ImageLocation = "üzülme.gif";
                    axWindowsMediaPlayer1.URL = "kaybetmemüzik.mp3";
                    MessageBox.Show("MALESEF KAZANAMADINIZ!!!");
                    this.Height = 616;
                    
                }
            }

            else if (pictureBox5.Left >= 789)
            {
                timer1.Stop();
                if (tahmin == "araba4")
                {
                    carsesi.Ctlcontrols.stop();
                    pictureBox1.ImageLocation = "kazanma.gif";
                    axWindowsMediaPlayer1.URL = "kazanmamüzik.mp3";
                    MessageBox.Show("TEBRİKLER KAZANDINIZ!!!");
                    this.Height = 616;
                    
                    
                }
                else
                {
                    carsesi.Ctlcontrols.stop();
                    pictureBox1.ImageLocation = "üzülme.gif";
                    axWindowsMediaPlayer1.URL = "kaybetmemüzik.mp3";
                    MessageBox.Show("MALESEF KAZANAMADINIZ!!!");
                    this.Height = 616;
                    
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "bekleme.gif";
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
            pictureBox5.Left = 0;
            this.Height = 572;
            button1.Enabled = false;
            button3.Enabled = true;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            carcesici1.URL = "kesilmişar.mp4";
            carcesici2.URL = "arabakes1.mp4";
            carcesici3.URL = "arabakes.mp4";

        }
    }
}
