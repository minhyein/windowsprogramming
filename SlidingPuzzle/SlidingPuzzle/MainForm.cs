using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SlidingPuzzle
{
    public partial class MainForm : Form
    {
        private const int WIDTH = 1000;
        private const int HEIGHT = 800;
        public MainForm()
        {
            InitializeComponent();
            ClientSize = new Size(WIDTH, HEIGHT);
            SoundPlayer soundPlayer = new SoundPlayer(SlidingPuzzle.Properties.Resources.Aquarium);
            soundPlayer.PlayLooping();
        }

        private void mode4Button_Click(object sender, EventArgs e)
        {
            ChooseImageMode4 form = new ChooseImageMode4();
            form.Show();
            Program.ac.MainForm = form;
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void mode5Button_Click(object sender, EventArgs e)
        {
            ChooseImageMode5 form = new ChooseImageMode5();
            form.Show();
            Program.ac.MainForm = form;
            this.Close();
        }
        
        private void mode4Button_MouseMove(object sender, MouseEventArgs e)
        {
            mode4Button.Image = SlidingPuzzle.Properties.Resources.그림2;
        }

        private void mode5Button_MouseMove(object sender, MouseEventArgs e)
        {
            mode5Button.Image = SlidingPuzzle.Properties.Resources.그림3;
        }

        private void mode5Button_MouseLeave(object sender, EventArgs e)
        {
            mode5Button.Image = SlidingPuzzle.Properties.Resources.그림4;
        }

        private void mode4Button_MouseLeave(object sender, EventArgs e)
        {
            mode4Button.Image = SlidingPuzzle.Properties.Resources.그림1;
        }
    }
}
