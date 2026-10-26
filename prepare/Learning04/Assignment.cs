class Assignment
{
    protected string _studentName = "Name N/A";
    protected string _topic = "Topic N/A";

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;

    }
    public Assignment(){}
    
    public void SetName(string name)
    {
        // string name = Console.ReadLine();
        _studentName = name;
    }

    public void SetTopic(string topic)
    {
        // string topic = Console.ReadLine();
        _topic = topic;
    }

    public void GetSummary()
    {
        Console.WriteLine($"Student: {_studentName}, Topic: {_topic}");

    }

    public string GetName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
}