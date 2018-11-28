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
    public partial class Form2 : Form
    {
        public string num { set; get; }
        public String name { set; get; }
        public String customer { set; get; }
        public int sum { set; get; }
        public Form2()
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", this, "num");
            textBox2.DataBindings.Add("Text", this, "name");
            textBox3.DataBindings.Add("Text", this, "customer");
            textBox4.DataBindings.Add("Text", this, "sum");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string f1()
        {
            return num;
        }
        public string f2()
        {
            return name;
        }
        public string f3()
        {
            return customer;
        }
        public int f4()
        {
            return sum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
