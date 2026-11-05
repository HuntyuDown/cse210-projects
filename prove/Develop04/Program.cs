using System;

class Program
{
    static void Main(string[] args)
    {


        bool repeat = true;
        // Create a repeating system that generates new classes every time the user repeats to preserve unique ness and choice.
        while (repeat)
        {
            if (repeat == true)
            {
                // Initiate the UI for the user to pick which activity to do
                Console.Write("Welcome to the mindfullnes app.\n\n What activity would you like to do?\n1) Breathing Exercises\n2) Reflection Exercises\n3) Listing Exercises\nPlease input (1,2, or 3): ");
                string choice = Console.ReadLine();



                // test /b
                // Console.Write("+");
                // Thread.Sleep(1000);
                // Console.Write("\b");
                // Thread.Sleep(1000);
                // Console.Write("your mom");
                // Console.Write("\b\b\b\b\b\b\b\b");
                // Thread.Sleep(1000);
                if (choice == "1")
                {
                    BreathingActivity breath = new BreathingActivity();
                    Animator spin = new Animator();
                    spin.FigitSpiner();
                    breath.GetIntro();
                    spin.FigitSpiner();
                    Console.Write("How long do you want this activity to last in seconds: ");
                    int time = int.Parse(Console.ReadLine());
                    spin.FigitSpiner();
                    Console.WriteLine();
                    breath.GetBreathingPatern(time);
                    Console.Clear();
                    breath.GetConclusion();
                    spin.FigitSpiner();
                }




                // initialize the class chosen











                // Check if the user would like to repeat the cycle. 
                Console.Write("Would you like to do another activity (y/n): ");
                string repeatCheck = Console.ReadLine();
                if (repeatCheck != "y")
                {
                    repeat = false;
                }
            }

        }
    }
}