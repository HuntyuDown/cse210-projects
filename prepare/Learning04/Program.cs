using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment num1 = new Assignment();
        num1.SetName("Joshua Scott");
        num1.SetTopic("Lin Alge");
        num1.GetSummary();

        Console.WriteLine();

        MathAssignment num2 = new MathAssignment(num1.GetName(), num1.GetTopic(), "2.1", "3-15");
        num2.GetSummary();
        num2.GetHomeWorkList();

        Console.WriteLine();

        WritingAssighnment num3 = new WritingAssighnment(num1.GetName(), "Creative Writing", "The Final Show Down!!!");
        num3.GetSummary();
        num3.GetWritingInformation();


    }
}