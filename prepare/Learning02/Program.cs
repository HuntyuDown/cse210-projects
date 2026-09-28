using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // ------------------Test Job Class"-------------------------
        // Console.WriteLine("Hello Learning02 World!");
        // Job job = new Job();
        // job.GetCompany();
        // job.GetJobTittle();
        // job.GetStartYear();
        // job.GetEndYear();
        // job.Display();

        //----------------------- Run Resume Class ----------------------
        Resume run = new Resume();
        run.DataGatherLoop();
        run.ResumeDisplay();

    }
}
public class Job
{
// Responsibilities:
// Keeps track of the company, job title, start year, and end year.

// Behaviors:
// Displays the job information in the format "Job Title (Company) StartYear-EndYear",
//  for example: "Software Engineer (Microsoft) 2019-2022".

public string _company = "";
public string _jobTittle = "";
public int _jobStartYear = 0;
public int _jobEndYear = 0;

// Constructor
public Job()
    {      
    }

// Field updater functions
public void GetCompany()
    {
        Console.Write("Company Name: ");
        _company = Console.ReadLine();
    }
public void GetJobTittle()
    {
        Console.Write("Position: ");
        _jobTittle = Console.ReadLine();
    }
public void GetStartYear()
    {
        Console.Write("Year Started: ");
        _jobStartYear = int.Parse(Console.ReadLine());
    }
public void GetEndYear()
    {
        Console.Write("Year Ended: ");
        _jobEndYear = int.Parse(Console.ReadLine());
    }

public void Display()
    {
        Console.Write($"Company: {_company}, Position: {_jobTittle}, Start Year: {_jobStartYear}, End Year: {_jobEndYear}");
    }
}


// Resume Class
public class Resume
{
    List<Job> _Jobs = new List<Job>();
    // Constructor Resume
    public Resume()
    {
    }
public void DataGatherLoop()
    {
        bool loop = true;
        while (loop)
        {
        
        //instigate a nwe version of the clas Job
        Job job = new Job();

        // Gather Relivent Dater per the iteration of _job
        job.GetCompany();
        job.GetJobTittle();
        job.GetStartYear();
        job.GetEndYear();
        // job.Display();
        _Jobs.Add(job);
        Console.Write("Would you like to add another job? (y/n): ");
        string response = Console.ReadLine();
        if (response != "y")
            {
                loop = false;
            }

        }
    }
public void ResumeDisplay()
    {
        Console.WriteLine("Resume: ");
        foreach(Job i in _Jobs)
        {
            i.Display();
            Console.WriteLine();
        }
    }
}