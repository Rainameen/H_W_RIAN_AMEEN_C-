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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            //textBox1.Enabled = false;
            openFileDialog1.Title = "اختر صورة";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;*.gif|ALL Files|*.*";
            openFileDialog1.Filter = "Image Files|*.jpg;*.png|ALL Files|*.*";// الواجب 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                Bitmap mybitmap = new Bitmap(filename);
                pictureBox1.Image = mybitmap;
                textBox1.Text = filename;// لجعل المسار ينتج بعد عمليه اضافه اصوره واجب
            }
            else
            {
                MessageBox.Show("ادخل الامتداد الصحيح للصور !!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
        }
    }
}
