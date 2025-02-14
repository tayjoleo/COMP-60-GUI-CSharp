namespace DragonAdventure
{
    partial class MainGameForm
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
            this.healthLabel = new System.Windows.Forms.Label();
            this.wealthLabel = new System.Windows.Forms.Label();
            this.archetypeLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.narrativeLabel = new System.Windows.Forms.Label();
            this.narrativePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.narrativePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(655, 13);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(88, 23);
            this.healthLabel.TabIndex = 15;
            this.healthLabel.Text = "Health";
            // 
            // wealthLabel
            // 
            this.wealthLabel.AutoSize = true;
            this.wealthLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wealthLabel.Location = new System.Drawing.Point(481, 13);
            this.wealthLabel.Name = "wealthLabel";
            this.wealthLabel.Size = new System.Drawing.Size(88, 23);
            this.wealthLabel.TabIndex = 14;
            this.wealthLabel.Text = "Wealth";
            // 
            // archetypeLabel
            // 
            this.archetypeLabel.AutoSize = true;
            this.archetypeLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypeLabel.Location = new System.Drawing.Point(348, 13);
            this.archetypeLabel.Name = "archetypeLabel";
            this.archetypeLabel.Size = new System.Drawing.Size(127, 23);
            this.archetypeLabel.TabIndex = 13;
            this.archetypeLabel.Text = "Archetype";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceLabel.Location = new System.Drawing.Point(259, 13);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(62, 23);
            this.raceLabel.TabIndex = 12;
            this.raceLabel.Text = "Race";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(19, 13);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(153, 23);
            this.playerNameLabel.TabIndex = 11;
            this.playerNameLabel.Text = "Player Name";
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputTextBox.Location = new System.Drawing.Point(31, 409);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(750, 29);
            this.userInputTextBox.TabIndex = 10;
            this.userInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userInputTextBox_KeyPress);
            // 
            // narrativeLabel
            // 
            this.narrativeLabel.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narrativeLabel.Location = new System.Drawing.Point(431, 67);
            this.narrativeLabel.MaximumSize = new System.Drawing.Size(350, 350);
            this.narrativeLabel.Name = "narrativeLabel";
            this.narrativeLabel.Size = new System.Drawing.Size(350, 326);
            this.narrativeLabel.TabIndex = 9;
            // 
            // narrativePictureBox
            // 
            this.narrativePictureBox.Image = global::DragonAdventure.Properties.Resources.black;
            this.narrativePictureBox.Location = new System.Drawing.Point(31, 67);
            this.narrativePictureBox.Name = "narrativePictureBox";
            this.narrativePictureBox.Size = new System.Drawing.Size(353, 326);
            this.narrativePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.narrativePictureBox.TabIndex = 8;
            this.narrativePictureBox.TabStop = false;
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.wealthLabel);
            this.Controls.Add(this.archetypeLabel);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.narrativeLabel);
            this.Controls.Add(this.narrativePictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIXEL QUEST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.narrativePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label wealthLabel;
        private System.Windows.Forms.Label archetypeLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Label narrativeLabel;
        private System.Windows.Forms.PictureBox narrativePictureBox;
    }
}