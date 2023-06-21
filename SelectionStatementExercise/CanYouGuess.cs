using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementExercise
{
    internal class CanYouGuess
    {
        public static void MyNumber(int userInput)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            if (userInput < favNumber)
            {
                Console.WriteLine($"Aww, so sad. The number you chose is lower than our number. {favNumber}. Guess again!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"Aww, so sad. The number you chose is higher than our number. {favNumber}. Guess again!");
            }
            else
            {
                Console.WriteLine($"Congrats! You guessed it: {favNumber}. Are you a psychic!?");
            }
        }
    }
}
