using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementExercise
{
    internal class SubjectTracker
    {
        public static void Subject(string subject) 
        { 
            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Not a bad choice.");
                    break;
                case "art":
                    Console.WriteLine("Wonderful choice.");
                    break;
                case "computer science":
                    Console.WriteLine("Superb decision.");
                    break;
                case "culinary arts":
                    Console.WriteLine("Everyone needs to eat after all.");
                    break;
                case "theater arts":
                    Console.WriteLine("Will you become the next Emmy Award Winner?");
                    break;
                default:
                    Console.WriteLine("Sorry not enough info on that subject. Can't help.");
                    break;
            }
        }
    }
}
