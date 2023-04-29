using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("enter a number: ");
        string number = Console.ReadLine();

        int x = int.Parse(number);
        int y = 6;

        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else
        {
            Console.WriteLine("Equal");
        }
        

        Console.WriteLine("Tell me Name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Your name is {name}");

        int Number =10;
        Number = Number + 4;
        Console.WriteLine($" Alright {name}, I guess your magic number is ");
        Console.WriteLine(Number);
        

        Console.WriteLine("write a number");
        number = Console.ReadLine();
        int NumberEntered = int.Parse(number);
        Console.WriteLine($"You typed {number}");
        Console.WriteLine($"This and your magic number will Magically.,m/m.,/,/.,/m be {Number + number}");

        // while loops
        string response = "yes";
        while (response == "yes");
        {
            Console.Write("Do you have a questions? ");
            response = Console.ReadLine();
        }

        // example code

        Console.WriteLine("Enter Your Number (Between 1-100): ");
        int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        // int magicNumber = randomGenerator.Next(1, 101);
         
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
