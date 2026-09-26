using System;

class Program
{
    static void Main(string[] args)
    {
     
    // Get data from user
    DisplayWelcomeMessage();
    string name = AskForName();
    int number = AskForFavoritNumber();
    int birthYear;
    AskForBirthDay(out birthYear);
    int num_squar = NumSquared(number);
    Display(name, num_squar, birthYear);


    static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }


    static string AskForName()
        {
            Console.Write("What is your name (first & last): ");
            string strName = Console.ReadLine();
            return strName;
        }

    static void AskForBirthDay(out int birthYear)
        {
            Console.Write("What is your birth year: ");
            string yearStr = Console.ReadLine();
            birthYear = int.Parse(yearStr);
        }

    static int AskForFavoritNumber()
        {
            Console.Write("What is your favorit number: ");
            string numStr = Console.ReadLine();
            int numReturn = int.Parse(numStr);
            return numReturn;
        }

    static int NumSquared(int number)
        {
            return number*number; 
        }

        static void Display(string name,int num_square,int birthYear)
        {
            Console.WriteLine($"{name}, the square of your number is {num_square}");
            Console.WriteLine($"{name}, you will turn {2026 - birthYear} this year!");
        }
























    }
}