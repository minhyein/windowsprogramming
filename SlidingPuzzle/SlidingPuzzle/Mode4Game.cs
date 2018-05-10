﻿using System;
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
    public partial class Mode4Game : Form
    {
        public Mode4Game()
        {
            InitializeComponent();
        }

        ChooseImageMode4 mode4;
        Image image;
        Button[,] buttonArray = new Button[4,4];
        Button[,] answerArray = new Button[4, 4];
        public Mode4Game(ChooseImageMode4 form, Image picture)
        {
            InitializeComponent();
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
            Random random = new Random();
           
            for(int i = 0; i < 16; i++)
            {
                Image temp;
                int x = random.Next(0, 4);
                int y = random.Next(0, 4);
                int x2 = random.Next(0, 4);
                int y2 = random.Next(0, 4);
                temp = buttonArray[x, y].Image;
                buttonArray[x, y].Image = buttonArray[x2, y2].Image;
                buttonArray[x2, y2].Image = temp;
            }

            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (buttonArray[i, j].Image == null)
                    {
                        buttonArray[i, j].BackColor = Color.Black;
                    }
                    if(buttonArray[i, j].Image != null && buttonArray[i,j].BackColor == Color.Black)
                    {
                        buttonArray[i, j].BackColor = Color.White;
                    }
                }
                
            }
        }
        private void clickButton(int y, int x)
        {
            string temp;
            if ((x < 3 && buttonArray[y, x + 1].Image == null))
            {
                temp = buttonArray[y, x + 1].Text;
                buttonArray[y, x + 1].Text = buttonArray[y, x].Text;
                buttonArray[y, x].Text = temp;
                buttonArray[y, x + 1].Image = buttonArray[y, x].Image;
                buttonArray[y, x + 1].BackColor = Color.Wheat;
                buttonArray[y, x].BackColor = Color.Black;
                buttonArray[y, x].Image = null;
                return;
            }
            else if (x > 0 && (buttonArray[y, x - 1].Image == null))
            {
                temp = buttonArray[y, x - 1].Text;
                buttonArray[y, x - 1].Text = buttonArray[y, x].Text;
                buttonArray[y, x].Text = temp;
                buttonArray[y, x - 1].Image = buttonArray[y, x].Image;
                buttonArray[y, x - 1].BackColor = Color.Wheat;
                buttonArray[y, x].BackColor = Color.Black;
                buttonArray[y, x].Image = null;
                return;
            }
            else if(y < 3 && buttonArray[y+1, x].Image == null)
            {
                temp = buttonArray[y + 1, x].Text;
                buttonArray[y + 1, x].Text = buttonArray[y, x].Text;
                buttonArray[y, x].Text = temp;
                buttonArray[y + 1, x].Image = buttonArray[y, x].Image;
                buttonArray[y + 1, x].BackColor = Color.Wheat;
                buttonArray[y, x].BackColor = Color.Black;
                buttonArray[y, x].Image = null;
                return;
            }
            else if (y > 0 && buttonArray[y - 1, x].Image == null)
            {
                temp = buttonArray[y - 1, x].Text;
                buttonArray[y - 1, x].Text = buttonArray[y, x].Text;
                buttonArray[y, x].Text = temp;
                buttonArray[y - 1, x].Image = buttonArray[y, x].Image;
                buttonArray[y - 1, x].BackColor = Color.Wheat;
                buttonArray[y, x].BackColor = Color.Black;
                buttonArray[y, x].Image = null;
                return;
            }
        }

        private void puzzleSuccess()
        {
            int num = 1;
            for(int y = 0; y < 4; y++)
            {
                for(int x = 0; x < 4; x++)
                {
                    if (num != Int32.Parse(buttonArray[y, x].Text))
                        return;
                    num++;
                }
            }
            if (num == 16)
            {
                MessageBox.Show("Conglatuation!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           clickButton(0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickButton(0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickButton(0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickButton(0, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickButton(1, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickButton(1, 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickButton(1, 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickButton(1, 3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickButton(2, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clickButton(2, 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clickButton(2, 2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clickButton(2, 3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clickButton(3, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clickButton(3, 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clickButton(3, 2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            clickButton(3, 3);
            
        }
    }
}
