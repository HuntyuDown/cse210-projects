using System;

class Program
{
    static void Main(string[] args)
    {

        int upper = 100;
        int lower = 0;
        bool game_bool = true;
        while (game_bool)
        {
            
        // Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(lower, upper);
        int guess = -1;
        int guesses = 0;
        
        // Programers re writen guess number to save time
        // number = 5; // <----------------------------------Deleat or deactivate when done!!!

        // Give instructions to the user
        Console.WriteLine("You are playing my guessing game!!!");
        Console.WriteLine($"Pick a integer between {lower} and {upper}!");



        while(number != guess)
        {
        Console.Write("what is the magic number?: ");
        guess = int.Parse(Console.ReadLine());

        if (guess > number)
            {
                Console.WriteLine("That was too high!");
            }
        else if (guess < number)
            {
                Console.WriteLine("That was too low!");
            }
        else
            {
                Console.WriteLine("You got the number!!!");
                guesses ++;
                Console.WriteLine($"You got it in {guesses} guesses!!!");
            }
        guesses++;
        }
        Console.Write("Do you want to continue playing? (y/n)? ");
        string yes_no = Console.ReadLine();
        Console.WriteLine();
        if (yes_no == "y")
            {
                game_bool = true;
            }
            else
            {
                game_bool = false;
            }
        }
    }
}