// Resume Class
public class Resume
{
    List<Job> _Jobs = new List<Job>();

    // Constructor of Resume
    public Resume()
    {
    }
public void DataGatherLoop()
    {
        bool loop = true;
        while (loop)
        {
        
        //instigate a new version of the class Job
        Job job = new Job();

        // Gather Relivent Dater per the iteration of _job
        job.GetCompany();
        job.GetJobTittle();
        job.GetStartYear();
        job.GetEndYear();
        // job.Display(); -----------Not needed here but later
        _Jobs.Add(job); // ----Links to memory addresses to the heap and does not actualy store the whole class
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
        Console.WriteLine();
        // Display each of the seired data from the selected class iterations using the .Display method
        // made in the Job Class
        foreach(Job i in _Jobs)
        {
            i.Display();
            Console.WriteLine();
        }
    }
}