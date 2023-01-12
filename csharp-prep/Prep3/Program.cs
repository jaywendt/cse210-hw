using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Welcome to my guessing machine!  What is the magic number? ");
        // int number = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Too high!");
            }

            else if (guess < number)
            {
                Console.WriteLine("Too low!");
            }

            else
            {
                Console.WriteLine("You got it!");
            }
        }

    }    
}