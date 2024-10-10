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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

       
            private void Form1_Load(object sender, EventArgs e)
            {
                pictureBox1.Width = pictureBox1.Height = 300;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Red;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                pictureBox1.Image = Image.FromFile(@"C:\Users\ENG\Desktop\معمل ويب\٢٠٢٤٠٩١٨_١٦٥٢٤٢.jpg");
                pictureBox1.BackgroundImage = Image.FromFile(@"\Users\ENG\Desktop\معمل ويب\٢٠٢٤٠٩١٨_١٦٥٠٥٨.jpg");
                toolTip1.SetToolTip(pictureBox1, "picturebox اداة");
                this.AutoSize = true;


            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BackgroundImage = null;
        }
    }
}
