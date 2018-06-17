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
    public partial class ChooseImageMode5 : Form
    {
        private const int WIDTH = 1000;
        private const int HEIGHT = 800;
        public ChooseImageMode5()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mode5Game mode = new Mode5Game(this, pictureBox1.Image);
            mode.Show();
            Program.ac.MainForm = mode;
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mode5Game mode = new Mode5Game(this, pictureBox2.Image);
            mode.Show();
            Program.ac.MainForm = mode;
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mode5Game mode = new Mode5Game(this, pictureBox3.Image);
            mode.Show();
            Program.ac.MainForm = mode;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Mode5Game mode = new Mode5Game(this, pictureBox4.Image);
            mode.Show();
            Program.ac.MainForm = mode;
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Mode5Game mode = new Mode5Game(this, pictureBox5.Image);
            mode.Show();
            Program.ac.MainForm = mode;
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Mode5Game mode = new Mode5Game(this, pictureBox6.Image);
            mode.Show();
            Program.ac.MainForm = mode;
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Mode5Game mode = new Mode5Game(this, pictureBox7.Image);
            mode.Show();
            Program.ac.MainForm = mode;
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Mode5Game mode = new Mode5Game(this, pictureBox8.Image);
            mode.Show();
            Program.ac.MainForm = mode;
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
                Mode5Game mode = new Mode5Game(this, image);
                mode.Show();
                Program.ac.MainForm = mode;
                this.Close();
            }
        }

        private void rankingButton_Click(object sender, EventArgs e)
        {
            RankingMode5 rank = new RankingMode5();
            rank.Show();
        }

        private void rankingButton_MouseMove(object sender, MouseEventArgs e)
        {
            rankingButton.BackgroundImage = SlidingPuzzle.Properties.Resources.rankingclick;
        }

        private void rankingButton_MouseLeave(object sender, EventArgs e)
        {
            rankingButton.BackgroundImage = SlidingPuzzle.Properties.Resources.ranking;
        }

        private void ChooseImageMode5_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(WIDTH, HEIGHT);
        }
    }
}
