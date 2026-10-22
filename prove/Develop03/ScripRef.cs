class ScripRef
{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int _endVerse;


    //Overloaded constructors

    //basic constructor
    public ScripRef()
    {
        _book = "Hebrews";
        _chapter = "1";
        _startVerse = 1;
        _endVerse = 3;

    }
    public ScripRef(string book, string chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }



    //Get methods
    //For this program I will not need to update anything only read initulized information from this class
    public string GetBook()
    {
        return _book;
    }
    public string GetChapter()
    {
        return _chapter;
    }
    public int GetFirstVerse()
    {
        return _startVerse;
    }
    public int GetLastVerse()
    {
        return _endVerse;
    }

    //The header in this case is Book Chapter: verse 1 - verse 2
    // if the verse shares the same int value only verse 1 will display
    public void DisplayHeader()
    {
        if (GetFirstVerse() - GetLastVerse() == 0)
        {
            Console.Write($"{GetBook()} {GetChapter()}({GetFirstVerse()}):");
        }
        else
        {
            Console.Write($"{GetBook()} {GetChapter()}:({GetFirstVerse()} - {GetLastVerse()}): ");
        }
    }



}