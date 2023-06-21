namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 
            // ---------------------------------------------------------------

            Console.WriteLine("Guess a number between 1 and 999!");
            int userInput = int.Parse(Console.ReadLine());
            CanYouGuess.MyNumber(userInput);

            // Exercise 2
            // ---------------------------------------------------------------

            Console.WriteLine("Choose a subject. Any subject.");
            string subject = Console.ReadLine();
            SubjectTracker.Subject(subject);

        }
    }
}
