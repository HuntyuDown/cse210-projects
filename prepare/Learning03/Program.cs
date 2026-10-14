using System;

class Program
{
    
    static void Main(string[] args)
    {
        //     Fraction fraction = new Fraction();
        //     fraction.GetFractionString();
        //     fraction.GetDecimalValue();

        //     Fraction fraction1 = new Fraction(5);
        //     fraction1.GetFractionString();
        //     fraction1.GetDecimalValue();

        //     Fraction fraction2 = new Fraction(5, 2);
        //     fraction2.GetFractionString();
        //     fraction2.GetDecimalValue();
        Program newProgram = new Program();
        newProgram.FractionGenerator();
    }


    public void FractionGenerator()
    {
        Random rand = new Random();
        for (int i = 0; i < 20; i++)
        {

            Fraction fraction = new Fraction();



            int randNum = rand.Next(1, 100);
            fraction.SetTop(randNum);

            int randNum2 = rand.Next(1, 100);
            fraction.SetBottom(randNum2);


            Console.WriteLine($"Fraction {i + 1}:");
            fraction.GetFractionString();
            fraction.GetDecimalValue();
        }
    }
}


// Alt shift f Auto formats my code