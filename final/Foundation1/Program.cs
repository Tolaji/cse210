using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Exercise Tracking!");
        // Create sample activities
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 9.7);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 60);

        // Add activities to a list
        List<Activity> activities = new List<Activity>
        {
            running,
            cycling,
            swimming
        };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
