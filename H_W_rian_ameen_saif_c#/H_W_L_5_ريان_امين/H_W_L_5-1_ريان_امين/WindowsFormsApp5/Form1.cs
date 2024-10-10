using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label2.ForeColor = Color.Red;
            else if (radioButton2.Checked)
                label2.ForeColor = Color.Green;
            else if (radioButton3.Checked)
                label2.ForeColor = Color.White;
            else if (radioButton2.Checked)
                label2.ForeColor = Color.Black;

            if (radioButton5.Checked)
                label2.BackColor = Color.Green;
            else if (radioButton6.Checked)
                label2.BackColor = Color.Red;
            else if (radioButton7.Checked)
                label2.BackColor = Color.Black;
            else if (radioButton8.Checked)
                label2.BackColor = Color.White;

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        { int s=0;
            if (checkBox1.Checked)
                s = s + Convert.ToInt32(checkBox1.Text);
            if (checkBox2.Checked)
                s = s + Convert.ToInt32(checkBox2.Text);
            if (checkBox3.Checked)
                s = s + Convert.ToInt32(checkBox3.Text);

            textBox1.Text = s.ToString();

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
