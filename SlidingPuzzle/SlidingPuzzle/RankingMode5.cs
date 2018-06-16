using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SlidingPuzzle
{
    public partial class RankingMode5 : Form
    {
        private const int WIDTH = 1000;
        private const int HEIGHT = 800;
        public RankingMode5()
        {
            InitializeComponent();
            ClientSize = new Size(WIDTH, HEIGHT);
        }

        private void RankingMode5_Load(object sender, EventArgs e)
        {
            string path = @"d:\Rank5.txt";
            if (!File.Exists(path))
                rankingTextBox.Text = "저장된 기록이 없습니다.";
            else
            {
                string ranking = File.ReadAllText(path);
                rankingTextBox.Text = ranking;
            }
        }
    }
}
