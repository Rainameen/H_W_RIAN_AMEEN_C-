using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            player.Size = new Size(player.Width , player.Height + 5);

        }

        private void Player_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            player.Size = new Size(player.Width-5 ,player.Height);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            player.Top -= 5;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            player.Size = new Size(player.Width, player.Height-5);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            player.Size = new Size(player.Width, player.Height + 5);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            player.Size = new Size(player.Width + 5, player.Height);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            player.Top += 5;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            player.Left += 5;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            player.Left -= 5;
        }

      
    }
}
