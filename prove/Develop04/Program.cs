using System;

class Program
{
    static void Main(string[] args)
    {
        Animator spin = new Animator(); // animations only need to be called once ever.

        bool repeat = true;
        // Create a repeating system that generates new classes every time the user repeats to preserve unique ness and choice.
        while (repeat)
        {
            if (repeat == true)
            {
                // Initiate the UI for the user to pick which activity to do
                Console.Write("Welcome to the mindfullnes app.\n\n What activity would you like to do?\n1) Breathing Exercises\n2) Reflection Exercises\n3) Listing Exercises\nPlease input (1,2, or 3): ");
                string choice = Console.ReadLine();



                // breathing activity
                if (choice == "1")
                {
                    BreathingActivity breath = new BreathingActivity();

                    spin.FigitSpiner();
                    breath.GetIntro();
                    spin.FigitSpiner();
                    Console.Write("How long do you want this activity to last in seconds: ");
                    int time = int.Parse(Console.ReadLine());
                    breath.SetDuration(time);
                    Console.Write("\nPlease prepare to begin.");
                    spin.FigitSpiner();
                    Console.WriteLine();
                    breath.GetBreathingPatern();
                    Console.Clear();
                    breath.GetConclusion();
                    spin.FigitSpiner();
                }




                // Reflection activity
                if (choice == "2")
                {
                    ReflectionActivity reflect = new ReflectionActivity();
                    reflect.GetIntro();
                    spin.FigitSpiner();
                    Console.Write("How long would you like this activity in seconds: ");
                    int time = int.Parse(Console.ReadLine());
                    Console.Write("\nPlease prepare to begin.");
                    spin.FigitSpiner();
                    reflect.SetDuration(time);
                    reflect.StartQuestion();
                    reflect.RandomQuestion();
                    reflect.GetConclusion();
                }

                if (choice == "3")
                {
                    ListerActivity list = new ListerActivity();
                    list.GetIntro();
                    spin.FigitSpiner();
                    Console.Write("How long would you like this activity in seconds: ");
                    int time = int.Parse(Console.ReadLine());
                    spin.FigitSpiner();
                    Console.Write("\nPlease prepare to begin.");
                    spin.FigitSpiner();
                    list.StartQuestion();
                    list.SetDuration(time);
                    list.ListerLoop();
                    spin.FigitSpiner();
                    list.GetConclusion();

                }









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