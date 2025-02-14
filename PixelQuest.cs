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
 * This is my Tabletop RPG style game. 
 * This is the welcoming page. Definitely needs
 * some love!
 */
namespace DragonAdventure
{
    public partial class PixelQuestForm : Form
    {
        public PixelQuestForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.FormClosed += (s, args) => this.Close(); 
            mainMenu.Show();
        }

        private void PixelQuestForm_FormClosing(object sender, FormClosingEventArgs e)
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
