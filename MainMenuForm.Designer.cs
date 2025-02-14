namespace DragonAdventure
{
    partial class MainMenuForm
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.changeColourListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(279, 131);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(223, 36);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "NEW GAME";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // loadGameButton
            // 
            this.loadGameButton.Location = new System.Drawing.Point(279, 197);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(223, 36);
            this.loadGameButton.TabIndex = 1;
            this.loadGameButton.Text = "LOAD GAME";
            this.loadGameButton.UseVisualStyleBackColor = true;
            this.loadGameButton.Click += new System.EventHandler(this.loadGameButton_Click);
            // 
            // tutorialButton
            // 
            this.tutorialButton.Location = new System.Drawing.Point(279, 260);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(223, 36);
            this.tutorialButton.TabIndex = 2;
            this.tutorialButton.Text = "TUTORIAL";
            this.tutorialButton.UseVisualStyleBackColor = true;
            this.tutorialButton.Click += new System.EventHandler(this.tutorialButton_Click);
            // 
            // changeColourListBox
            // 
            this.changeColourListBox.FormattingEnabled = true;
            this.changeColourListBox.Items.AddRange(new object[] {
            "Purple",
            "Green",
            "Blue",
            "Red",
            "Yellow",
            "Grey"});
            this.changeColourListBox.Location = new System.Drawing.Point(279, 358);
            this.changeColourListBox.Name = "changeColourListBox";
            this.changeColourListBox.Size = new System.Drawing.Size(223, 17);
            this.changeColourListBox.TabIndex = 3;
            this.changeColourListBox.SelectedIndexChanged += new System.EventHandler(this.changeColourListBox_SelectedIndexChanged);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeColourListBox);
            this.Controls.Add(this.tutorialButton);
            this.Controls.Add(this.loadGameButton);
            this.Controls.Add(this.newGameButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIXEL QUEST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button loadGameButton;
        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.ListBox changeColourListBox;
    }
}