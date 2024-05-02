using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // Create a new instance of 'job' class
        Job job1 = new Job();

        // Add attributes to 'job1' fields
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create a new instance of 'job' class
        Job job2 = new Job();

        // Add attributes to 'job1' fields
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.DisplayJobInfo();
        job2.DisplayJobInfo();

        {
            // Create new instance of 'Resume' class
            Resume resume = new Resume();

            // Add attributes to 'resume' fields
            // Add attributes to 'job1' fields
            resume._personName = "Allison Rose";   

            resume._jobsList.Add(job1);
            resume._jobsList.Add(job2);

            resume.DisplayResume();

        }

    }
        
        
}