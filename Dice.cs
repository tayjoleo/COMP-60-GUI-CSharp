using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Taylor Evans
 * 
 * This is the dice class for the game. It was made to be adjustable
 * so that if there is ever a need to roll different dice
 * it can happen. The dice serve the purpose of
 * adding randomization to all encounters and ability checks.
 */
namespace DragonAdventure
{
    public class Dice
    {
        private Random random;
        private int sides;

        public Dice(int sides)
        {
            this.sides = sides;
            random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, sides + 1); 
        }
    }
}
