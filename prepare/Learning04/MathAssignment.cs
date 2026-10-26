using System.Security.Cryptography.X509Certificates;

class MathAssignment : Assignment
{
    private string _textbookSection = "N/A";
    private string _problems = "N/A";

    public MathAssignment(string name, string topic, string textbookSection, string problems)
        : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    

    public void SetTextbookSection()
    {
        string textbook = Console.ReadLine();
        _textbookSection = textbook;
    }


    public void SetProblems()
    {
        string problems = Console.ReadLine();
        _problems = problems;
    }


    public void GetHomeWorkList()
    {
        Console.WriteLine($"Sections: {_textbookSection}, Problems: {_problems}");
    }






}