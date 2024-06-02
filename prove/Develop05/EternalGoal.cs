using System;

// Derived class for eternal goals that can be recorded multiple times
public class EternalGoal : Goal
{
    // Override the IsCompleted method to always return false
    // since eternal goals are never fully completed
    public override bool IsCompleted()
    {
        return false;
    }

    // Override the RecordEvent method to add points each time the goal is recorded
    public override void RecordEvent(UserProfile userProfile)
    {
        userProfile.Score += Points;  // Add the goal's points to the user's score
    }
}
