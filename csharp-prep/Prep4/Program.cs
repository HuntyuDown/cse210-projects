using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");


        // Inform the user of how this works.
        Console.WriteLine("Enter a list of whole numbers, type 0 when finished.");

        // Creat a list of int to manipulate later
        List<float> num = new List<float>();


        // Creat while loop logic
        bool loop = true;
        while (loop)
        {
            Console.Write("Enter Number: ");
            float HoldNum = int.Parse(Console.ReadLine());

            // Logic to either add to the list or to end the loop
            if (HoldNum != 0)
            {
                num.Add(HoldNum);
            }
            else
            {
                break;
            }   
        }
// Calculate Sum, Ave, and largest Num


        // Sum
        float sum = 0;

        for(int i =0; i < num.Count; i++)
        {
            sum += num[i];
        }
        Console.WriteLine($"The Sum of your numbers is: {sum}");

        // Ave
        float ave = sum/num.Count;
        Console.WriteLine($"Your average is: {ave}");

        // Largest Num
        float largest = 0;

        foreach (float number in num)
        {
            if(number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"Your largest number is: {largest}");



    }
}