using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        car ford = new car();
        ford.brand = "Ford";
        ford.color = "Blue";
        ford.miles = 1000;

        ford.displayInfo();
        ford.move_forward();

        Console.WriteLine("Your work history");
        Job software_engineer = new Job();
        software_engineer._company = "Google";
        software_engineer._jobTitle = "Senior Developer";
        software_engineer._startYear = 2020;
        software_engineer._endYear = 2024;

        Job Job2 = new Job();
        Job2._jobTitle = "Manager";
        Job2._company = "Apple";
        Job2._startYear = 2022;
        Job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(software_engineer);
        myResume._jobs.Add(Job2);

        myResume.Display();
    }
}