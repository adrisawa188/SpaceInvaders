namespace SpaceInvaders
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.finalScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.White;
            this.gameOverLabel.Location = new System.Drawing.Point(187, 105);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(215, 73);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.BorderSize = 2;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(224, 276);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(139, 44);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // finalScoreLabel
            // 
            this.finalScoreLabel.ForeColor = System.Drawing.Color.White;
            this.finalScoreLabel.Location = new System.Drawing.Point(224, 203);
            this.finalScoreLabel.Name = "finalScoreLabel";
            this.finalScoreLabel.Size = new System.Drawing.Size(139, 23);
            this.finalScoreLabel.TabIndex = 2;
            this.finalScoreLabel.Text = "Your Score Was: 0";
            this.finalScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.finalScoreLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label finalScoreLabel;
    }
}
