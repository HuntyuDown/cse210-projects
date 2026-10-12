using System;
using System.Collections.Generic;
using System.IO;

class SaveUpload
{
        private string filePath = "Journal.txt";
        public void UploadJournal(List<Entry> journalList)
    {
            if (!File.Exists(filePath)) return;

        // Now C# knows exactly what "filePath" means here:
            string savedText = File.ReadAllText(filePath);
    
            if (string.IsNullOrWhiteSpace(savedText)) return;

            string[] components = savedText.Split('~');

        // Clear existing memory so loading doesn't duplicate entries
            journalList.Clear();

            for (int i = 0; i < components.Length; i += 3)
            {
                if (i + 2 < components.Length)
                {
                    Entry loadedEntry = new Entry
                    {
                        _date = components[i],
                        _praompt = components[i + 1],
                        _response = components[i + 2]
                    };

                    journalList.Add(loadedEntry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
    }
}


 