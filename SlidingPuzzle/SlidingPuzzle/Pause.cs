using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace SlidingPuzzle
{
    public partial class Pause : Form
    {
        public Pause()
        {
            InitializeComponent();
        }

        private int WIDTH = 400;
        private int HEIGHT = 500;
        Mode4Game mode4 = new Mode4Game();
        Mode5Game mode5 = new Mode5Game();
        public Pause(string s, Mode4Game m)
        {
            InitializeComponent();
            mode4 = m;
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("./Resources/BMHANNA_11yrs_ttf.ttf");
            Font font = new Font(privateFont.Families[0], 24F);
            currentScoreLabel.Text = s;
        }

        public Pause(string s, Mode5Game m)
        {
            InitializeComponent();
            mode5 = m;
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("./Resources/BMHANNA_11yrs_ttf.ttf");
            Font font = new Font(privateFont.Families[0], 24F);
            currentScoreLabel.Text = s;
        }

        private void Pause_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(WIDTH, HEIGHT);
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_MouseMove(object sender, MouseEventArgs e)
        {
            backButton.BackgroundImage = SlidingPuzzle.Properties.Resources.resumeclick;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackgroundImage = SlidingPuzzle.Properties.Resources.resume;
        }

        private void exitButton_MouseMove(object sender, MouseEventArgs e)
        {
            exitButton.BackgroundImage = SlidingPuzzle.Properties.Resources.exitclick;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackgroundImage = SlidingPuzzle.Properties.Resources.exit;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Close();
            Program.ac.MainForm = main;
            mode4.Close();
            mode5.Close();
            main.Show();
            
        }
    }
}
