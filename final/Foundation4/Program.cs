using System;


class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("Running", new DateTime(2022, 11, 3), 30, 3.0);
        activities.Add(running);

        StationaryBicycle bicycle = new StationaryBicycle("Stationary Bicycle", new DateTime(2022, 11, 4), 45, 20);
        activities.Add(bicycle);

        Swimming swimming = new Swimming("Swimming", new DateTime(2022, 11, 5), 60, 10);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
