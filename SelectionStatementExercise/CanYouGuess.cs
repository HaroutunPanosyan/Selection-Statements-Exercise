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
            var favNumber = r.Next(1, 11);

            bool isGuessed = false;
            int attempts = 1;
            {
                do
                {                           
                    if (userInput < favNumber && attempts < 3 && isGuessed == false)
                    {
                        Console.WriteLine($"Aww, so sad. The number you chose is lower than our number. Guess again!");
                        attempts++;
                        Console.WriteLine("Remember, you only have 3 tries. \n" +
                        "Currently on attempt #" + attempts + ".");
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (userInput > favNumber && attempts < 3 && isGuessed == false)
                    {
                        Console.WriteLine($"Aww, so sad. The number you chose is higher than our number. Guess again!");
                        attempts++;
                        Console.WriteLine("Remember, you only have 3 tries. \n" +
                        "Currently on attempt #" + attempts + ".");
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (userInput == favNumber && attempts <= 3)
                    {
                        isGuessed = true;
                        Console.WriteLine($"Congrats! You guessed it: {favNumber}. Are you a psychic!?");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, all out of tries. Our number was {favNumber}.");
                        break;
                    }
                    
                } while (attempts <= 3 && !isGuessed);
            }   
        }
    }
}
