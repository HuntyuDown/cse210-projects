class Fraction
{
    private int _top = 1;
    private int _bottom = 1;





    // Constructors
    public Fraction()
    {

    }
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }




    // Getters and Setters
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int num)
    {
        ;
        _top = num;
        //int
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int num)
    {
        
        _bottom = num;

        //int
    }

    public void GetFractionString()
    {
        //displays fraction as a string
        
        Console.WriteLine($"{GetTop()}/{GetBottom()}");
    }
    public void GetDecimalValue()
    {
        // displays the fraction as a sync double
        //double
        double topNumber  = GetTop();
        double bottomNumber = GetBottom();
        double Decimal = topNumber/bottomNumber;
        Console.WriteLine($"{Decimal}");
    }
    
}