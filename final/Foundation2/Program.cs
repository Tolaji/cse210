
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Event Planning!");
        // Create sample events
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Lecture lecture = new Lecture("Introduction to C#", "Learn the basics of C# programming", new DateTime(2024, 6, 15, 18, 0, 0), "6:00 PM", address1, "John Doe", 50);

        Address address2 = new Address("456 Oak Rd", "Somewhere", "NY", "67890");
        Reception reception = new Reception("Summer Networking Event", "Join us for networking and refreshments", new DateTime(2024, 7, 20, 19, 0, 0), "7:00 PM", address2, "rsvp@company.com");

        Address address3 = new Address("789 Pine Ave", "Elsewhere", "FL", "54321");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy a day of fun and games", new DateTime(2024, 8, 10, 12, 0, 0), "12:00 PM", address3, "Sunny with highs around 80°F");

        // Display event details
        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }
}
