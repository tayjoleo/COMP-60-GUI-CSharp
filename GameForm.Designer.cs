namespace DragonAdventure
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.narratorPictureBox = new System.Windows.Forms.PictureBox();
            this.narratorLabel = new System.Windows.Forms.Label();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.narratorTimer = new System.Windows.Forms.Timer(this.components);
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.archetypeLabel = new System.Windows.Forms.Label();
            this.wealthLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.narratorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // narratorPictureBox
            // 
            this.narratorPictureBox.Image = global::DragonAdventure.Properties.Resources.Narrator;
            this.narratorPictureBox.Location = new System.Drawing.Point(24, 67);
            this.narratorPictureBox.Name = "narratorPictureBox";
            this.narratorPictureBox.Size = new System.Drawing.Size(353, 326);
            this.narratorPictureBox.TabIndex = 0;
            this.narratorPictureBox.TabStop = false;
            // 
            // narratorLabel
            // 
            this.narratorLabel.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narratorLabel.Location = new System.Drawing.Point(424, 67);
            this.narratorLabel.MaximumSize = new System.Drawing.Size(350, 350);
            this.narratorLabel.Name = "narratorLabel";
            this.narratorLabel.Size = new System.Drawing.Size(350, 326);
            this.narratorLabel.TabIndex = 1;
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputTextBox.Location = new System.Drawing.Point(24, 409);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(750, 29);
            this.userInputTextBox.TabIndex = 2;
            this.userInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userInputTextBox_KeyPress);
            // 
            // narratorTimer
            // 
            this.narratorTimer.Interval = 5000;
            this.narratorTimer.Tick += new System.EventHandler(this.narratorTimer_Tick);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(12, 13);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(153, 23);
            this.playerNameLabel.TabIndex = 3;
            this.playerNameLabel.Text = "Player Name";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceLabel.Location = new System.Drawing.Point(252, 13);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(62, 23);
            this.raceLabel.TabIndex = 4;
            this.raceLabel.Text = "Race";
            // 
            // archetypeLabel
            // 
            this.archetypeLabel.AutoSize = true;
            this.archetypeLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypeLabel.Location = new System.Drawing.Point(341, 13);
            this.archetypeLabel.Name = "archetypeLabel";
            this.archetypeLabel.Size = new System.Drawing.Size(127, 23);
            this.archetypeLabel.TabIndex = 5;
            this.archetypeLabel.Text = "Archetype";
            // 
            // wealthLabel
            // 
            this.wealthLabel.AutoSize = true;
            this.wealthLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wealthLabel.Location = new System.Drawing.Point(474, 13);
            this.wealthLabel.Name = "wealthLabel";
            this.wealthLabel.Size = new System.Drawing.Size(88, 23);
            this.wealthLabel.TabIndex = 6;
            this.wealthLabel.Text = "Wealth";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(648, 13);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(88, 23);
            this.healthLabel.TabIndex = 7;
            this.healthLabel.Text = "Health";
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.wealthLabel);
            this.Controls.Add(this.archetypeLabel);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.narratorLabel);
            this.Controls.Add(this.narratorPictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIXEL QUEST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.narratorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox narratorPictureBox;
        private System.Windows.Forms.Label narratorLabel;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Timer narratorTimer;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label archetypeLabel;
        private System.Windows.Forms.Label wealthLabel;
        private System.Windows.Forms.Label healthLabel;
    }
}