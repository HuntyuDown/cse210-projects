class ListerActivity : Activity
{
    Animator spin = new Animator();
    // 4 questions
    List<string> _startQuestions = ["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
    // 9 questions

    public ListerActivity() : base()
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
        _intro = "Welcome to the Listing Activity\nThis is an activity to reflect on the question previded and list as many entrys as posable.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
        Console.WriteLine(_intro);
    }


    public void GetConclusion()
    {
        _conclusion = "Thank you for participating in the Listing Activity.\nWe hope you feel more grounded today!";
        Console.WriteLine(_conclusion);
    }

    public void StartQuestion()
    {
        Console.Clear();
        string firstRandomQuest = _startQuestions[Random.Shared.Next(_startQuestions.Count)];
        Console.WriteLine(firstRandomQuest);
        spin.FigitSpiner();
    }


    public void ListerLoop()
    {
        List<string> list = new List<string>();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);

        while(DateTime.Now < futureTime)
        {
            Console.Write("> ");
            list.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed: {list.Count} items in {_duration} seconds!");
    }

}