// This class needs 3 lists. One holds the scripture list, one has a bool of a comparable list size,
//and the last compares lists and is then called to display.

using System.Security.Cryptography.X509Certificates;

class ScriptureMem
{
    Words scripture = new Words();
    private List<string> _myScripture;
    private List<bool> _isHideScripture;
    private List<string> _showScripture;

    private int _n;


    // initiate the random generator
    Random random = new Random(); // use random.Next(int low, int High + 1) for desired range



    //Constructors
    public ScriptureMem()
    {
        //Empty
        Words scriptureSource = new Words();
        InitializeLists(scriptureSource);

    }
    public ScriptureMem(string CustomScripture)
    {
        // Overloaded
        Words scriptureSource = new Words(CustomScripture);
        InitializeLists(scriptureSource);

    }



    private void InitializeLists(Words source)
    {
        // Populate the master text list using your method from the Words class
        _myScripture = new List<string>(source.SetScriptureBrakeUp());

        // Use the length method you created in the Words class
        _n = source.GetListLength();

        // Instantiate the tracking lists to match size 'n'
        _isHideScripture = new List<bool>(_n);
        _showScripture = new List<string>(_n);

        for (int i = 0; i < _n; i++)
        {
            _isHideScripture.Add(false);       // Starts completely visible
            _showScripture.Add(i.ToString());
        }
    }


    // changes the values on bool
    public void RandomHide()
    {
        for (int i = 0; i < 3; i++)
        {
            int select = random.Next(0, _n);
            _isHideScripture[select] = true;
        }
    }

    public void BuildShowScripture()
    {
        //Build a comparison opperator. If bool = true replace all leters with "_"
        for (int i = 0; i < _n; i++)
        {
            if (_isHideScripture[i] == true)
            {
                // find length of the word
                int k = _myScripture[i].Length;

                //update the underscore length by concatination
                string underS = "";
                for (int j = 0; j < k; j++)
                {
                    underS = underS + "_";
                }

                _showScripture[i] = underS;
            }
            else
            {
                _showScripture[i] = _myScripture[i];
            }

        }
    }

    // Print the scripture
    public void DisplayScript()
    {
        string display = "";
        for (int i = 0; i < _n; i++)
        {
            display = display + _showScripture[i] + " ";
        }
        Console.WriteLine($"{display}");
    }

    public void ShowOriginal()
    {
        string display = "";
        for (int i = 0; i < _n; i++)
        {
            display = display + _myScripture[i] + " ";
        }
        Console.WriteLine($"{display}");
    }

}