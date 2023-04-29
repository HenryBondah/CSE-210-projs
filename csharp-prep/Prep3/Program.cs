using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
         
        int guess = -1;

        while (guess != magicNumber)
            {
            Console.Write("what is your guess? (Between 1-100): ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("sorry!! Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine(" sorry!! Lower");
            }
            else
            {
                Console.WriteLine("hey!  You guessed it!");
            }
        }
    }
}