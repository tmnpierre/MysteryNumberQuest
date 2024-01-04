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
            int lowerBound = 1;
            int upperBound = 100;

            Console.WriteLine("The mystery number has been generated. Try to guess it!");
            Console.WriteLine($"You have {maxAttempts} attempts.");

            while (attempts < maxAttempts && !isGuessedCorrectly)
            {
                Console.Write($"Enter your guess (between {lowerBound} and {upperBound}): ");
                int guess;
                if (int.TryParse(Console.ReadLine(), out guess) && guess >= lowerBound && guess <= upperBound)
                {
                    if (guess == mysteryNumber)
                    {
                        Console.WriteLine("Correct! Congratulations, you've guessed the mystery number.");
                        isGuessedCorrectly = true;
                    }
                    else
                    {
                        if (guess < mysteryNumber)
                        {
                            Console.WriteLine("Too small. Try again.");
                            lowerBound = guess + 1;
                        }
                        else
                        {
                            Console.WriteLine("Too big. Try again.");
                            upperBound = guess - 1;
                        }

                        Console.WriteLine($"Hint: The mystery number is {(mysteryNumber % 2 == 0 ? "even" : "odd")}.");
                        if (attempts < maxAttempts - 1) 
                        {
                            Console.WriteLine($"Additional hint: The number is between {lowerBound} and {upperBound}.");
                        }

                        attempts++;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input. Please enter a number between {lowerBound} and {upperBound}.");
                }
            }

            if (!isGuessedCorrectly)
            {
                Console.WriteLine($"Sorry, you've used all your attempts. The mystery number was {mysteryNumber}.");
            }
        }
    }
}
