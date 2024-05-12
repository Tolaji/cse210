using System;

class Program
{
    static void Main(string[] args)
    {
        // Print a simple greeting message to the console
        Console.WriteLine("Hello Learning03 World!");

        // Create an instance of the Fractions class using the default constructor (1/1)
        Fractions fraction1 = new Fractions();
        Console.WriteLine(fraction1.get_FractionString());   // Output: "1/1"
        Console.WriteLine(fraction1.get_DecimalString());    // Output: "1.0"

        // Create an instance of the Fractions class using the constructor with one parameter (6/1)
        Fractions fraction2 = new Fractions(6);
        Console.WriteLine(fraction2.get_FractionString());   // Output: "6/1"
        Console.WriteLine(fraction2.get_DecimalString());    // Output: "6.0"

        // Create an instance of the Fractions class using the constructor with two parameters (6/7)
        Fractions fraction3 = new Fractions(6, 7);
        Console.WriteLine(fraction3.get_FractionString());   // Output: "6/7"
        Console.WriteLine(fraction3.get_DecimalString());    // Output: "0.8571428571428571"
        
        // Create an instance of the Fractions class using the constructor with two parameters (6/7)
        Fractions fraction4 = new Fractions(1, 3);
        Console.WriteLine(fraction4.get_FractionString());   // Output: "1/3"
        Console.WriteLine(fraction4.get_DecimalString());    // Output: "0.3333333333333333"


    }

}