using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Text;

namespace SlidingPuzzle
{
    public partial class RankingMode4 : Form
    {
        private const int WIDTH = 1000;
        private const int HEIGHT = 800;
        public RankingMode4()
        {
            InitializeComponent();
            
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(WIDTH, HEIGHT);
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("./Resources/BMHANNA_11yrs_ttf.ttf");
            Font font = new Font(privateFont.Families[0], 20F, FontStyle.Bold);
            Label[] labelArray = new Label[10] {
                scoreLabel1, scoreLabel2, scoreLabel3, scoreLabel4, scoreLabel5,
                scoreLabel6, scoreLabel7, scoreLabel8, scoreLabel9, scoreLabel10
            };
            string path = Application.StartupPath + @"\Rank4.txt";
            if (!File.Exists(path))
            {
                scoreLabel1.Text = "저장된 기록이 없습니다.";
                scoreLabel1.Font = font;
            }
            else
            {
                string[] scores = File.ReadAllLines(path);

                for (int i = 0; i < scores.Length; i++)
                {
                    labelArray[i].Text = scores[i];
                    labelArray[i].Font = font;
                }
            }
        }
        
    }
}
