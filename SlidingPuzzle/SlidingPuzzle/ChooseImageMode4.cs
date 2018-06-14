﻿using System;
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
        private const int WIDTH = 1000;
        private const int HEIGHT = 800;
        public ChooseImageMode4()
        {
            InitializeComponent();
            ClientSize = new Size(WIDTH, HEIGHT);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox1.Image);
            mode.Show();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox2.Image);
            mode.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox3.Image);
            mode.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox4.Image);
            mode.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox5.Image);
            mode.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox6.Image);
            mode.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox7.Image);
            mode.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Mode4Game mode = new Mode4Game(this, pictureBox8.Image);
            mode.Show();
            this.Close();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "jpg";
            openFile.Filter = "Graphics interchange Format (*.jpg)|*.jpg|All files(*.*)|(*.*)";
            openFile.ShowDialog();

            if (openFile.FileName.Length > 0)
            {
                Image image = Image.FromFile(openFile.FileName);
                Mode4Game mode = new Mode4Game(this, image);
                mode.Show();
            }
        }
        

        private void rankingButton_Click(object sender, EventArgs e)
        {
            RankingMode4 rank = new RankingMode4();
            rank.Show();
        }
    }
}
