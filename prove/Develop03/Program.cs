using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Test class
        // ScripRef script = new ScripRef("Joshua", "1", 1, 1);
        // script.DisplayHeader();

        // //Test overloaded constructor
        // ScripRef script = new ScripRef();
        // script.DisplayHeader();

        // // Test if constructors are working corectly
        // ScriptureMem memorize = new ScriptureMem("YEEEAHHHH");
        // memorize.QuickDisplay();


        ScripRef reff = null;
        ScriptureMem mem = null;

        Console.Write("Would you like to imput your own scripture? (y/n)");
        string Yn = Console.ReadLine();
        if (Yn == "y")
        {
            // Colect string book, string chapter, int startVerse, int endVerse, and String of scripture
            Console.Write("Book: ");
            string book = Console.ReadLine();
            Console.Write("Chapter: ");
            string chapter = Console.ReadLine();
            Console.Write("Start Verse:");
            int sVerse = int.Parse(Console.ReadLine());
            Console.Write("End Verse:");
            int eVerse = int.Parse(Console.ReadLine());
            Console.Write("Scripture");
            string scripture = Console.ReadLine();

            reff = new ScripRef(book, chapter, sVerse, eVerse);
            mem = new ScriptureMem(scripture);
            reff.DisplayHeader();
            mem.BuildShowScripture();
            mem.DisplayScript();
            Console.ReadLine();
        }
        else
        {

            reff = new ScripRef();
            mem = new ScriptureMem();
            reff.DisplayHeader();
            mem.BuildShowScripture();
            mem.DisplayScript();
            Console.ReadLine();
        }

        while (true)
        {
            Console.Clear();
            reff.DisplayHeader();
            mem.RandomHide();
            mem.BuildShowScripture();
            mem.DisplayScript();
            Console.WriteLine("\nPress enter to continue");
            Console.WriteLine("Type 'quit' to stop");
            Console.WriteLine("Type 'show' to see the original");
            string check = Console.ReadLine();
            if (check == "quit")
            {
                break;
            }
            if (check == "show")
            {
                Console.Write("\n\n");
                reff.DisplayHeader();
                mem.ShowOriginal();
                Console.WriteLine("\nPress enter to continue\n");
                Console.Read();
            }

        }




    }
}