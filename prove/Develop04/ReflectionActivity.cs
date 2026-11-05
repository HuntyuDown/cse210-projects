class ReflectionActivity : Activity
{
    Animator spin = new Animator();
    // 4 questions
    List<string> _startQuestions = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    // 9 questions
    List<string> _randomQuestions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];

    public ReflectionActivity() : base()
    {
        //int duration, string intro, string conclusion
        //duration, intro, conclusion
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }



    public void GetIntro()
    {
        _intro = "Welcome to the Reflection Activity\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        Console.WriteLine(_intro);
    }


    public void GetConclusion()
    {
        _conclusion = "Thank you for participating in the Reflection Activity.\nWe hope you feel more grounded today!";
        Console.WriteLine(_conclusion);
    }

    public void StartQuestion()
    {
        Console.Clear();
        string firstRandomQuest = _startQuestions[Random.Shared.Next(_startQuestions.Count)];
        Console.WriteLine(firstRandomQuest);
        spin.FigitSpiner();
    }

    public void RandomQuestion()
    {
        int time = (int)_duration - 3;
        time = time/3;
        if (time < 0)
        {
            time = 1;
        }


        for (int i = 0; i <= time; i++)
        {

            string randomQuest = _randomQuestions[Random.Shared.Next(_randomQuestions.Count)];
            Console.WriteLine(randomQuest);
            spin.FigitSpiner();

        }
    }






}