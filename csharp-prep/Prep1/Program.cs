using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to CSE 210");
        Console.WriteLine("Are you ready to answer some few Questions? Then Lets Go!!");
        Console.Write("What is your Firstname : ");
        String Firstname = Console.ReadLine();

        Console.Write("what is your Lastname : ");
        string Lastname = Console.ReadLine();
        Console.WriteLine($"You provided '{Firstname}' as your first name and '{Lastname}' as your last name,");
        Console.WriteLine($"So you are : {Firstname} {Lastname}.");
    }
}