using System;

class Program
{
    static void Main(string[] args)
    {   
        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        int F = 50;
        int CatchValue = 0;
        String Sign = "";

        Console.Write("What is your grade percentage?");
        String TextValue = Console.ReadLine();
        int value = int.Parse(TextValue);
        // Store the Letter grade variable
        String LetterGrade = "N/A";

        if(value >= A)
        {
            LetterGrade = "A";
            CatchValue = A;
        }
        else if (value >= B)
        {
            LetterGrade = "B";
            CatchValue = B;
        }
         else if (value >= C)
        {
            LetterGrade = "C";
            CatchValue = C;
        }
         else if (value >= D)
        {
            LetterGrade = "D";
            CatchValue = D;
        }
        else
        {
            LetterGrade = "F";
            CatchValue = F;
        }


        // Determin Sign of Letter Grade
        if((value - CatchValue) >= 7)
        {
            Sign = "+";
        }
        else if ((value - CatchValue) >= 4)
        {
            Sign = "";
        }
        else if ((value - CatchValue) >= 0)
        {
            Sign = "-";
        }
        if (CatchValue < D)
        {
            Sign = "";
        }











        // Print results
        Console.WriteLine($"You got an {LetterGrade}{Sign}");
        if (value >= 70)
        {
            Console.Write("You Passed!!!");
        }
        else
        {
            Console.Write("You Failed... Better luck next time!!!");
        }
    }
}