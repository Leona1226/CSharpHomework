using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework7;

namespace homework7_2
{
    public partial class Form1 : Form
    {
        OrderService os = new OrderService();
        OrderDetails od = new OrderDetails();
        public Form1()
        {
            InitializeComponent();
            os.AddOrder("20181111001", "LeoZB", "Leona", 1000,"13986262878");
            os.AddOrder("20181010003", "JohnnyZB", "wotslb", 2000,"18765438899");
            orderDetailsBindingSource.DataSource = os.list;
            //绑定查询条件
            textBox1.DataBindings.Add("Text", od, "orderNum");
            textBox2.DataBindings.Add("Text", od, "ProductName");
            textBox3.DataBindings.Add("Text", od, "Customer");
            textBox4.DataBindings.Add("Text", od, "sum");
            textBox5.DataBindings.Add("Text", od, "PhoneNum");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.list.Where(s => s.OrderNum == od.OrderNum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.list.Where(s => s.Customer == od.Customer);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.list.Where(s => s.ProductName == od.ProductName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource.DataSource = os.list.Where(s => s.sum == od.sum);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            os.AddOrder(f2.f1(), f2.f2(), f2.f3(), f2.f4(),f2.f5());
            orderDetailsBindingSource.DataSource = os.list.Where(s => s.sum >= 0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            os.AmendOrder(form3.f1(), form3.f2(), form3.f3(), form3.f4(), form3.f5(), form3.f6(), form3.f7(), form3.f8());
            orderDetailsBindingSource.DataSource = os.list.Where(s => s.sum >= 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            os.RemoveOrder(form2.f1(), form2.f2(), form2.f3(), form2.f4());
            orderDetailsBindingSource.DataSource = os.list.Where(s => s.sum>= 0);
        }
    }
}
