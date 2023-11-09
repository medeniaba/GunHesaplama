using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GünHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int x;



            x = int.Parse(textBox1.Text);

            if (x > 0 == x <= 7) { 
            if (x == 1) textBox2.Text = "pazartesi";
            else if (x == 2) textBox2.Text = "Salı";
            else if (x == 3) textBox2.Text = "Çarşamba";
            else if (x == 4) textBox2.Text = "Perşembe";
            else if (x == 5) textBox2.Text = "Cuma";
            else if (x == 6) textBox2.Text = "Cumartesi";
            else if (x == 7) textBox2.Text = "Pazar"; }
            else             textBox2.Text = "Hatalı değer X ";

               
            

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

