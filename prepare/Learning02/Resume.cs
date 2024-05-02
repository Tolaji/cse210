using System;

public class Resume
{
    // Public fields
    public string _personName;

    //  Initialize list to a new list
    public List<Job> _jobsList = new List<Job>();

    // Method to display job information
    public void DisplayResume()
    {

        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($" Jobs:");

        
        foreach (Job job in _jobsList)
        {
            // This calls the Display method on each job
            job.DisplayJobInfo();
        }
    }


}

