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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        public GameOver(string s)
        {
            InitializeComponent();
            currentScoreLabel.Text = s;
        }

        private void backButton_MouseMove(object sender, MouseEventArgs e)
        {
            backButton.BackgroundImage = SlidingPuzzle.Properties.Resources.exitclick;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackgroundImage = SlidingPuzzle.Properties.Resources.exit;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            Program.ac.MainForm = form;
            this.Close();
        }
    }
}
