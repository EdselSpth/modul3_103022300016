using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b, jumlah;
        bool plus = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 1;
            }
            else
            {
                b = b * 10 + 1;
            }
            label3.Text = a + " + " + b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 2;
            }
            else
            {
                b = b * 10 + 2;
            }
            label3.Text = a + " + " + b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 3;
            }
            else
            {
                b = b * 10 + 3;
            }
            label3.Text = a + " + " + b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 4;
            }
            else
            {
                b = b * 10 + 4;
            }
            label3.Text = a + " + " + b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 5;
            }
            else
            {
                b = b * 10 + 5;
            }
            label3.Text = a + " + " + b;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 6;
            }
            else
            {
                b = b * 10 + 6;
            }
            label3.Text = a + " + " + b;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 7;
            }
            else
            {
                b = b * 10 + 7;
            }
            label3.Text = a + " + " + b;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 8;
            }
            else
            {
                b = b * 10 + 8;
            }
            label3.Text = a + " + " + b;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 9;
            }
            else
            {
                b = b * 10 + 9;
            }
            label3.Text = a + " + " + b;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 0;
            }
            else
            {
                b = b * 10 + 0;
            }
            label3.Text = a + " + " + b;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_tambah_Click(object sender, EventArgs e)
        {
            plus = true;
            
        }

        private void button_samadengan_Click(object sender, EventArgs e)
        {
            jumlah = a + b;
            label3.Text = a + " + " + b;
            label1.Text = "Hasil = " + jumlah;
            a = jumlah;
            b = 0;
        }
    }
}
