using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a new user profile
        UserProfile userProfile = new UserProfile
        {
            UserID = 1,
            UserName = "John Doe"
        };

        bool exit = false;
        while (!exit)
        {
            // Display the menu options
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Goal Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Profile");
            Console.WriteLine("6. Load Profile");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            // Handle the user's choice
            switch (choice)
            {
                case "1":
                    CreateNewGoal(userProfile);  // Create a new goal
                    break;
                case "2":
                    RecordGoalEvent(userProfile);  // Record an event for a goal
                    break;
                case "3":
                    userProfile.DisplayGoals();  // Display all goals
                    break;
                case "4":
                    userProfile.DisplayScore();  // Display the user's score
                    break;
                case "5":
                    SaveUserProfile(userProfile);  // Save the user profile
                    break;
                case "6":
                    userProfile = LoadUserProfile();  // Load a user profile
                    break;
                case "7":
                    exit = true;  // Exit the program
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to create a new goal
    static void CreateNewGoal(UserProfile userProfile)
    {
        // Display the goal types
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose goal type: ");
        var goalType = Console.ReadLine();

        // Enter goal details
        Console.Write("Enter goal description: ");
        var description = Console.ReadLine();

        Console.Write("Enter points for the goal: ");
        var points = int.Parse(Console.ReadLine());

        // Create and add the appropriate goal type
        switch (goalType)
        {
            case "1":
                userProfile.AddGoal(new SimpleGoal
                {
                    GoalID = userProfile.Goals.Count + 1,
                    Description = description,
                    Points = points
                });
                break;
            case "2":
                userProfile.AddGoal(new EternalGoal
                {
                    GoalID = userProfile.Goals.Count + 1,
                    Description = description,
                    Points = points
                });
                break;
            case "3":
                Console.Write("Enter target count for the goal: ");
                var targetCount = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points for completing the goal: ");
                var bonusPoints = int.Parse(Console.ReadLine());

                userProfile.AddGoal(new ChecklistGoal
                {
                    GoalID = userProfile.Goals.Count + 1,
                    Description = description,
                    Points = points,
                    TargetCount = targetCount,
                    BonusPoints = bonusPoints
                });
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }

    // Method to record a goal event
    static void RecordGoalEvent(UserProfile userProfile)
    {
        Console.Write("Enter goal ID to record event: ");
        var goalID = int.Parse(Console.ReadLine());
        userProfile.RecordGoalEvent(goalID);
    }

    // Method to save the user profile to a file
    static void SaveUserProfile(UserProfile userProfile)
    {
        Console.Write("Enter file path to save profile: ");
        var filePath = Console.ReadLine();
        userProfile.SaveProfile(filePath);
    }

    // Method to load the user profile from a file
    static UserProfile LoadUserProfile()
    {
        Console.Write("Enter file path to load profile: ");
        var filePath = Console.ReadLine();
        return UserProfile.LoadProfile(filePath);
    }
}
