using System;

// Abstract base class for all types of goals
public abstract class Goal
{
    // Common properties for all goals
    public int GoalID { get; set; }           // Unique identifier for the goal
    public string Description { get; set; }   // Description of the goal
    public int Points { get; set; }           // Points awarded for completing the goal

    // Abstract method to check if the goal is completed
    public abstract bool IsCompleted();

    // Abstract method to record an event of completing the goal
    public abstract void RecordEvent(UserProfile userProfile);
}
