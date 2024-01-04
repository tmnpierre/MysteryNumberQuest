namespace MysteryNumberQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int mysteryNumber = random.Next(1, 101);
            int maxAttempts = 5; 
            int attempts = 0;
            bool isGuessedCorrectly = false;

            Console.WriteLine("The mystery number has been generated. Try to guess it!");
            Console.WriteLine($"You have {maxAttempts} attempts.");

            while (attempts < maxAttempts && !isGuessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                int guess;
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess == mysteryNumber)
                    {
                        Console.WriteLine("Congratulations! You've guessed the mystery number.");
                        isGuessedCorrectly = true;
                    }
                    else
                    {
                        Console.WriteLine(guess < mysteryNumber ? "Too low. Try again." : "Too high. Try again.");
                        attempts++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            if (!isGuessedCorrectly)
            {
                Console.WriteLine($"Sorry, you've used all your attempts. The mystery number was {mysteryNumber}.");
            }
        }
    }
}
