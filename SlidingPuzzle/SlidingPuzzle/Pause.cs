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
    public partial class Pause : Form
    {
        public Pause()
        {
            InitializeComponent();
        }

        private int WIDTH = 400;
        private int HEIGHT = 500;
        public Pause(string s)
        {
            InitializeComponent();
            ClientSize = new Size(WIDTH, HEIGHT);
            currentScoreLabel.Text = s;
        }

        private void Pause_Load(object sender, EventArgs e)
        {

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
    }
}
