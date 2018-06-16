using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    public partial class Mode4Game : Form
    {
        DateTime date;
        private const int WIDTH = 1000;
        private const int HEIGHT = 800;
        public Mode4Game()
        {
            InitializeComponent();
        }

        ChooseImageMode4 mode4;
        Image image;
        Button[,] buttonArray = new Button[4,4];
        bool playGame = false;
        TimeSpan timeSpan;
        TimeSpan pause;
        public Mode4Game(ChooseImageMode4 form, Image picture)
        {
            InitializeComponent();
            ClientSize = new Size(WIDTH, HEIGHT);
            this.mode4 = form;
            image = picture;
            ResizeImage(600, 600);
            buttonArray = new Button[4, 4]{
                { button1, button2, button3, button4 },
                { button5, button6, button7, button8 },
                { button9, button10, button11, button12 },
                { button13, button14, button15, button16 } };

            for (int i = 0; i < 4; i++)
            {
               int startX = 0;
                for (int j = 0; j < 4; j++) {
                    if (i == 0)
                    {
                        buttonArray[i, j].Image = Crop(image, 150, 150, startX, 0);
                        startX += 150;
                    }
                    else if(i== 1)
                    {
                        buttonArray[i, j].Image = Crop(image, 150, 150, startX, 150);
                        startX += 150;
                    }
                    else if (i == 2)
                    {
                        buttonArray[i, j].Image = Crop(image, 150, 150, startX, 300);
                        startX += 150;
                    }
                    else if (i == 3)
                    {
                        buttonArray[i, j].Image = Crop(image, 150, 150, startX, 450);
                        startX += 150;
                    }
                }
            }
            buttonArray[3, 3].Image = null;
            buttonArray[3, 3].BackColor = Color.Black;

            string path = @"D:\Rank4.txt";
            if (!File.Exists((path)))
                timeHighScoreLabel.Text = "--.--.--------";
            else
            {
                string[] temp = File.ReadAllLines(path);
                string txt = temp[0];
                txt = txt.Substring(0, txt.IndexOf("\t"));
                timeHighScoreLabel.Text = txt;

            }


        }
        
        private void ResizeImage(int width, int height){

            Image image = this.image;
            Image resize = new Bitmap(width, height);
            using(Graphics g = Graphics.FromImage(resize))
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            this.image = resize;
        }

        static Image Crop(Image image, int width, int height, int startX, int startY)
        {
            Bitmap bitmap = new Bitmap(150, 150);
            Graphics graphics = Graphics.FromImage(bitmap);
            int originalWidth = image.Width;
            int originalHeight = image.Height;
            graphics.DrawImage(image,
                new Rectangle(0, 0, width, height),
                new Rectangle(startX, startY, width, height),
                GraphicsUnit.Pixel
                );
            graphics.Dispose();
            return bitmap;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!playGame)
                playGame = true;
            else
                return;
            Random random = new Random();
           
            for(int i = 0; i < 16; i++)
            {
                Image temp;
                string tmp;
                int x = random.Next(0, 4);
                int y = random.Next(0, 4);
                int x2 = random.Next(0, 4);
                int y2 = random.Next(0, 4);
                temp = buttonArray[x, y].Image;
                tmp = buttonArray[x, y].Text;
                buttonArray[x, y].Image = buttonArray[x2, y2].Image;
                buttonArray[x, y].Text = buttonArray[x2, y2].Text;
                buttonArray[x2, y2].Image = temp;
                buttonArray[x2, y2].Text = tmp;
            }

            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (buttonArray[i, j].Image == null)
                    {
                        buttonArray[i, j].BackColor = Color.Black;
                        buttonArray[i, j].Text = "16";
                    }
                    if(buttonArray[i, j].Image != null && buttonArray[i,j].BackColor == Color.Black)
                    {
                        buttonArray[i, j].BackColor = Color.White;
                    }
                }
                
            }
            date = DateTime.Now;
            timer.Enabled = true;
        }
        private void clickButton(int y, int x)
        {
            if (!playGame)
                return;
            int temp;
            if ((x < 3 && buttonArray[y, x + 1].Image == null))
            {
                temp = Convert.ToInt32(buttonArray[y, x + 1].Text);
                buttonArray[y, x + 1].Text = buttonArray[y, x].Text;
                buttonArray[y, x].Text = temp.ToString();
                buttonArray[y, x + 1].Image = buttonArray[y, x].Image;
                buttonArray[y, x + 1].BackColor = Color.Wheat;
                buttonArray[y, x].BackColor = Color.Black;
                buttonArray[y, x].Image = null;
                return;
            }
            else if (x > 0 && (buttonArray[y, x - 1].Image == null))
            {
                temp = Convert.ToInt32(buttonArray[y, x - 1].Text);
                buttonArray[y, x - 1].Text = buttonArray[y, x].Text;
                buttonArray[y, x].Text = temp.ToString();
                buttonArray[y, x - 1].Image = buttonArray[y, x].Image;
                buttonArray[y, x - 1].BackColor = Color.Wheat;
                buttonArray[y, x].BackColor = Color.Black;
                buttonArray[y, x].Image = null;
                return;
            }
            else if (y < 3 && buttonArray[y + 1, x].Image == null)
            {
                temp = Convert.ToInt32(buttonArray[y + 1, x].Text);
                buttonArray[y + 1, x].Text = buttonArray[y, x].Text;
                buttonArray[y, x].Text = temp.ToString();
                buttonArray[y + 1, x].Image = buttonArray[y, x].Image;
                buttonArray[y + 1, x].BackColor = Color.Wheat;
                buttonArray[y, x].BackColor = Color.Black;
                buttonArray[y, x].Image = null;
                return;
            }
            else if (y > 0 && buttonArray[y - 1, x].Image == null)
            {
                temp = Convert.ToInt32(buttonArray[y - 1, x].Text);
                buttonArray[y - 1, x].Text = buttonArray[y, x].Text;
                buttonArray[y, x].Text = temp.ToString();
                buttonArray[y - 1, x].Image = buttonArray[y, x].Image;
                buttonArray[y - 1, x].BackColor = Color.Wheat;
                buttonArray[y, x].BackColor = Color.Black;
                buttonArray[y, x].Image = null;
                return;
            }
            
        }

        private void checkFinish()
        {
            if (!playGame)
                return;
            int cnt = 1;
            for(int y = 0; y < 4; y++)
            {
                for(int x = 0; x < 4; x++)
                {
                    if (Convert.ToInt32(buttonArray[y, x].Text) != cnt)
                        return;
                    else cnt++;
                }
            }

            if(cnt == 17)
            {
                timer.Enabled = false;
                rankingSort(timeScoreLabel.Text);
                MessageBox.Show("축하합니다!");
                playGame = false;
                this.Close();
            }
        }

        private void rankingSort(string s)
        {
            string path = @"D:\Rank4.txt";
            string tmp = String.Copy(s);
            tmp = tmp.Replace(".", "");
            tmp = tmp.Replace(":", "");
            int recentScore = (int)Convert.ToUInt32(tmp);
            int num = 11;
            if (!File.Exists((path)))
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(s + "\t" + DateTime.Now.ToShortDateString());
                sw.Close();
                return;
            }
            string[] scores = File.ReadAllLines(path);
            int[] temp = new int[scores.Length];
            for(int i = 0; i < scores.Length; i++)
            {
                scores[i] = scores[i].Substring(0, scores[i].IndexOf("\t"));
                scores[i] = scores[i].Replace(":", "");
                scores[i] = scores[i].Replace(".", "");
                temp[i] = (int)(Convert.ToInt64(scores[i]));
            }

            for(int i = 0; i < scores.Length; i++)
            {
                if (temp[i] > recentScore)
                {
                    num = i;
                    break;
                }
            }

            if(num == 11 && scores.Length < 10) {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(s + "\t" + DateTime.Now.ToShortDateString());
                sw.Close();
            } else if(num != 11)
            {
                string[] oldscore = File.ReadAllLines(path);
                StreamWriter sw = new StreamWriter(path, false);
                for(int i = 0; i < num; i++)
                {
                    sw.WriteLine(oldscore[i]);
                }
                sw.WriteLine(s + "\t" + DateTime.Now.ToShortDateString());
                
                if(scores.Length < 10)
                {
                    for (int i = num; i < scores.Length; i++)
                        sw.WriteLine(oldscore[i]);
                }
                else
                {
                    for (int i = num; i < 9; i++)
                        sw.WriteLine(oldscore[i]);
                }

                sw.Close();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           clickButton(0, 0);
            checkFinish();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickButton(0, 1);
            checkFinish();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickButton(0, 2);
            checkFinish();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickButton(0, 3);
            checkFinish();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickButton(1, 0);
            checkFinish();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickButton(1, 1);
            checkFinish();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickButton(1, 2);
            checkFinish();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickButton(1, 3);
            checkFinish();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickButton(2, 0);
            checkFinish();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clickButton(2, 1);
            checkFinish();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clickButton(2, 2);
            checkFinish();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clickButton(2, 3);
            checkFinish();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clickButton(3, 0);
            checkFinish();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clickButton(3, 1);
            checkFinish();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clickButton(3, 2);
            checkFinish();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            clickButton(3, 3);
            checkFinish();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeSpan = DateTime.Now - date - pause;
            timeScoreLabel.Text = timeSpan.ToString();
            Invalidate();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (!playGame)
                return;
            DateTime pausetime = DateTime.Now;
            timer.Stop();
            MessageBox.Show("일시정지");
            pause += DateTime.Now - pausetime;
            timer.Start();
        }
    }
}
