using System;

class Program
{
    static void Main(string[] args)
    {
        Elevator elevator1 = new Elevator();
        Elevator elevator2 = new Elevator();
        Elevator VIPelevator = new Elevator();

        // Call the elevators and perform actions
        elevator1.GoToFloor(30);
        elevator1.OpenDoors();
        elevator1.CloseDoors();
        elevator1.callelevator();


        elevator2.GoToFloor(30);
        elevator2.OpenDoors();
        elevator2.CloseDoors();
        elevator2.callelevator();


        VIPelevator.GoToFloor(31);
        VIPelevator.OpenDoors();
        VIPelevator.CloseDoors();
        VIPelevator.callelevator();

    }
          public static void DisplayMenu()
    {
        Console.WriteLine("1. Elevator1");
        Console.WriteLine("2. Elevator2");
        Console.WriteLine("3. VIPelevator");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");
    }

}