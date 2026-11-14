// Fraction.cs

public class Fraction
{
    private int _top;    // Attribute for the top number
    private int _bottom; // Attribute for the bottom number

    // Constructor with no parameters that initializes the fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter for the top number (default denominator to 1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two parameters for both top and bottom numbers
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the top number
    public int GetTop()
    {
        return _top;
    }

    // Setter for the top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}