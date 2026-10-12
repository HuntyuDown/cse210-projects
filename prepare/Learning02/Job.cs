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
