using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prpood3
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "ادمین" && textBox1.Text == "123")
            {
                this.Hide();
                Form1 Frm = new Form1();
                Frm.Show();
                Frm.tabPage2.Enabled = true;
                Frm.tabPage3.Enabled = true;
            }
            else
                MessageBox.Show("اطلاعات وارد شده معتبر نیست", "هشدار");
           }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
