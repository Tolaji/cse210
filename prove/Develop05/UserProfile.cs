using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class UserProfile
{
    // Properties for the user's profile
    public int UserID { get; set; }            // Unique identifier for the user
    public string UserName { get; set; }       // Name of the user
    public List<Goal> Goals { get; set; } = new List<Goal>(); // List of the user's goals
    public int Score { get; set; }             // Current score of the user

    // Method to add a new goal to the user's profile
    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    // Method to record an event of completing a goal
    public void RecordGoalEvent(int goalID)
    {
        var goal = Goals.Find(g => g.GoalID == goalID);  // Find the goal by ID
        if (goal != null)  // Check if the goal exists
        {
            goal.RecordEvent(this);  // Record the event of completing the goal
        }
    }

    // Method to display all goals and their statuses
    public void DisplayGoals()
    {
        foreach (var goal in Goals)  // Iterate through each goal
        {
            // Display goal description and status
            Console.WriteLine($"{goal.Description} - {(goal.IsCompleted() ? "[X]" : "[ ]")}");

            // If the goal is a ChecklistGoal, display its progress
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times");
            }
        }
    }

    // Method to display the user's current score
    public void DisplayScore()
    {
        Console.WriteLine($"Score: {Score}");
    }

    // Method to save the user's profile to a file
    public void SaveProfile(string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(this, options); // Serialize the user profile to JSON
        File.WriteAllText(filePath, jsonString); // Write the JSON string to the file
    }

    // Static method to load the user's profile from a file
    public static UserProfile LoadProfile(string filePath)
    {
        string jsonString = File.ReadAllText(filePath); // Read the JSON string from the file
        return JsonSerializer.Deserialize<UserProfile>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }); // Deserialize the JSON string to a UserProfile object
    }
}
