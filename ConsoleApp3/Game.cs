using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Game
    {
        private int secretNumber;

        public Game()
        {
            Random rand = new Random();
            secretNumber = rand.Next(1, 101);
        }

        public string CheckGuess(int guess)
        {
            if (guess > secretNumber) return "Too high!";
            if (guess < secretNumber) return "Too low!";
            return "Correct!";
        }
    }

}
