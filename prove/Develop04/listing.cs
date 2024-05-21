public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration)
    {
    }

    // Override the StartActivity method from the base class
    public override void StartActivity()
    {
        base.StartActivity();

        DisplayStartMessage("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random random = new Random();

        string randomPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {randomPrompt}");

        Console.WriteLine($"You have {duration} seconds to start listing...");

        Pause(duration);

        // Simulate user listing items (In a real app, you might want to get user input)
        int numberOfItems = random.Next(5, 15);
        Console.WriteLine($"You listed {numberOfItems} items.");

        DisplayFinishMessage();
    }
}
