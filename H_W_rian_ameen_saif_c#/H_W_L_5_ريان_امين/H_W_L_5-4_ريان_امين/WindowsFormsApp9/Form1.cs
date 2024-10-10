using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            this.Height = comboBox1.Height + 120;
            this.Width = panel1.Width + 70;

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                panel1.Visible = true;
                Height = panel1.Height + 130;
                Width = panel1.Width + 70;
                panel1.BackColor = Color.Aquamarine;
                label1.Text = "+";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                panel1.Visible = true;
                Height = panel1.Height + 130;
                Width = panel1.Width + 70;
                panel1.BackColor = Color.Green;
                label1.Text = "-";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                panel1.Visible = true;
                Height = panel1.Height + 130;
                Width = panel1.Width + 70;
                panel1.BackColor = Color.Red;
                label1.Text = "*";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                panel1.Visible = true;
                Height = panel1.Height + 130;
                Width = panel1.Width + 70;
                panel1.BackColor = Color.Brown;
                label1.Text = "/";
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (Convert.ToInt32(textBox2.Text) != 0)
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
                else
                    MessageBox.Show("error divided by zero");

            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar == 8)
                e.Handled = true;
        }
    }
}
