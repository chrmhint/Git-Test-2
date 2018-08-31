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
            

            Console.WriteLine("Please enter a range");
            string[] tokens = Console.ReadLine().Split();
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);

            Console.WriteLine("Guess a number between {0} and {1}!", a, b);
            int r = rnd.Next(a, b);
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
                    Console.WriteLine("Guess a number between {0} and {1}!", a, b);
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
