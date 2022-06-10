using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Random random = new Random();
            int[] pole = new int[6];
            int[] cisla = new int[6];

            for (int i = 0; i < 6; i++)
            {
                int a = random.Next(1, 6);
                pole[i] = a;
                cisla[i] = 0;

            }

            pictureBox1.Image = Image.FromFile("..\\..\\Resources\\" + pole[0] + ".jpg");
            pictureBox2.Image = Image.FromFile("..\\..\\Resources\\" + pole[1] + ".jpg");
            pictureBox3.Image = Image.FromFile("..\\..\\Resources\\" + pole[2] + ".jpg");
            pictureBox4.Image = Image.FromFile("..\\..\\Resources\\" + pole[3] + ".jpg");
            pictureBox5.Image = Image.FromFile("..\\..\\Resources\\" + pole[4] + ".jpg");
            pictureBox6.Image = Image.FromFile("..\\..\\Resources\\" + pole[5] + ".jpg");


            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if(pole[i] == j)
                    {
                        cisla[j]++;
                    }
                }
            }

            string text = "";
            for (int i = 0; i < pole.Length; i++)
            {
                if (cisla[i] != 0)
                {
                    text += cisla[i];
                }
            }

            if(text.Contains("222"))
            {
                //MessageBox.Show("3 dvojce");
                pictureBox7.BackColor = Color.Green;
            }else if (text.Contains("3"))
            {
                //MessageBox.Show("trojce");
                pictureBox7.BackColor = Color.Green;
            } else if (text.Contains("111111"))
            {
                //MessageBox.Show("postupka");
                pictureBox7.BackColor = Color.Green;
            } else
            {
                pictureBox7.BackColor = Color.Red;
            }




            //MessageBox.Show(string.Join("", pole));
            //MessageBox.Show(string.Join("", cisla));

            

        }
    }
}
