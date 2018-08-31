using System;

namespace iCanTotallyDoThis
{
    class Program
    {
        static void Main(string[] args)
        {

            int numTries = 1;
            string input;
            int guess;
            bool correct = false;
            Random rnd = new Random();
            int r = rnd.Next(101);

            Console.WriteLine("Guess a number 1-100!");
            input = Console.ReadLine();
            guess = Convert.ToInt32(input);

            if(guess == r)
            {
                correct = true;
            }

            while (!correct)
            {
                if (guess != r)
                {
                    if (guess < r)
                    {
                        Console.WriteLine("Too low!");
                    }

                    else
                    {
                        Console.WriteLine("Too high!");
                    }

                    numTries++;
                    Console.WriteLine("Guess a number 1-100!");
                    input = Console.ReadLine();
                    guess = Convert.ToInt32(input);
                }
                else
                    correct = true;
            }

            Console.WriteLine("Correct! It took you {0} tries!", numTries);
            Console.ReadKey();

        }
    }
}
