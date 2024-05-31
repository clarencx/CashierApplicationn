using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplicationn
{
    public partial class Form1 : Form
    {
        private DiscountedItem_ discountedItem_;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double price = Convert.ToDouble(textBox2.Text);
            int quantity = Convert.ToInt32(textBox4.Text);
            double discount = Convert.ToDouble(textBox3.Text);
            discountedItem_ = new DiscountedItem_(name, price, quantity, discount);
            double tP = discountedItem_.getTotalPrice();
            TotalAmount2.Text = tP.ToString();
        }

        private void TotalAmount2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            discountedItem_.setPayment(Convert.ToDouble(textBox5.Text));
            double change = discountedItem_.getChange();
            Change2.Text = change.ToString();
        }
    }
}
