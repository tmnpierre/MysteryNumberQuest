namespace MysteryNumberQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int mysteryNumber = random.Next(1, 101);

            Console.WriteLine("The mystery number has been generated. Try to guess it!");
        }
    }
}
