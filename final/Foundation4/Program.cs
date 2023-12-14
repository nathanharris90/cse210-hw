using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 12, 11), 30, 3.0),
            new Running(new DateTime(2023, 12, 11), 30, 4.8),
            new StationaryBicycles(new DateTime(2023, 12, 11), 45, 20),
            new Swimming(new DateTime(2023, 12, 11), 30, 20),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
