using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7_2
{
    public partial class Form3 : Form
    {
        public int num1 { set; get; }
        public String name1 { set; get; }
        public String customer1 { set; get; }
        public int sum1 { set; get; }
        public int num { set; get; }
        public String name { set; get; }
        public String customer { set; get; }
        public int sum { set; get; }
        public Form3()
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", this, "num1");
            textBox2.DataBindings.Add("Text", this, "name1");
            textBox3.DataBindings.Add("Text", this, "customer1");
            textBox4.DataBindings.Add("Text", this, "sum1");
            textBox5.DataBindings.Add("Text", this, "num");
            textBox6.DataBindings.Add("Text", this, "name");
            textBox7.DataBindings.Add("Text", this, "customer");
            textBox8.DataBindings.Add("Text", this, "sum");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public int f1()
        {
            return num1;
        }
        public string f2()
        {
            return name1;
        }
        public string f3()
        {
            return customer1;
        }
        public int f4()
        {
            return sum1;
        }
        public int f5()
        {
            return num;
        }
        public string f6()
        {
            return name;
        }
        public string f7()
        {
            return customer;
        }
        public int f8()
        {
            return sum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
