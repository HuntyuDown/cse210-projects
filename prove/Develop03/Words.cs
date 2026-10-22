//Sends a broken list of the scripture to ScriptureMem to initialize all feilds

class Words
{
    private string _scripture;
    private int _listLength;

// Overloaded constructors
    public Words()
    {
        _scripture = "\n1 God, who at sundry times and in divers manners spake in time past unto the fathers by the prophets,\n2 Hath in these last days spoken unto us by his Son, whom he hath appointed heir of all things, by whom also he made the worlds;\n3 Who being the brightness of his glory, and the express image of his person, and upholding all things by the word of his power, when he had by himself purged our sins, sat down on the right hand of the Majesty on high;";
    }
    public Words(string scripture)
    {
        _scripture = scripture;


    }
  
    
    // Brake it up by " " Sections and return it. We will initalize the lists in ScriptureMem with it
    public string[] SetScriptureBrakeUp()
    {
        return _scripture.Split(' ');
    }

    private void SetListLength()
    {
        _listLength = SetScriptureBrakeUp().Length;
    }

    public int GetListLength()
    {
        SetListLength();
        return _listLength;
    }
}