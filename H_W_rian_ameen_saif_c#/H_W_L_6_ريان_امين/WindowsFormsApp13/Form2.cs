using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Bitmap temp = new Bitmap(textBox1.Text);
            pictureBox1.Image = temp;
          
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            this.AutoSize = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Bitmap temp1 = new Bitmap(@"C:\Users\ENG\Desktop\معمل ويب\٢٠٢٤٠٩١٨_١٦٥٠٥٨.jpg");
            
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BackgroundImage = temp1;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Image = null;

        }
    }
}
