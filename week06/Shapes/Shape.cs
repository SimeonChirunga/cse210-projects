public abstract class Shape
{
    private string _color;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string Color)
    {
        _color = Color;
    }
    // the constructor
    public Shape(string Color)
    {
        _color = Color;
    }
    public abstract double GetArea();
}

