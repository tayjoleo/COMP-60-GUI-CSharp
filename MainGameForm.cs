using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Taylor Evans
 * 
 * This form handles the functional playing of the game. 
 * It has some issues so far but I think the bones and
 * the logic are there. We will be going in and out of
 * scenes for the player to interact with. We take
 * the input from the textbox and run it through 
 * specific functions that relate to specific scenes.
 * Further, there is an incorporation of the player's
 * stats in combination with the results of dice rolls
 * in order to determine the outcome of situations
 * and decisions that the player makes. 
 */
namespace DragonAdventure
{
    public partial class MainGameForm : Form
    {
        private Player player;
        private Dice d10;
        private GameState gameState;
        private Stack<string> sceneHistory = new Stack<string>();

        public MainGameForm(GameState gameState, Player player)
        {
            InitializeComponent();
            this.gameState = gameState;
            this.player = player; 
            d10 = new Dice(10);

            InitializePlayerDisplays();
            InitializeGameScene();
        }
        private void InitializePlayerDisplays()
        {
            playerNameLabel.Text = player.Name;
            raceLabel.Text = player.Race;
            archetypeLabel.Text = player.Archetype;
            healthLabel.Text = $"Health: {player.Health}";
            wealthLabel.Text = $"Wealth: ${player.Wealth}";
        }

        private void InitializeGameScene()
        {
            UpdateScene("tavern");
            UpdateNarrative("You arrive late at night to the local " +
                "tavern. \n\n" +
                "There is just the bartender and a mysterious hooded " +
                "figure here tonight. \n\n" +
                "What do you want to do?");
            narrativePictureBox.Image = Properties.Resources.barScene;
        }
        private void UpdateScene(string currentScene)
        {
            gameState.CurrentScene = currentScene;
        }
        private void ChangeScene(string newScene)
        {
            sceneHistory.Push(gameState.CurrentScene);
            gameState.ChangeScene(newScene);
            UpdateScene(newScene);
        }
        private void UpdateNarrative(string text)
        {
            narrativeLabel.Text = text;
        }
        private void InitializeGameSettings()
        {
            playerNameLabel.Text = CapitalizeFirstLetter(player.Name);
            raceLabel.Text = CapitalizeFirstLetter(player.Race);
            archetypeLabel.Text = CapitalizeFirstLetter(player.Archetype);
            healthLabel.Text = $"Health: {player.Health}";
            wealthLabel.Text = $"Wealth: ${player.Wealth}";
        }

        private void ProcessPlayerInput(string input)
        {
            input = input.ToLower(); 

            if (input.Contains("bartender"))
            {
                InteractWithBartender();
            }
            else if (input.Contains("hooded figure") 
                || input.Contains("mysterious figure"))
            {
                InteractWithHoodedFigure();
            }
            else if (input.Contains("sleep") || input.Contains("bed"))
            {
                GoToBed();
            }
            else if (input.Contains("BACK") && sceneHistory.Count > 0)
            {
                string lastScene = sceneHistory.Pop(); 
                                                       
                ChangeScene(lastScene);
            }
            else
            {
                UpdateNarrative("You look around unsure of what to do next. " +
                    "Try different keywords.");
            }
        }

        private void GoBack()
        {
            if (sceneHistory.Count > 1)
            {
                sceneHistory.Pop(); 
                ChangeScene(sceneHistory.Peek()); 
            }
            else
            {
                UpdateNarrative("No way back!");
            }
        }
        private void InteractWithBartender()
        {
            gameState.ChangeScene("bartender");
            narrativePictureBox.Image = Properties.Resources.barkeep;
            UpdateNarrative("You walk up to the bartender. What do you want " +
                "to do?\n" +
                            "1: Ask about local rumors\n" +
                            "2: Order a drink\n" +
                            "3: Challenge to arm wrestling\n" +
                            "4: Just chat about the town");
        }
        private void GoToBed()
        {
            gameState.ChangeScene("bedroom");
            narrativePictureBox.Image = Properties.Resources.innBedroom;
            UpdateNarrative("You decide to rent a room for the night " +
                "and get some rest.");
        }
        private void ProcessBartenderInteraction(string input)
        {

            if (input.Contains("rumors") || input.Contains("1"))
            {
                int diceRoll = d10.Roll();
                UpdateNarrative($"You roll a {diceRoll} on your d10.");
                if (diceRoll + player.Intelligence > 12) 
                {
                    UpdateNarrative("The bartender leans in and whispers " +
                        "about recent strange happenings in the nearby forest.");
                }
                else
                {
                    UpdateNarrative("The bartender shrugs, not having any " +
                        "interesting news to share.");
                }
            }
            else if (input.Contains("drink") || input.Contains("2"))
            {
                UpdateNarrative("The bartender nods and quickly serves up" +
                    " your favorite local brew.");
            }
            else if (input.Contains("wrestle") || input.Contains("3"))
            {
                int diceRoll = d10.Roll();
                UpdateNarrative($"You roll a {diceRoll} on your d10.");
                if (diceRoll + player.Strength > 15) 
                {
                    UpdateNarrative("You slam the bartender's hand down " +
                        "to the counter, earning cheers from the onlookers.");
                }
                else
                {
                    UpdateNarrative("It's a tough match, but the bartender" +
                        " finally overpowers you, smirking proudly.");
                }
            }
            else if (input.Contains("chat") || input.Contains("4"))
            {
                UpdateNarrative("The bartender chats about the town's" +
                    " history and some of the regular patrons.");
            }
            else if (input.Contains("BACK") && sceneHistory.Count > 0)
            {
                string lastScene = sceneHistory.Pop(); 
                ChangeScene(lastScene);
            }
        }

        private void InteractWithHoodedFigure()
        {
            gameState.ChangeScene("mysteriousFigure");
            narrativePictureBox.Image = Properties.Resources.cloakedFigure;
            UpdateNarrative("The hooded figure seems shrouded in mystery." +
                " What do you want to do?\n" +
                            "1: Persuade to trust you\n" +
                            "2: Offer help with brute force\n" +
                            "3: Inquire about the origins of the book\n" +
                            "4: Negotiate for a reward");
        }

        private void ProcessBedroomInteraction(string input)
        {
            if (input.Contains("sleep"))
            {
                UpdateNarrative("You fall asleep quickly, unsure of what" +
                    " tomorrow brings.");
                narrativePictureBox.Image = Properties.Resources.black;
            }
            else if (input.Contains("BACK") && sceneHistory.Count > 0)
            {
                string lastScene = sceneHistory.Pop(); 
                ChangeScene(lastScene);
            }
        }
        private void ProcessHoodedFigureInteraction(string input)
        {
            if (input.Contains("persuade") || input.Contains("1"))
            {
                int diceRoll = d10.Roll();
                UpdateNarrative($"You roll a {diceRoll} on your d10.");
                if (diceRoll + player.Charisma > 14)
                {
                    UpdateNarrative("The figure lowers their hood," +
                        " revealing their face and trusting you with " +
                        "their secrets.");
                }
                else
                {
                    UpdateNarrative("Despite your best efforts," +
                        " the figure remains distant and suspicious.");
                }
            }
            else if (input.Contains("brute force") || input.Contains("2"))
            {
                int diceRoll = d10.Roll();
                UpdateNarrative($"You roll a {diceRoll} on your d10.");
                if (diceRoll + player.Strength > 13)
                {
                    UpdateNarrative("Impressed by your might, the " +
                        "figure agrees to accept your protection.");
                }
                else
                {
                    UpdateNarrative("Your offer of brute force seems " +
                        "to scare them more than reassure them.");
                }
            }
            else if (input.Contains("origins") || input.Contains("3"))
            {
                int diceRoll = d10.Roll();
                UpdateNarrative($"You roll a {diceRoll} on your d10.");
                if (diceRoll + player.Intelligence > 12)
                {
                    UpdateNarrative("Fascinated by your knowledge, they " +
                        "share the rich history of the ancient book.");
                }
                else
                {
                    UpdateNarrative("They scoff at your lack of knowledge" +
                        " and refuse to discuss the book further.");
                }
            }
            else if (input.Contains("negotiate") || input.Contains("4"))
            {
                int diceRoll = d10.Roll();
                UpdateNarrative($"You roll a {diceRoll} on your d10.");
                if (diceRoll + player.Charisma > 15)
                {
                    UpdateNarrative("Your negotiation skills shine, " +
                        "securing a promise of great reward upon success.");
                }
                else
                {
                    UpdateNarrative("The figure is not moved by your " +
                        "words and offers you only a modest sum.");
                }
            }
            else
            {
                UpdateNarrative("You're not sure how to approach them." +
                    " Try one of the options given.");
            }
            
            ReturnToPreviousScene();
        }
        private void ReturnToPreviousScene()
        {
            if (sceneHistory.Count > 0)
            {
                string lastScene = sceneHistory.Pop();  
                gameState.ChangeScene(lastScene);       
                UpdateScene(lastScene);                
            }
            else
            {
                UpdateNarrative("No previous scenes to return to.");
            }
        }

        private string CapitalizeFirstLetter(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            return char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }

        private void userInputTextBox_KeyPress(object sender, 
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = userInputTextBox.Text.Trim().ToLower();
                userInputTextBox.Clear();

                switch (gameState.CurrentScene)
                {
                    case "tavern":
                        ProcessPlayerInput(input);
                        break;
                    case "bartender":
                        ProcessBartenderInteraction(input);
                        break;
                    case "bedroom":
                        ProcessBedroomInteraction(input);
                        break;
                    case "mysteriousFigure":
                        ProcessHoodedFigureInteraction(input);
                        break;
                    default:
                        UpdateNarrative("You're not sure what to do in " +
                            "this scene.");
                        break;
                }
            }
        }

        private void MainGameForm_FormClosing(object sender, FormClosingEventArgs e)
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
