using System;

/* Create a class for a function that has:
* Attributes for the top and bottm numbers
* Constructors
* Getters and setters for the top and bottom numbers
* Methods to return representations of both the fractional and decimal views
*/
public class Fraction
{
    private int _top;
    private int _bottom;

    // CONSTRUCTORS: 
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //METHODS
    public string GetFractionString()
    {
        string top1 = _top.ToString();
        string bottom1 = _bottom.ToString();

        string fractionForm = top1 + "/" +  bottom1;
        return fractionForm;
        //string text = $"{_top}/{_bottom}";
        //return text;
    }

    public double GetDecimalValue()
    {
        double topD = _top;
        double bottomD = _bottom;
        double decimalForm = topD / bottomD;
        return decimalForm;
        //return (double)_top / (double)_bottom;
    }


}