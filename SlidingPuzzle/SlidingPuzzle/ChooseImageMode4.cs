using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    public partial class ChooseImageMode4 : Form
    {
        public ChooseImageMode4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox1.Image);
            mode.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox2.Image);
            mode.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox3.Image);
            mode.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox4.Image);
            mode.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox5.Image);
            mode.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox6.Image);
            mode.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox7.Image);
            mode.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox8.Image);
            mode.Show();
        }

    }
}
