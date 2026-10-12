
using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string _date;
    public string _praompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_praompt}");
        Console.WriteLine($"Response: {_response}");
    }

    public void GetPromptGeneratiopn()
    {

        List<string> list = new List<string>();
        // Easy way to add new prompts quickly
        list.Add("Who was the most interesting person I interacted with today?");
        list.Add("What was the best part of my day?");
        list.Add("How did I see the hand of the Lord in my life today?");
        list.Add("What was the strongest emotion I felt today?");
        list.Add("If I had one thing I could do over today, what would it be?");

        // Pick one randomly
        Random rand = new Random();
        int num = rand.Next(0,list.Count); 

        //Assighn the random string
        Console.WriteLine($"{list[num]}");
        _praompt = list[num];
    }

    public void GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;
        Console.WriteLine($"{dateText}");
    }

    public void GetResponse()
    {
        Console.WriteLine("Responce/Entry: ");
        string entry = Console.ReadLine();
        _response = entry;
    }


}