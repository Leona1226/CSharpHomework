using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = this.textBox1.Text;
            string s2 = this.textBox2.Text;
            string s3 = this.textBox3.Text;
            string s4 = this.textBox4.Text;
            string s5 = this.textBox5.Text;
            th1 = Int32.Parse(s1) * Math.PI / 180;
            th2 = Int32.Parse(s2) * Math.PI / 180;
            per1 = double.Parse(s3);
            per2 = double.Parse(s4);
            k = double.Parse(s5);
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        double k = 0.5;
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawLine(x0, y0, x2, y2);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th-th2);
            
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(Pens.YellowGreen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        { }
        private void label3_Click(object sender, EventArgs e)
        { }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
 }
