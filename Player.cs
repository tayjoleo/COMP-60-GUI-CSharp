using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Taylor Evans
 * 
 * This is the player class for the game. It handles all of the 
 * logic regarding the player. It will control the health, and stats, 
 * and all of the information that is generated during the character
 * creation at the start of a new game.
 */


namespace DragonAdventure
{
    public class Player
    {
        private string name;
        private string race;
        private string archetype;
        private int health;
        private double wealth = 20.00;  
        private int intelligence = 3;
        private int strength = 3;
        private int dexterity = 3;
        private int charisma = 3;
        private int constitution = 3;

        public Player()
        {
        }

        public Player(string name, string race, string archetype)
        {
            Name = name;
            Race = race;
            Archetype = archetype;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Race
        {
            get => race;
            set
            {
                race = value;
                ApplyRaceModifiers();
                CalculateHealth();
            }
        }

        public string Archetype
        {
            get => archetype;
            set
            {
                archetype = value;
                ApplyArchetypeModifiers();
                CalculateHealth();
            }
        }

        public double Wealth
        {
            get => wealth;
            set => wealth = Math.Max(0, value);  
        }

        public int Health
        {
            get => health;
            private set => health = value;
        }

        public int Intelligence { get; private set; } = 3;
        public int Strength { get; private set; } = 3;
        public int Dexterity { get; private set; } = 3;
        public int Charisma { get; private set; } = 3;
        public int Constitution
        {
            get => constitution;
            set
            {
                constitution = value;
                CalculateHealth();
            }
        }

        private void ApplyRaceModifiers()
        {
            switch (race.ToLower())
            {
                case "elf":
                    Intelligence += 1;
                    Dexterity += 1;
                    break;
                case "dwarf":
                    Strength += 1;
                    Constitution += 1;
                    break;
                case "human":
                    Charisma += 2;
                    break;
            }
        }

        private void ApplyArchetypeModifiers()
        {
            switch (archetype.ToLower())
            {
                case "warrior":
                    Constitution += 1;
                    Intelligence -= 1;
                    Strength += 2;
                    break;
                case "rogue":
                    Charisma += 1;
                    Dexterity += 2;
                    Strength -= 1;
                    break;
                case "wizard":
                    Intelligence += 4;
                    Strength -= 1;
                    Constitution -= 1;
                    break;
            }
        }

        private void CalculateHealth()
        {
            Health = 20 + (int)Math.Ceiling(Constitution * 1.5);
        }
    }
}
