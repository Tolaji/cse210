using System;

public class MindfulnessActivity
{
    protected int duration;

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    protected void DisplayStartMessage(string description)
    {
        Console.WriteLine("Welcome to Mindfulness Activity!");
        Console.WriteLine(description);
        Console.WriteLine($"This activity will last for {duration} seconds.");
    }

    protected void DisplayFinishMessage()
    {
        Console.WriteLine("Congratulations! You've completed the activity.");
    }

    protected void Pause(int seconds)
    {
        System.Threading.Thread.Sleep(seconds * 1000);
    }

    public virtual void StartActivity()
    {
        DisplayStartMessage("This is a generic mindfulness activity.");

        // Perform generic mindfulness activity steps here.

        DisplayFinishMessage();
    }

    internal void StartBreathingActivity()
    {
        throw new NotImplementedException();
    }
}
