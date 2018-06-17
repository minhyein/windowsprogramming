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
            Label[] labelArray = new Label[10] {
                scoreLabel1, scoreLabel2, scoreLabel3, scoreLabel4, scoreLabel5,
                scoreLabel6, scoreLabel7, scoreLabel8, scoreLabel9, scoreLabel10
            };
            string path = @"d:\Rank5.txt";
            if (!File.Exists(path))
            {
                scoreLabel1.Text = "저장된 기록이 없습니다.";
            }
            else
            {
                string[] scores = File.ReadAllLines(path);

                for (int i = 0; i < scores.Length; i++)
                {
                    labelArray[i].Text = scores[i];
                }
            }
        }
    }
}
