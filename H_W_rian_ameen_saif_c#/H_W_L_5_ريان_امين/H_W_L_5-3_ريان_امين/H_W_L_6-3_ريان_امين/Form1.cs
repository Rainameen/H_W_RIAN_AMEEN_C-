using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;

namespace H_W_L_6_3_ريان_امين
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Ismove = true;


        private void Go_to_front_of_Click(object sender, EventArgs e)
        {
            //هنا للتعامل مع زر التحك للامام  بواسطة الخيوظ
            //هنا ولا باستحدام الخيوط 
            //الجزء الامامي الذهاب

            //    threadgo = new Thread(thread_go);
            //threadgo.Start();
            //الجز الامامي العودة

            //    threadback = new Thread(thread_go_back);
            //threadback.Start();
            //ثانيا بدون استخدام الخيوط وكتابة الكود بشكل مباشر
            //الذهاب
            if (Ismove)
            {
                for (int i = 0; i <= this.Width; i++)
                {
                    if (Ismove)
                    {
                        Invoke((Action)(() =>
                        {
                            btnfront_of.Left += 5;
                        }));
                        if (btnfront_of.Left > this.Width)
                            break;
                        Thread.Sleep(50);
                        Application.DoEvents();
                    }
                    else
                        break;
                }
                //الاياب

                for (int i = 0; i <= this.Width; i++)
                {
                    if (Ismove)
                    {
                        Invoke((Action)(() =>
                        {
                            btnfront_of.Left -= 5;
                        }));
                        if (btnfront_of.Left > this.Width)
                            break;

                        Thread.Sleep(50);
                        Application.DoEvents();
                    }
                    else
                        break;
                }
            }
        }

        private void Go_to_down_Click(object sender, EventArgs e)
        {
            //التعامل مع زر التحرك للاسفل
            //الذهاب
            for (int i = 0; i <= this.Height; i++)
            {
                if (Ismove)
                {
                    Invoke((Action)(() =>
                    {
                        btnbottom.Top += 5;
                    }));
                    if (btnbottom.Top > this.Height)
                        break;
                    Thread.Sleep(50);
                    Application.DoEvents();
                }
                else
                    break;
            }
            //الاياب
            for (int i = 0; i <= this.Height; i++)
            {
                if (Ismove)
                {
                    Invoke((Action)(() =>
                    {
                        btnbottom.Top -= 5;
                    }));
                    if (btnbottom.Top > this.Height)
                        break;

                    Thread.Sleep(50);
                    Application.DoEvents();
                }
                else
                    break;
            }

        }

        private void Btnstop_Click(object sender, EventArgs e)
        {
            Ismove = false;

        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
