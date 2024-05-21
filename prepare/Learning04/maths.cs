using System;
public class MathAssignment : Assignment
{
    // Additional private fields
    private string _section;
    private string _problems;

    // Constructor
    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    // Method to get the Math homework list
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}