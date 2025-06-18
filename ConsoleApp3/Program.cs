using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    using System;

    class Program
    {
        static void Main()
        {
            Game game = new Game();
            Player player = new Player();

            Console.WriteLine("Guess the number between 1 and 100. You have 5 attempts.");

            while (player.HasAttempts())
            {
                Console.Write("Your guess:  ");
                int guess;
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }

                string result = game.CheckGuess(guess);
                Console.WriteLine(result);

                if (result == "Correct!") break;

                player.ReduceAttempts();
            }

            if (!player.HasAttempts())
                Console.WriteLine("You ran out of attempts! Better luck next time.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}
