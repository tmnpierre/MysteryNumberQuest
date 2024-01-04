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
            int guess;

            Console.WriteLine("The mystery number has been generated. Try to guess it!");
            Console.WriteLine($"You have {maxAttempts} attempts.");

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                if (guess == mysteryNumber)
                {
                    Console.WriteLine("Congratulations! You've guessed the mystery number.");
                    break;
                }
                else
                {
                    Console.WriteLine(guess < mysteryNumber ? "Too low. Try again." : "Too high. Try again.");
                }

                attempts++;

                if (attempts == maxAttempts)
                {
                    Console.WriteLine($"Sorry, you've used all your attempts. The mystery number was {mysteryNumber}.");
                }
            }
        }
    }
}
