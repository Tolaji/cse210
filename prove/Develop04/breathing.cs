public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration)
    {
    }

    // Override the StartActivity method from the base class
    public override void StartActivity()
    {
        // Access the protected methods from the base class
        DisplayStartMessage("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        for (int i = 0; i < duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Pause(2);
            Console.WriteLine("Breathe out...");
            Pause(2);
        }

        // Access the protected method from the base class
        DisplayFinishMessage();
    }
}
