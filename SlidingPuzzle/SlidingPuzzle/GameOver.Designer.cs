namespace SlidingPuzzle
{
    partial class GameOver
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
            this.currentScoreLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentScoreLabel
            // 
            this.currentScoreLabel.AutoSize = true;
            this.currentScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentScoreLabel.Font = new System.Drawing.Font("배달의민족 한나는 열한살", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.currentScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.currentScoreLabel.Location = new System.Drawing.Point(39, 290);
            this.currentScoreLabel.Name = "currentScoreLabel";
            this.currentScoreLabel.Size = new System.Drawing.Size(0, 43);
            this.currentScoreLabel.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::SlidingPuzzle.Properties.Resources.exit;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backButton.Location = new System.Drawing.Point(47, 366);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(285, 55);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            this.backButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseMove);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SlidingPuzzle.Properties.Resources.clear;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.currentScoreLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentScoreLabel;
        private System.Windows.Forms.Button backButton;
    }
}