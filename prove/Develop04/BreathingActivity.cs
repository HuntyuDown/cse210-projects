class BreathingActivity : Activity
{
    public BreathingActivity() : base()
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
        _intro = "Welcome to the Breathing Activity\nThis is a box breathing activity where you will breath in for 4 seconds and out for 6 seconds";
        Console.WriteLine(_intro);
    }


    public void GetConclusion()
    {
        _conclusion = "Thank you for participating in the Breathing Activity.\nWe hope you feel more grounded today!";
        Console.WriteLine(_conclusion);
    }



    // This pulls from the Timer class to get dellay and repititions
    public void GetBreathingPatern()
    {
        Animator breath = new Animator();
        float reps = _duration / 10;
        reps = MathF.Round(reps);
        if (reps == 0)
        {
            reps = 1;
        }
        for (int i = 0; i < reps; i++)
        {
            breath.BreathingAnimation();
        }

    }

    

}