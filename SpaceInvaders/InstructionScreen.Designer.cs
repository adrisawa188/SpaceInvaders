namespace SpaceInvaders
{
    partial class InstructionScreen
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
            this.instructionScreenNameLabel = new System.Windows.Forms.Label();
            this.moveInstructionLabel = new System.Windows.Forms.Label();
            this.shootIntructionsLabel = new System.Windows.Forms.Label();
            this.gameObjectiveLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionScreenNameLabel
            // 
            this.instructionScreenNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionScreenNameLabel.ForeColor = System.Drawing.Color.White;
            this.instructionScreenNameLabel.Location = new System.Drawing.Point(193, 33);
            this.instructionScreenNameLabel.Name = "instructionScreenNameLabel";
            this.instructionScreenNameLabel.Size = new System.Drawing.Size(189, 45);
            this.instructionScreenNameLabel.TabIndex = 0;
            this.instructionScreenNameLabel.Text = "Instructions ";
            this.instructionScreenNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moveInstructionLabel
            // 
            this.moveInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveInstructionLabel.ForeColor = System.Drawing.Color.White;
            this.moveInstructionLabel.Location = new System.Drawing.Point(107, 105);
            this.moveInstructionLabel.Name = "moveInstructionLabel";
            this.moveInstructionLabel.Size = new System.Drawing.Size(368, 45);
            this.moveInstructionLabel.TabIndex = 1;
            this.moveInstructionLabel.Text = "Use left and right arrow keys to move";
            this.moveInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shootIntructionsLabel
            // 
            this.shootIntructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootIntructionsLabel.ForeColor = System.Drawing.Color.White;
            this.shootIntructionsLabel.Location = new System.Drawing.Point(107, 150);
            this.shootIntructionsLabel.Name = "shootIntructionsLabel";
            this.shootIntructionsLabel.Size = new System.Drawing.Size(368, 45);
            this.shootIntructionsLabel.TabIndex = 2;
            this.shootIntructionsLabel.Text = "Press spacebar to shoot";
            this.shootIntructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameObjectiveLabel
            // 
            this.gameObjectiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameObjectiveLabel.ForeColor = System.Drawing.Color.White;
            this.gameObjectiveLabel.Location = new System.Drawing.Point(107, 195);
            this.gameObjectiveLabel.Name = "gameObjectiveLabel";
            this.gameObjectiveLabel.Size = new System.Drawing.Size(368, 45);
            this.gameObjectiveLabel.TabIndex = 3;
            this.gameObjectiveLabel.Text = "Destroy all enemies before they reach you";
            this.gameObjectiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnButton.FlatAppearance.BorderSize = 2;
            this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.returnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.Transparent;
            this.returnButton.Location = new System.Drawing.Point(224, 288);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(124, 41);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.gameObjectiveLabel);
            this.Controls.Add(this.shootIntructionsLabel);
            this.Controls.Add(this.moveInstructionLabel);
            this.Controls.Add(this.instructionScreenNameLabel);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionScreenNameLabel;
        private System.Windows.Forms.Label moveInstructionLabel;
        private System.Windows.Forms.Label shootIntructionsLabel;
        private System.Windows.Forms.Label gameObjectiveLabel;
        private System.Windows.Forms.Button returnButton;
    }
}
