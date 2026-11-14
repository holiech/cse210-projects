
using System;

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction();    
        Fraction fraction2 = new Fraction(5);       
        Fraction fraction3 = new Fraction(3, 4);    
        Fraction fraction4 = new Fraction(1, 3); 

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString()); 
        Console.WriteLine(fraction3.GetDecimalValue());  

        Console.WriteLine(fraction4.GetFractionString()); 
        Console.WriteLine(fraction4.GetDecimalValue());

        Fraction tests = new Fraction();
        
        tests.SetTop(7);
        tests.SetBottom(8);
        Console.WriteLine(tests.GetTop());
        Console.WriteLine(tests.GetBottom());
        Console.WriteLine(tests.GetFractionString());
        Console.WriteLine(tests.GetDecimalValue());
    }
}