using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        Random randomGen = new Random();
        int magicNumber = randomGen.Next(1, 101);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? Between 0 and 100. ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}