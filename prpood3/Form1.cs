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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text ="برنامه کتابخانه" +" "+DateTime.Now.ToLongTimeString();
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
            txt8.Clear();
            txt9.Clear();
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm1= new Form2();
            frm1.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt10.Clear();
            txt11.Clear();
            txt12.Clear();
            txt13.Clear();
            txt5.Clear();
            txt16.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txt1.ForeColor = colorDialog1.Color;
            txt2.ForeColor = colorDialog1.Color;
            txt3.ForeColor = colorDialog1.Color;
            txt4.ForeColor = colorDialog1.Color;
            txt5.ForeColor = colorDialog1.Color;
            txt6.ForeColor = colorDialog1.Color;
            txt7.ForeColor = colorDialog1.Color;
            txt8.ForeColor = colorDialog1.Color;
            txt9.ForeColor = colorDialog1.Color;
            txt10.ForeColor = colorDialog1.Color;
            txt11.ForeColor = colorDialog1.Color;
            txt12.ForeColor = colorDialog1.Color;
            txt13.ForeColor = colorDialog1.Color;
            txt14.ForeColor = colorDialog1.Color;
            txt15.ForeColor = colorDialog1.Color;
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
        }

        private void font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txt1.Font = fontDialog1.Font;
            txt2.Font = fontDialog1.Font;
            txt3.Font = fontDialog1.Font;
            txt4.Font = fontDialog1.Font;
            txt5.Font = fontDialog1.Font;
            txt6.Font = fontDialog1.Font;
            txt7.Font = fontDialog1.Font;
            txt8.Font = fontDialog1.Font;
            txt9.Font = fontDialog1.Font;
            txt10.Font = fontDialog1.Font;
            txt11.Font = fontDialog1.Font;
            txt12.Font = fontDialog1.Font;
            txt13.Font = fontDialog1.Font;
            txt14.Font = fontDialog1.Font;
            txt15.Font = fontDialog1.Font;
            richTextBox1.Font = fontDialog1.Font;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm1 = new Form2();
            frm1.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
         DialogResult aa= MessageBox.Show("آیا از خروج خود اطمینان دارید؟", "خطا", MessageBoxButtons.OKCancel);
            if(aa==DialogResult.OK)
            this.Close();
        }
    }
}
