using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public double x0 = 0.12;
        public double xk = 0.64;
        public double dx = 0.2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            double x = x0;
            while (x <= 0.64)
            {
                double y = Math.Pow((Math.Log(Math.Sin(Math.Pow(x,3) + 0.0025))),3/2)+0.08*Math.Pow(10,-3);
                textBox4.Text += "X= " + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0.12";
            textBox2.Text = "0.64";
            textBox3.Text = "0.2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
