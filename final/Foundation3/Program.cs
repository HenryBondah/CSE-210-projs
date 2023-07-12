using System;


class Program
{
    static void Main()
    {
        Event lecture = new Lecture("Lecture 1", "Speaker 1", "Description 1", "Date 1", "Time 1", "Address 1", 100);
        Event reception = new Reception("Reception 1", "Description 2", "Date 2", "Time 2", "Address 2", "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Outdoor Gathering 1", "Description 3", "Date 3", "Time 3", "Address 3", "Sunny");

        List<Event> events = new List<Event>();
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        foreach (Event ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}
