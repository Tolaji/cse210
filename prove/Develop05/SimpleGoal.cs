using System;

// Derived class for simple goals that can be completed once
public class SimpleGoal : Goal
{
    // Private field to track the completion status of the goal
    private bool completed = false;

    // Override the IsCompleted method to return the completion status
    public override bool IsCompleted()
    {
        return completed;
    }

    // Override the RecordEvent method to handle the completion of the goal
    public override void RecordEvent(UserProfile userProfile)
    {
        // If the goal is not already completed
        if (!completed)
        {
            completed = true;             // Mark the goal as completed
            userProfile.Score += Points;  // Add the goal's points to the user's score
        }
    }
}
