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


