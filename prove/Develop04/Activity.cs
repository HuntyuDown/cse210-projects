class Activity
{

    protected string _intro;
    protected string _conclusion;
    protected int _duration;


    public Activity(int duration, string intro, string conclusion)
    {
        _intro = intro;
        _conclusion = conclusion;
        _duration = duration;
    }
    public Activity() { }

    public void StartMessage()
    {
        Console.WriteLine(_intro);
         
        
    }
    public void conclusionMessage()
    {
        Console.WriteLine(_conclusion);
        
        
    }


}