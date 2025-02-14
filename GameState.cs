using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DragonAdventure
{
    public class GameState
    {
        public Player Player { get; set; }
        public string CurrentScene { get; set; }

        static string saveFilePath = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, 
                "gamestate.json");
        public GameState(Player player)
        {
            Player = player;
            CurrentScene = "tavern"; 
        }

        public void SaveGame()
        {
            var gameState = JsonConvert.SerializeObject(this);
            File.WriteAllText(saveFilePath, gameState);
        }

        public static GameState LoadGame()
        {
                if (File.Exists(saveFilePath))
                {
                    var gameStateJson = File.ReadAllText(saveFilePath);
                    return 
                    JsonConvert.DeserializeObject<GameState>(gameStateJson);
                }
                MessageBox.Show("No saved game file found.");
            return null;
        }

        public void ChangeScene(string newScene)
        {
            CurrentScene = newScene;
            SaveGame(); 
        }
    }
}

