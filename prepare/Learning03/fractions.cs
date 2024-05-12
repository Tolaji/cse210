
using System.Security.Cryptography.X509Certificates;

public class Fractions
{

    // Declared Attributes
    private int _numerator;
    private int _denominator;

    // Declare Constructor with no parameters and initializes the fraction to 1/1
    public Fractions()
    
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Declared constructor with one parameter for numerator that initializes denominator to 1
    public Fractions(int wholeNumber)

    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    // Declared constructor with 2 parameters, top and bottom
    public Fractions(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    


    //  Additional methods to return representations
    
    public string get_FractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double get_DecimalString()
    {
    
       
        return (double)_numerator / (double)_denominator;
    }
}

