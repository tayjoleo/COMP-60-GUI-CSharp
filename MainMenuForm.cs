using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Taylor Evans
 * This form handles the three buttons that lead
 * the user to a new game, and old game, or a tutorial
 * on how to play the game.
 */


namespace DragonAdventure
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            GameState gameState = new GameState(player);
            GameForm gameForm = new GameForm(); 
            gameForm.Show();
            this.Hide(); 
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            GameState gameState = GameState.LoadGame();
            if (gameState != null)
            {
                Player player = new Player();
                MainGameForm gameForm = new MainGameForm(gameState, player); 
                // I know this isn't working, but it is a start. 
                gameForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No saved game data found.");
            }
        }

        private void tutorialButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my game! It is definitely a" +
                " work in progress \n\n" + "It is meant to function" +
                " like a tabletop RPG where you get to decide what " +
                "you do and where your story goes. \n\n It is entirely" +
                " text based and simply requires the user to type their" +
                " answers into the textbox and hit enter. \n\n In time, " +
                "functionality will increase and the ability to load previous" 
                + " games will be added. \n\n I hope you enjoy it!");
        }
        private void InitializeListBox()
        {
            changeColourListBox = new ListBox();
            changeColourListBox.SetBounds(10, 10, 120, 90);

            changeColourListBox.Items.Add("Yellow");
            changeColourListBox.Items.Add("Grey");
            changeColourListBox.Items.Add("Red");
            changeColourListBox.Items.Add("Green");
            changeColourListBox.Items.Add("Blue");
            changeColourListBox.Items.Add("Purple");

            this.Controls.Add(changeColourListBox);
        }

        private void changeColourListBox_SelectedIndexChanged(object sender,
            EventArgs e)
        {
            if (changeColourListBox.SelectedIndex == -1) return; 


            string selectedColor = changeColourListBox.SelectedItem.ToString();

            switch (selectedColor)
            {
                case "Red":
                    this.BackColor = Color.Red;
                    break;
                case "Grey":
                    this.BackColor = Color.Gray;
                    break;
                case "Yellow":
                    this.BackColor = Color.Yellow;
                    break;
                case "Green":
                    this.BackColor = Color.Green;
                    break;
                case "Blue":
                    this.BackColor = Color.Blue;
                    break;
                case "Purple":
                    this.BackColor = Color.Purple;
                    break;
                default:
                    this.BackColor = SystemColors.Control; 
                    break;
            }
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to restart the game? " +
                "Click No to Close game.", "Confirm",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    e.Cancel = true; 
                    RestartGame(); 
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }
        private void RestartGame()
        {
            this.Hide(); 
            var newMainMenuForm = new MainMenuForm();
            newMainMenuForm.Show();
            this.Close(); 
        }
    }
}
