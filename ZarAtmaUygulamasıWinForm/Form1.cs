using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaUygulamasıWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.CadetBlue;
            timer2.Interval = 1000;
        }
        int sayac = 0;
        int zar1, zar2;
        private void button1_Click(object sender, EventArgs e)
        {
                Image myimage = new Bitmap(@"C:\Users\103AKSAM_BİROL\Source\Github\ZarAtmaUygulamas-WinForm-master\fotolar\ekremabisilah.jpg");
                this.BackgroundImage = myimage;
                DialogResult dr = MessageBox.Show(this, "kendi payının ... koymak istiyormusun?", "Title", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                myimage = new Bitmap(@"C:\Users\103AKSAM_BİROL\Source\Github\ZarAtmaUygulamas-WinForm-master\fotolar\EdohiUOWkAALk8Q.jpg");
                //myimage = Image.FromFile(@"C:\Users\103AKSAM_BİROL\OneDrive\Masaüstü\a1.png");
                this.BackgroundImage=myimage;
                DialogResult ab = MessageBox.Show(this, "son kararın mı?", "Title", MessageBoxButtons.YesNo);
                    if (ab == DialogResult.Yes)
                    {
                     this.Close();
                    }
                    else
                    {
                    MessageBox.Show("emin olunamadı");
                    }
                }
                else
                {
                MessageBox.Show("koyulamadı");
                }

        }

   
    
       
        private void timer1_Tick(object sender, EventArgs e)
        {
          

            Random rnd = new Random();
            zar1 = rnd.Next(1, 7);
            zar2 = rnd.Next(1, 7);
            switch (zar1)
            {
                case 1:
                    pictureBox1.Image = ımageList1.Images[0];
                        break;
                case 2:
                    pictureBox1.Image = ımageList1.Images[1];
                    break;
                case 3:
                    pictureBox1.Image = ımageList1.Images[2];
                    break;
                case 4:
                    pictureBox1.Image = ımageList1.Images[3];
                    break;
                case 5:
                    pictureBox1.Image = ımageList1.Images[4];
                    break;
                case 6:
                    pictureBox1.Image = ımageList1.Images[5];
                    break;
                default:
                    break;
            }
            switch (zar2)
            {
                case 1:
                    pictureBox2.Image = ımageList1.Images[0];
                    break;
                case 2:
                    pictureBox2.Image = ımageList1.Images[1];
                    break;
                case 3:
                    pictureBox2.Image = ımageList1.Images[2];
                    break;
                case 4:
                    pictureBox2.Image = ımageList1.Images[3];
                    break;
                case 5:
                    pictureBox2.Image = ımageList1.Images[4];
                    break;
                case 6:
                    pictureBox2.Image = ımageList1.Images[5];
                    break;
            }
            textBox2.Text = Convert.ToString(zar1 + zar2);
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }
        int time = 1;

        private void timer2_Tick(object sender, EventArgs e)
        {
            time++;
            textBox3.Visible = true;
            textBox3.Text = time.ToString();

        }

        private void btn_ZarAt_Click_1(object sender, EventArgs e)
        {
            sayac += 1;
            timer2.Start();
            timer1.Start();
            label1.Visible = false;
            textBox1.Visible = false;
            for (int i = 0; i < 1000; i++)
            {
                if(sayac % 2 == 0)
                {
                timer1.Stop();
                    if (zar1 + zar2 == 12)
                    {
                        label1.Visible = true;
                        textBox1.Visible = true;
                        label1.Text = "Düşeş";
                        textBox1.Text = "Akıyo Bu Akşam Maşallah";
                    }
                    else if (zar1 +zar2 == 2)
                    {
                        textBox1.Visible = true;
                        textBox1.Text = "Böyle Adama Pamuk Mu Tıkılır Be";
                    }
                }
            }
           



        }
    }
}
