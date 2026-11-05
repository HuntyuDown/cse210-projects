// This section has the animations and timing logic
// if % is more then .5 then add one to the repitions cycle.
// timer will be called and initialized by the other 3 classes 

//breathing animation and example from previous test
// test /b
// Console.Write("+");
// Thread.Sleep(1000);
// Console.Write("\b");
// Thread.Sleep(1000);
// Console.Write("your mom");
// Console.Write("\b\b\b\b\b\b\b\b");
// Thread.Sleep(1000);

class Animator
{

    private int _spiner = 3;
    List<string> _spinAnimation = ["-", @"\", "|", "/"];

    List<string> _breath = ["O*****", "OO****", "OOO***", "OOOO**", "OOOOO*", "OOOOOO"];




    public void BreathingAnimation()
    {
        Console.Clear();
        Console.WriteLine("\nBreath in 6 seconds...");
        Console.WriteLine();
        for (int i = 0; i <= 5; i++)
        {
            Console.Write(_breath[i]);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b");
            Console.Write("");
        }
        Console.Clear();
        Console.WriteLine("\nBreath out 4 seconds...");
        Console.WriteLine();
        for (int i = 5; i >= 0; i--)
        {
            Console.Write(_breath[i]);
            Thread.Sleep(666);
            Console.Write("\b\b\b\b\b\b");
            Console.Write("");
        }

    }

    public void FigitSpiner()
    {
        for (int j = 0; j < _spiner+1; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(_spinAnimation[i]);
                Thread.Sleep(250);
                Console.Write("\b");
            }
            // Console.Write("\b");
            Console.Write("");
        }
    }
}

