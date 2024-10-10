using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt64(textBox1.Text.Trim());
            double y = Convert.ToInt64(textBox3.Text.Trim());
            double z;
            if (y != 0)
            {
                z = x / y;
                textBox2.Text = z.ToString();
            }
            else
                MessageBox.Show("the process error"," title of error",MessageBoxButtons.YesNoCancel);

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;
            else
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {   if (textBox1.Text != "" && textBox3.Text != "")
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
            else
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;


        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextChanged += TextBox3_TextChanged;
           button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
            this.Text = "الة حاسبة بسيطة";

        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;

        }



        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt64(textBox1.Text.Trim());
            double y = Convert.ToInt64(textBox3.Text.Trim());
            double z = x + y;
            textBox2.Text = z.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            double x = Convert.ToInt64(textBox1.Text.Trim());
            double y = Convert.ToInt64(textBox3.Text.Trim());
            double z = x + y;
            textBox2.Text = z.ToString();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            double x = Convert.ToInt64(textBox1.Text.Trim());
            double y = Convert.ToInt64(textBox3.Text.Trim());
            double z = x - y;
            textBox2.Text = z.ToString();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            double x = Convert.ToInt64(textBox1.Text.Trim());
            double y = Convert.ToInt64(textBox3.Text.Trim());
            double z = x * y;
            textBox2.Text = z.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
