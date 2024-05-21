using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
 
        // Create an instance of the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        // Call the GetSummary and GetHomeworkList methods and display the results
        string _summary = mathAssignment.GetSummary();
        string _homeworkList = mathAssignment.GetHomeworkList();

        Console.WriteLine(_summary);
        Console.WriteLine(_homeworkList);

        // Create an instance of the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        // Call the GetSummary and GetWritingInformation methods and display the results
        string _summarize = writingAssignment.GetSummary();
        string _writingInfo = writingAssignment.GetWritingInformation();

        Console.WriteLine(_summarize);
        Console.WriteLine(_writingInfo);
    }
}

// internal class MathAssignment
// {
//     public MathAssignment(string v1, string v2, string v3, string v4)
//     {
//     }

//     internal string GetHomeworkList()
//     {
//         throw new NotImplementedException();
//     }

//     internal string GetSummary()
//     {
//         throw new NotImplementedException();
//     }
// }

// internal class WritingAssignment
// {
//     public WritingAssignment(string v1, string v2, string v3)
//     {
//     }

//     internal string GetSummary()
//     {
//         throw new NotImplementedException();
//     }

//     internal string GetWritingInformation()
//     {
//         throw new NotImplementedException();
//     }
// }