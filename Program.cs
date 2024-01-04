namespace MysteryNumberQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxAttempts = 5, LowerBound = 1, UpperBound = 100;
            var random = new Random();
            int mysteryNumber = random.Next(LowerBound, UpperBound + 1);
            string[] hints = new string[MaxAttempts];
            PrepareHints(hints, mysteryNumber);
            int attempt;

            Console.WriteLine("Guess the mystery number between 1 and 100. You have 5 attempts.");

            for (attempt = 0; attempt < MaxAttempts; attempt++)
            {
                Console.Write($"Attempt {attempt + 1}/{MaxAttempts}. Enter your guess: ");
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
                Console.WriteLine($"Hint: {hints[attempt]}");
            }

            Console.WriteLine(attempt < MaxAttempts
                ? $"Well done! Your score is: {(MaxAttempts - attempt) * 20}"
                : $"Sorry, you've used all your attempts. The mystery number was {mysteryNumber}.");
        }

        static void PrepareHints(string[] hints, int mysteryNumber)
        {
            hints[0] = mysteryNumber % 2 == 0 ? "The number is even." : "The number is odd.";
            hints[1] = mysteryNumber % 3 == 0 ? "The number is a multiple of 3." : "The number is not a multiple of 3.";
            hints[2] = mysteryNumber % 5 == 0 ? "The number is a multiple of 5." : "The number is not a multiple of 5.";
            hints[3] = mysteryNumber > 50 ? "The number is greater than 50." : "The number is 50 or less.";
            hints[4] = mysteryNumber > 75 && mysteryNumber > 50 ? "The number is greater than 75." : mysteryNumber < 25 && mysteryNumber <= 50 ? "The number is less than 25." : "The number is either between 25 and 50, or 51 and 75.";
        }
    }
}
