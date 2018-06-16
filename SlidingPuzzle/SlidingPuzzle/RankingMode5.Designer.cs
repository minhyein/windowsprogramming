namespace SlidingPuzzle
{
    partial class RankingMode5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rankingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나는 열한살", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(292, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 114);
            this.label1.TabIndex = 3;
            this.label1.Text = "RANKING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankingTextBox
            // 
            this.rankingTextBox.BackColor = System.Drawing.Color.White;
            this.rankingTextBox.Enabled = false;
            this.rankingTextBox.Font = new System.Drawing.Font("배달의민족 한나는 열한살", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rankingTextBox.Location = new System.Drawing.Point(41, 181);
            this.rankingTextBox.Multiline = true;
            this.rankingTextBox.Name = "rankingTextBox";
            this.rankingTextBox.ReadOnly = true;
            this.rankingTextBox.Size = new System.Drawing.Size(900, 531);
            this.rankingTextBox.TabIndex = 2;
            // 
            // RankingMode5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlidingPuzzle.Properties.Resources.play;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rankingTextBox);
            this.Name = "RankingMode5";
            this.Text = "RankingMode5";
            this.Load += new System.EventHandler(this.RankingMode5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rankingTextBox;
    }
}