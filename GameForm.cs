using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

/*Taylor Evans
 * 
 * This form handles the creation of a new game. It serves as somewhat
 * of a tutorial as well for how the game works. Simply type in your response
 * and you will be prompted if it was correctly understood. Much of this 
 * form relies on incrementing creationSteps that signify where in
 * the character creation process the user is. It also relies heavily
 * on a timer that allows for the user to read the narrator's 
 * response in a comfortale manner. 
 */
namespace DragonAdventure
{
    public partial class GameForm : Form
    {
        private int creationStep = 0;
        private Player player;
        private HashSet<string> validRaces = new HashSet<string> 
        { "elf", "dwarf", "human" };
        private HashSet<string> validArchetypes = new HashSet<string> 
        { "warrior", "rogue", "wizard" };
        private GameState gameState;

        public GameForm()
        {
            InitializeComponent();
            narratorTimer.Interval = 4000; 
            narratorTimer.Tick += narratorTimer_Tick;
            player = new Player(); 
            gameState = new GameState(player); 
            gameState.CurrentScene = "start";
        }

        private void GameForm_Load_1(object sender, EventArgs e)
        {
            narratorLabel.Text = "Welcome adventurer! You are nearly ready " +
                "to embark.";
            narratorTimer.Start();
        }

        private void narratorTimer_Tick(object sender, EventArgs e)
        {
            narratorTimer.Stop(); 

            switch (creationStep)
            {
                case 0:
                    narratorLabel.Text = "Remind me, what is your name " +
                        "again?";
                    creationStep++;
                    break;
                case 1:
                    if (!string.IsNullOrEmpty(player.Name))
                    {
                        narratorLabel.Text = $"I hope you don't find this next " +
                            $"question to be rude, {player.Name}...\n\n" +
                                             "You look either Elf, Dwarf, or " +
                                             "Human to me...\n\n" +
                                             "What exactly is your bloodline?";
                        creationStep++;
                    }
                    break;
                case 2:
                    if (!string.IsNullOrEmpty(player.Race))
                    {
                        narratorLabel.Text = $"{player.Race}, that is exactly " +
                            $"what I would have guessed!\n\n" +
                                             "Now, tell me, what kind of " +
                                             "adventurer are you?\n\n" +
                                             "A Warrior, a Rogue, or a " +
                                             "Wizard?";
                        creationStep++;
                    }
                    break;
                case 3:
                    if (!string.IsNullOrEmpty(player.Archetype))
                    {
                        narratorLabel.Text = $"You should be fine out there. " +
                            $"A {player.Archetype} has their ways of surviving" +
                            $"...\n\n" + "...I'm sure you're eager to get going?" +
                            " Well, let's go then!\n\n" + $"Adventure awaits you," +
                            $" {player.Name}!";
                        creationStep++;
                        narratorTimer.Start();
                    }
                    break;
                case 4:
                    creationStep++;
                    narratorTimer.Start();
                    break;
                case 5:
                    TransitionToMainGame(); 
                    break;
            }
            if (creationStep < 4)
            {
                narratorTimer.Start(); 
            }
   
    }

        private string ExtractName(string input)
        {
            string[] introductions = new string[] { "My name is ", "I am" +
                " called ", "Name's ", "It's ", "I'm " };
            foreach (var intro in introductions)
            {
                if (input.StartsWith(intro,
                    StringComparison.OrdinalIgnoreCase))
                {
                    input = input.Substring(intro.Length); 
                    break;
                }
            }
            return input.Trim(); 
        }

        private void userInputTextBox_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = userInputTextBox.Text.Trim().ToLower(); 
                bool isValidInput = ProcessInput(input);
                userInputTextBox.Clear(); 
                if (!isValidInput)
                {
                    MessageBox.Show("Invalid input. Please try again.");
                }
                e.Handled = true; 
            }
        }

        private bool ProcessInput(string input)
        {
            switch (creationStep)
            {
                case 1: 
                    string extractedName = ExtractName(input);
                    if (!string.IsNullOrWhiteSpace(extractedName))
                    {
                        player.Name = CapitalizeFirstLetter(extractedName);
                        narratorLabel.Text = GetNarratorMessage(player.Name);
                        narratorTimer.Start(); 
                        return true;
                    }
                    MessageBox.Show("Please provide a valid name.");
                    return false;

                case 2: 
                    string race = ExtractRace(input);
                    if (!string.IsNullOrWhiteSpace(race))
                    {
                        player.Race = race;
                        narratorTimer.Start(); 
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid race. Please enter 'Elf'," +
                            " 'Dwarf', or 'Human'.");
                        return false;
                    }

                case 3: 
                    string archetype = ExtractArchetype(input);
                    if (!string.IsNullOrWhiteSpace(archetype))
                    {
                        player.Archetype = archetype;
                        DisplayCharacterSummary();
                        narratorTimer.Start(); 
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid archetype. Please enter 'Warrior'," +
                            " 'Rogue', or 'Wizard'.");
                        return false;
                    }
            }
            return false;
        }

        private string ExtractRace(string input)
        {
            var races = new Dictionary<string, string>
            {
                {"elf", "Elf"},
                {"dwarf", "Dwarf"},
                {"human", "Human"}
            };

            foreach (var race in races.Keys)
            {
                if (input.Contains(race))
                {
                    return races[race];
                }
            }
            return null; 
        }

        private string ExtractArchetype(string input)
        {
            var archetypes = new Dictionary<string, string>
            {
                {"warrior", "Warrior"},
                {"rogue", "Rogue"},
                {"wizard", "Wizard"}
            };

            foreach (var archetype in archetypes.Keys)
            {
                if (input.IndexOf(archetype, StringComparison.OrdinalIgnoreCase)
                    >= 0)
                {
                    return archetypes[archetype];
                }
            }
            return null; 
        }
        private string GetNarratorMessage(string playerName)
        {
            char firstLetter = char.ToUpper(playerName[0]); 
            switch (firstLetter)
            {
                case 'A': return "Ah, an adventurous soul you are!";
                case 'B': return "Reminds me of my cousin Berthilda. " +
                        "She never met a pie she couldn't finish with " +
                        "two bites.";
                case 'C': return "Such a noble name. Brings to mind " +
                        "the mighty paladin Cahir.";
                case 'D': return "Daring, much like the legendary" +
                        " heroes of old.";
                case 'E': return "Elegant, a name fit for royalty.";
                case 'F': return "Fierce as a feral beast, I see!";
                case 'G': return "Gracious, a trait of the truly " +
                        "noble.";
                case 'H': return "Heroic, much like Hogarth " +
                        "Bearhands. \n\n" +
                        "A mighty adventurer you'll no doubt be.";
                case 'I': return "I once knew a gnome by the named" +
                        " of Ivy-Quartz. \n\n" +
                        "If you're anything like her you'll be" +
                        " fine out there.";
                case 'J': return "Jovial, suited for someone who" +
                        " brightens the room.";
                case 'K': return "Knightly, a protector of the" +
                        " weak, perhaps?";
                case 'L': return "Luminous, shining bright " +
                        "with potential.";
                case 'M': return "Mysterious, cloaked in " +
                        "shadows and intrigue.";
                case 'N': return "Noble, with a heart as " +
                        "pure as gold.";
                case 'O': return "Ominous, a foreboding presence" +
                        " indeed.";
                case 'P': return "Proud, standing tall against" +
                        " all odds.";
                case 'Q': return "Quixotic, filled with wild and" +
                        " visionary ideas.";
                case 'R': return "Resolute, unwavering in your" +
                        " pursuits.";
                case 'S': return "Like the great dragonborn S'im" +
                        " himself. \n\n" +
                        "Let the fires of Bahamut guide you.";
                case 'T': return "Tenacious, never one to back" +
                        " down from a challenge.";
                case 'U': return "Unseen, moving silently and " +
                        "unseen like the night.";
                case 'V': return "Valiant, bravery flows through" +
                        " your veins.";
                case 'W': return "Wise beyond years, a sage in" +
                        " the making.";
                case 'X': return "Reminds of the famous bard" +
                        " Xanvalor. \n\n Whatever happened to him?";
                case 'Y': return "Youthful, with the zest of the " +
                        "untamed wind.";
                case 'Z': return "Zesty! A fiery start!";
                default: return "Quite a unique name you've got!";
            }
        }
        private void DisplayCharacterSummary()
        {
            playerNameLabel.Text = CapitalizeFirstLetter(player.Name);
            raceLabel.Text = CapitalizeFirstLetter(player.Race);
            archetypeLabel.Text = CapitalizeFirstLetter(player.Archetype);
            healthLabel.Text = $"Health: {player.Health}";
            wealthLabel.Text = $"Wealth: ${player.Wealth}";
        }
        private string CapitalizeFirstLetter(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            return char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }
        private void TransitionToMainGame()
        {
            narratorTimer.Stop();
            this.Hide(); 
            MainGameForm mainGameForm = new MainGameForm(gameState, player);
            mainGameForm.Show();
            this.Close(); 
        }

        private void RestartGame()
        {
            this.Hide();
            var newMainMenuForm = new MainMenuForm();
            newMainMenuForm.Show();
            this.Close();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

