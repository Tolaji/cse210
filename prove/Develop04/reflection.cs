public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        // ... (other questions)
    };

    public ReflectionActivity(int duration) : base(duration)
    {
    }

    // Override the StartActivity method from the base class
    public override void StartActivity()
    {
        base.StartActivity();

        DisplayStartMessage("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Random random = new Random();

        for (int i = 0; i < duration; i++)
        {
            string randomPrompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine($"Prompt: {randomPrompt}");

            foreach (var question in questions)
            {
                Console.WriteLine($"Question: {question}");
                Pause(2); // Pause for spinner
            }
        }

        DisplayFinishMessage();
    }
}
