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
            this.mode4Button = new System.Windows.Forms.Button();
            this.mode5Button = new System.Windows.Forms.Button();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mode4Button
            // 
            this.mode4Button.Font = new System.Drawing.Font("배달의민족 주아", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mode4Button.Location = new System.Drawing.Point(89, 383);
            this.mode4Button.Name = "mode4Button";
            this.mode4Button.Size = new System.Drawing.Size(311, 266);
            this.mode4Button.TabIndex = 0;
            this.mode4Button.Text = "4x4";
            this.mode4Button.UseVisualStyleBackColor = true;
            this.mode4Button.Click += new System.EventHandler(this.mode4Button_Click);
            // 
            // mode5Button
            // 
            this.mode5Button.Font = new System.Drawing.Font("배달의민족 주아", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mode5Button.Location = new System.Drawing.Point(575, 383);
            this.mode5Button.Name = "mode5Button";
            this.mode5Button.Size = new System.Drawing.Size(311, 266);
            this.mode5Button.TabIndex = 1;
            this.mode5Button.Text = "5x5";
            this.mode5Button.UseVisualStyleBackColor = true;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("배달의민족 주아", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chooseLabel.Location = new System.Drawing.Point(215, 99);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(561, 88);
            this.chooseLabel.TabIndex = 2;
            this.chooseLabel.Text = "CHOOSE MODE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.mode5Button);
            this.Controls.Add(this.mode4Button);
            this.Name = "MainForm";
            this.Text = "Sliding Puzzle Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mode4Button;
        private System.Windows.Forms.Button mode5Button;
        private System.Windows.Forms.Label chooseLabel;
    }
}

