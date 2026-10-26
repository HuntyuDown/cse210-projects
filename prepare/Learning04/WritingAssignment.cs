class WritingAssighnment : Assignment
{
    private string _title = "N/A";


    public WritingAssighnment(string name, string topic, string title)
        : base(name, topic)
    {
        _title = title;

    }

    public void SetTitle()
    {
        string title = Console.ReadLine();
        _title = title;
    }

    public void GetWritingInformation()
    {
        Console.WriteLine($"Title: {_title}");
    }
}