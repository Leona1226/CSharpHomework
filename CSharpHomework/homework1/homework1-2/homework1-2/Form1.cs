﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = this.textBox1.Text;
            string s2 = this.textBox2.Text;
            int a = Int32.Parse(s1);
            int b = Int32.Parse(s2);
            int c = a * b;
            this.textBox3.Text = c.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           // string s2 = Console.ReadLine();
            //n2 = Int32.Parse(s2);
            //this.textBox2.Text = n2.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
