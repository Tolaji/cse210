using System;

// Derived class for checklist goals that must be completed a specified number of times
public class ChecklistGoal : Goal
{
    // Specific properties for ChecklistGoal
    public int TargetCount { get; set; }  // Number of times the goal must be completed
    public int CurrentCount { get; set; } // Current number of times the goal has been completed
    public int BonusPoints { get; set; }  // Bonus points awarded upon reaching the target count

    // Override the IsCompleted method to check if the target count has been reached
    public override bool IsCompleted()
    {
        return CurrentCount >= TargetCount; // Return true if current count meets or exceeds target count
    }

    // Override the RecordEvent method to handle the recording of the goal
    public override void RecordEvent(UserProfile userProfile)
    {
        // If the current count is less than the target count
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;               // Increment the current count
            userProfile.Score += Points;  // Add the goal's points to the user's score

            // If the goal is now completed
            if (IsCompleted())
            {
                userProfile.Score += BonusPoints;  // Add the bonus points to the user's score
            }
        }
    }
}
