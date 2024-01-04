namespace MysteryNumberQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxAttempts = 5, LowerBound = 1, UpperBound = 100;
            var random = new Random();
            int mysteryNumber = random.Next(LowerBound, UpperBound + 1), attempts;

            Console.WriteLine("Guess the mystery number between 1 and 100. You have 5 attempts.");

            for (attempts = 0; attempts < MaxAttempts; attempts++)
            {
                Console.Write($"Attempt {attempts + 1}/{MaxAttempts}. Enter your guess: ");
                if (!int.TryParse(Console.ReadLine(), out int guess) || guess < LowerBound || guess > UpperBound)
                {
                    Console.WriteLine($"Please enter a number between {LowerBound} and {UpperBound}.");
                    continue;
                }

                if (guess == mysteryNumber)
                {
                    Console.WriteLine("Correct! You've guessed the mystery number.");
                    break;
                }

                Console.WriteLine(guess < mysteryNumber ? "Too low." : "Too high.");
                Console.WriteLine($"Hint: The number is {(mysteryNumber % 2 == 0 ? "even" : "odd")}.");
            }

            Console.WriteLine(attempts < MaxAttempts
                ? $"Well done! Your score is: {(MaxAttempts - attempts) * 20}"
                : $"Sorry, you've used all your attempts. The mystery number was {mysteryNumber}.");
        }
    }
}
