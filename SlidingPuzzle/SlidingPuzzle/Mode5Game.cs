﻿using System;
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
    public partial class Mode5Game : Form
    {
        DateTime date;
        private const int WIDTH = 1000;
        private const int HEIGHT = 800;
        ChooseImageMode5 mode5;
        Image image;
        Button[,] buttonArray = new Button[5, 5];
        bool playGame = false;
        TimeSpan timeSpan;
        TimeSpan pause;

        public Mode5Game()
        {
            InitializeComponent();
        }

        public Mode5Game(ChooseImageMode5 form, Image picture)
        {
            InitializeComponent();
            ClientSize = new Size(WIDTH, HEIGHT);
            this.mode5 = form;
            image = picture;
            ResizeImage(600, 600);
            buttonArray = new Button[5, 5]{
                { button1, button2, button3, button4, button5 },
                { button6, button7, button8, button9, button10 },
                { button11, button12, button13, button14, button15 },
                { button16, button17, button18, button19, button20 },
                { button21, button22, button23, button24, button25 } };

            for (int i = 0; i < 5; i++)
            {
                int startX = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0)
                    {
                        buttonArray[i, j].Image = Crop(image, 120, 120, startX, 0);
                        startX += 120;
                    }
                    else if (i == 1)
                    {
                        buttonArray[i, j].Image = Crop(image, 120, 120, startX, 120);
                        startX += 120;
                    }
                    else if (i == 2)
                    {
                        buttonArray[i, j].Image = Crop(image, 120, 120, startX, 240);
                        startX += 120;
                    }
                    else if (i == 3)
                    {
                        buttonArray[i, j].Image = Crop(image, 120, 120, startX, 360);
                        startX += 120;
                    }
                    else if (i == 4)
                    {
                        buttonArray[i, j].Image = Crop(image, 120, 120, startX, 480);
                        startX += 120;
                    }
                }
            }
            buttonArray[4, 4].Image = null;
            buttonArray[4, 4].BackColor = Color.Black;
            ResizeImage(300, 300);
            pictureBox.Image = image;
            string path = Application.StartupPath + @"\Rank5.txt";
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

        private void ResizeImage(int width, int height)
        {

            Image image = this.image;
            Image resize = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resize))
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            this.image = resize;
        }

        static Image Crop(Image image, int width, int height, int startX, int startY)
        {
            Bitmap bitmap = new Bitmap(120, 120);
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

            for (int i = 0; i < 25; i++)
            {
                Image temp;
                string tmp;
                int x = random.Next(0, 5);
                int y = random.Next(0, 5);
                int x2 = random.Next(0, 5);
                int y2 = random.Next(0, 5);
                temp = buttonArray[x, y].Image;
                tmp = buttonArray[x, y].Text;
                buttonArray[x, y].Image = buttonArray[x2, y2].Image;
                buttonArray[x, y].Text = buttonArray[x2, y2].Text;
                buttonArray[x2, y2].Image = temp;
                buttonArray[x2, y2].Text = tmp;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (buttonArray[i, j].Image == null)
                    {
                        buttonArray[i, j].BackColor = Color.Black;
                        buttonArray[i, j].Text = "25";
                    }
                    if (buttonArray[i, j].Image != null && buttonArray[i, j].BackColor == Color.Black)
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
            //if (!playGame)
            //    return;
            int temp;
            if ((x < 4 && buttonArray[y, x + 1].Image == null))
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
            else if (y < 4 && buttonArray[y + 1, x].Image == null)
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
            //if (!playGame)
            //    return;
            int cnt = 1;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (Convert.ToInt32(buttonArray[y, x].Text) != cnt)
                        return;
                    else cnt++;
                }
            }

            if (cnt == 26)
            {
                GameOver over = new GameOver();
                timer.Enabled = false;
                //rankingSort(timeScoreLabel.Text);
                playGame = false;
                over.ShowDialog();
                this.Close();
            }
        }

        private void rankingSort(string s)
        {
            string path = Application.StartupPath + @"\Rank5.txt";
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
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = scores[i].Substring(0, scores[i].IndexOf("\t"));
                scores[i] = scores[i].Replace(":", "");
                scores[i] = scores[i].Replace(".", "");
                temp[i] = (int)(Convert.ToInt64(scores[i]));
            }

            for (int i = 0; i < scores.Length; i++)
            {
                if (temp[i] > recentScore)
                {
                    num = i;
                    break;
                }
            }

            if (num == 11 && scores.Length < 10)
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(s + "\t" + DateTime.Now.ToShortDateString());
                sw.Close();
            }
            else if (num != 11)
            {
                string[] oldscore = File.ReadAllLines(path);
                StreamWriter sw = new StreamWriter(path, false);
                for (int i = 0; i < num; i++)
                {
                    sw.WriteLine(oldscore[i]);
                }
                sw.WriteLine(s + "\t" + DateTime.Now.ToShortDateString());

                if (scores.Length < 10)
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
            clickButton(0, 4);
            checkFinish();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            clickButton(1, 0);
            checkFinish();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            clickButton(1, 1);
            checkFinish();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            clickButton(1, 2);
            checkFinish();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            clickButton(1, 3);
            checkFinish();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            clickButton(1, 4);
            checkFinish();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            clickButton(2, 0);
            checkFinish();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            clickButton(2, 1);
            checkFinish();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            clickButton(2, 2);
            checkFinish();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            clickButton(2, 3);
            checkFinish();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            clickButton(2, 4);
            checkFinish();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            clickButton(3, 0);
            checkFinish();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            clickButton(3, 1);
            checkFinish();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            clickButton(3, 2);
            checkFinish();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            clickButton(3, 3);
            checkFinish();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            clickButton(3, 4);
            checkFinish();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            clickButton(4, 0);
            checkFinish();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            clickButton(4, 1);
            checkFinish();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            clickButton(4, 2);
            checkFinish();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            clickButton(4, 3);
            checkFinish();
        }
        private void button25_Click(object sender, EventArgs e)
        {
            clickButton(4, 4);
            checkFinish();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (!playGame)
                return;
            DateTime pausetime = DateTime.Now;
            timer.Stop();
            Pause form = new Pause(timeScoreLabel.Text);
            form.ShowDialog();
            pause += DateTime.Now - pausetime;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeSpan = DateTime.Now - date - pause;
            timeScoreLabel.Text = timeSpan.ToString();
            Invalidate();
        }

        private void startButton_MouseMove(object sender, MouseEventArgs e)
        {
            startButton.BackgroundImage = SlidingPuzzle.Properties.Resources.StartClick;
        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.BackgroundImage = SlidingPuzzle.Properties.Resources.start;
        }

        private void pauseButton_MouseMove(object sender, MouseEventArgs e)
        {
            pauseButton.ForeColor = Color.Maroon;
        }

        private void pauseButton_MouseLeave(object sender, EventArgs e)
        {
            pauseButton.ForeColor = Color.LemonChiffon;
        }
    }
}
