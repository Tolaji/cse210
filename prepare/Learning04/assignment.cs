using System;

public class Assignment
{
    // Private fields
    private string _studentName;
    private string _topic;

    // private string _title;

    // Constructor
    public Assignment( string studentName, string topic)
    {
        
        // _title = title;
        _studentName = studentName;
        _topic = topic;
    }

    // Method to return a summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName}'s assignment on {_topic}";
    }
    public string GetStudentName()
    {
        return $"{_studentName}";
    }
}