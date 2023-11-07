using System.Drawing;
using System.Runtime.CompilerServices;

public class Shape
{
    protected string _color;

    protected Shape(string color)
    {
        SetColor(color);  
    }
    
    public virtual double GetArea()
    {
        return 0.0;
    }
    
    public void SetColor(string color)
    {
        _color = color;    
    }

    public string GetColor()
    {
        return _color;
    }
}