using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        // Create instances of the derived classes
        BreathingActivity breathingActivity = new BreathingActivity(30);
        ReflectionActivity reflectionActivity = new ReflectionActivity(30);
        ListingActivity listingActivity = new ListingActivity(30);

        // Call StartActivity on each derived class
        Console.WriteLine("\nStarting Breathing Activity:");
        breathingActivity.StartActivity();

        Console.WriteLine("\nStarting Reflection Activity:");
        reflectionActivity.StartActivity();

        Console.WriteLine("\nStarting Listing Activity:");
        listingActivity.StartActivity();
    }
}
