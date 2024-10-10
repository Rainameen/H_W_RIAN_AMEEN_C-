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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        // دالة لرسم المربع داخل الفورم
        private void DrawSquareInForm()
        {
            Graphics g = this.CreateGraphics();

            // حجم المربع (داخل الفورم)
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // جعل المربع يغطي 100% من الفورم
            int formSquareSize = Math.Min(formWidth, formHeight) ;

            // إحداثيات بداية المربع (داخل الفورم)
            int formStartX = (formWidth - formSquareSize) ;
            int formStartY = (formHeight - formSquareSize) ;

            // مسح أي رسومات سابقة على الفورم
            g.Clear(this.BackColor);

            // رسم المربع باستخدام كائن الرسومات
            g.DrawRectangle(Pens.Red, formStartX, formStartY, formSquareSize, formSquareSize);
        }


        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Bitmap temp = new Bitmap(pictureBox1.Width, pictureBox1.Height);


            for (int i = 10; i < 100; i++)
            {
                temp.SetPixel(i, 10, Color.Maroon);
                temp.SetPixel(10, i, Color.Maroon);
                temp.SetPixel(100, i, Color.Maroon);
                temp.SetPixel(i, 100, Color.Maroon);
            }
            pictureBox1.Image = temp;

            DrawSquareInForm();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }
    }
    
}
