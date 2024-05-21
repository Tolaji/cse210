using System;
public class WritingAssignment : Assignment
{
    // Private member variables specific to WritingAssignment
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get the writing information
    public string GetWritingInformation()
    {
        // Access the studentName using the GetStudentName method from the base class
        string studentName = base.GetStudentName();
        return $" by {studentName}";
    }
}