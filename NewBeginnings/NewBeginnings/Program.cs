using System;

namespace NewBeginnings
{
    class Program
    {
        static void Main(string[] args)

        {
         
            bool playing = true;

            while (playing) {

                int guesses = 0;
                bool guessed = false;

                Random rand = new Random();
                int target = rand.Next(1, 100);
                Console.WriteLine("I'm thinking of a number...");

                while (!guessed) {
                    int guess = Convert.ToInt32(Console.ReadLine());
                    guesses++;

                    if (guess == target)
                    {
                        Console.WriteLine("Correct");
                        Console.WriteLine("Guessed in " + Convert.ToString(guesses) + " tries.");
                        guessed = true;
                    }
                    else if (guess > target)
                    {
                        Console.WriteLine("Lower!");
                    }
                    else if (guess < target)
                    {
                        Console.WriteLine("Higher!");
                    }
                }

                Console.WriteLine("Play Again [Y/N]?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "n")
                {
                    playing = false;
                }
            }
        }

    }
}
