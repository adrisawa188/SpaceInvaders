namespace SpaceInvaders
{
    partial class StartScreen
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
            this.startButton = new System.Windows.Forms.Button();
            this.instructionButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.BorderSize = 2;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Transparent;
            this.startButton.Location = new System.Drawing.Point(230, 116);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(124, 41);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // instructionButton
            // 
            this.instructionButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.instructionButton.FlatAppearance.BorderSize = 2;
            this.instructionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.instructionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.instructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionButton.ForeColor = System.Drawing.Color.Transparent;
            this.instructionButton.Location = new System.Drawing.Point(230, 177);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(124, 41);
            this.instructionButton.TabIndex = 1;
            this.instructionButton.Text = "Instructions";
            this.instructionButton.UseVisualStyleBackColor = true;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.Location = new System.Drawing.Point(230, 239);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 41);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.White;
            this.gameNameLabel.Location = new System.Drawing.Point(135, 43);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(313, 44);
            this.gameNameLabel.TabIndex = 3;
            this.gameNameLabel.Text = "Space Invaders";
            this.gameNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.startButton);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label gameNameLabel;
    }
}
