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
            this.components = new System.ComponentModel.Container();
            this.mode4Button = new System.Windows.Forms.Button();
            this.slidingLabel = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.mode5Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mode4Button
            // 
            this.mode4Button.BackColor = System.Drawing.Color.Transparent;
            this.mode4Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mode4Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mode4Button.Font = new System.Drawing.Font("배달의민족 주아", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mode4Button.Image = global::SlidingPuzzle.Properties.Resources._44button;
            this.mode4Button.Location = new System.Drawing.Point(89, 383);
            this.mode4Button.Name = "mode4Button";
            this.mode4Button.Size = new System.Drawing.Size(300, 250);
            this.mode4Button.TabIndex = 0;
            this.mode4Button.UseVisualStyleBackColor = false;
            this.mode4Button.Click += new System.EventHandler(this.mode4Button_Click);
            // 
            // slidingLabel
            // 
            this.slidingLabel.BackColor = System.Drawing.Color.Transparent;
            this.slidingLabel.Font = new System.Drawing.Font("배달의민족 한나는 열한살", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.slidingLabel.ForeColor = System.Drawing.Color.Black;
            this.slidingLabel.Image = global::SlidingPuzzle.Properties.Resources.title;
            this.slidingLabel.Location = new System.Drawing.Point(250, 50);
            this.slidingLabel.Name = "slidingLabel";
            this.slidingLabel.Size = new System.Drawing.Size(516, 195);
            this.slidingLabel.TabIndex = 2;
            this.slidingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mode5Button
            // 
            this.mode5Button.BackColor = System.Drawing.Color.Transparent;
            this.mode5Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mode5Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mode5Button.Font = new System.Drawing.Font("배달의민족 주아", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mode5Button.Image = global::SlidingPuzzle.Properties.Resources._55button;
            this.mode5Button.Location = new System.Drawing.Point(575, 383);
            this.mode5Button.Name = "mode5Button";
            this.mode5Button.Size = new System.Drawing.Size(300, 250);
            this.mode5Button.TabIndex = 1;
            this.mode5Button.UseVisualStyleBackColor = false;
            this.mode5Button.Click += new System.EventHandler(this.mode5Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlidingPuzzle.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.slidingLabel);
            this.Controls.Add(this.mode5Button);
            this.Controls.Add(this.mode4Button);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Sliding Puzzle Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mode4Button;
        private System.Windows.Forms.Label slidingLabel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button mode5Button;
    }
}

