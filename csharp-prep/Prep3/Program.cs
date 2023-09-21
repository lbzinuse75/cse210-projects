using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

       Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        int userGuess = -1;

        while (magicNumber != userGuess)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}