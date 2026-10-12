using System;
using System.Collections.Generic;
using System.IO;
class Jurnal
{
    private string filePath = "Journal.txt";
    
    
    List<Entry> _memory_entry = new List<Entry>();
    // Jurnal will handel the loop and instances of Entrys.
    
        public void JurnalLoop()
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("Add New Entry (1)");
            Console.WriteLine("Display Entry(s) (2)");
            Console.WriteLine("Save to File (3)");
            Console.WriteLine("Load From File (4)"); // Added clear option here
            Console.WriteLine("Quit (5)");
            Console.WriteLine("---------------------");
            string checkVal = Console.ReadLine();

            if (checkVal == "1")
            {
                GenerateNewEntry();
            }
            else if (checkVal == "2")
            {
                PrintOldEntrys();
            }
            else if (checkVal == "3")
            {
                SaveDataTXT();
            }
            else if (checkVal == "4")
            {
                SaveUpload loader = new SaveUpload();
                loader.UploadJournal(_memory_entry);
            }
            else if (checkVal == "5")
            {
                run = false;
            }
            else
            {
                run = false;
            }
        }
    }





    public void GenerateNewEntry()
    {
        Entry entry = new Entry();

        entry.GetDate();
        entry.GetPromptGeneratiopn();
        entry.GetResponse();
        entry.DisplayEntry();

        _memory_entry.Add(entry);
        
    }

    public void PrintOldEntrys()
    {
        foreach(Entry i in _memory_entry)
        {
            i.DisplayEntry();
        }
    }

    public void SaveDataTXT()
    {
        List<string> parts = new List<string>();

        // Build a list of all data fields from memory
        foreach (Entry entry in _memory_entry)
        {
            parts.Add(entry._date);
            parts.Add(entry._praompt);
            parts.Add(entry._response);
        }

        // Join everything into a single line separated by "~"
        string singleLineData = string.Join("~", parts);

        // Write to file (Overwrites file so you don't duplicate on multiple saves)
        File.WriteAllText(filePath, singleLineData);
        Console.WriteLine("Journal saved successfully!");
    }


    
}