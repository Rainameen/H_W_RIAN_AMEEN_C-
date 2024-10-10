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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        int ns = -1,s=0, m = 0, h = 0, y = 0 ,d=0;

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ns++;
            if (ns > 9)
                label1.Text = ns.ToString();
            else
                label1.Text = "0" + ns.ToString();
            if (ns > 59)
            {

                ns = 0;
                s += 1;
              
                if (s > 9)
                    label2.Text = s.ToString();
                else
                    label2.Text = "0" + s.ToString();
            }
            if (s >= 59)
            {

                s = 0;
                m++;
               
                if (m > 9)
                    label3.Text =  m.ToString() + ":";
                else
                    label3.Text = "0" + m.ToString() + ":";
            }
            if (m> 59)
            {

                m = 0;
                h++;
                
                if (h > 9)
                    label4.Text = h.ToString() + ":";
                else
                    label4.Text = "0" + h.ToString() + ":";
            }
            if (h > 24)
            {
                d++;
                h = 0;
                s = 0;
                m = 5;
               label6.Text = d.ToString();

            }
        }
    }
}
