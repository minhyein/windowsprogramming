namespace SlidingPuzzle
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mode5Button = new System.Windows.Forms.Button();
            this.mode4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mode5Button
            // 
            this.mode5Button.BackColor = System.Drawing.Color.Transparent;
            this.mode5Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mode5Button.FlatAppearance.BorderSize = 4;
            this.mode5Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mode5Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mode5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mode5Button.Font = new System.Drawing.Font("배달의민족 주아", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mode5Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mode5Button.Image = global::SlidingPuzzle.Properties.Resources.그림4;
            this.mode5Button.Location = new System.Drawing.Point(575, 383);
            this.mode5Button.Name = "mode5Button";
            this.mode5Button.Size = new System.Drawing.Size(300, 250);
            this.mode5Button.TabIndex = 1;
            this.mode5Button.UseVisualStyleBackColor = false;
            this.mode5Button.Click += new System.EventHandler(this.mode5Button_Click);
            this.mode5Button.MouseLeave += new System.EventHandler(this.mode5Button_MouseLeave);
            this.mode5Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mode5Button_MouseMove);
            // 
            // mode4Button
            // 
            this.mode4Button.BackColor = System.Drawing.Color.Transparent;
            this.mode4Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mode4Button.FlatAppearance.BorderSize = 4;
            this.mode4Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mode4Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mode4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mode4Button.Font = new System.Drawing.Font("배달의민족 주아", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mode4Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mode4Button.Image = global::SlidingPuzzle.Properties.Resources.그림1;
            this.mode4Button.Location = new System.Drawing.Point(89, 383);
            this.mode4Button.Name = "mode4Button";
            this.mode4Button.Size = new System.Drawing.Size(300, 250);
            this.mode4Button.TabIndex = 0;
            this.mode4Button.UseVisualStyleBackColor = false;
            this.mode4Button.Click += new System.EventHandler(this.mode4Button_Click);
            this.mode4Button.MouseLeave += new System.EventHandler(this.mode4Button_MouseLeave);
            this.mode4Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mode4Button_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SlidingPuzzle.Properties.Resources.main1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.mode5Button);
            this.Controls.Add(this.mode4Button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Sliding Puzzle Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mode4Button;
        private System.Windows.Forms.Button mode5Button;
    }
}

