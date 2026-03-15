namespace zajecia1;

public class Rectangle(double width, double height)
{
    public double Width { get; set; } = width; // auto-prop
    public double Height { get; set; } = height;
    
    // trochę inne
    /*private double _height;

    public double Height
    {
        get { return _height; }
        set
        {
            _height = value;
            // NotifyChange();
        }
    }*/
    
    // public double Area { get => Width * Height; }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
    
    public virtual void SayHello()
    {
        Console.WriteLine("Hello from Rectangle!");
    }
}

public class Square(double size) : Rectangle(size, size)
{
    public override void SayHello()
    {
        // base.SayHello();
        Console.WriteLine("Hello from Square");
    }
}

public abstract class MyAbstract
{
    // public int Test
    public abstract void SayHello();
}

public class Rectangle2 // Javovy sposób, lepiej unikać
{
    private double _width;
    private double _height;
    
    public Rectangle2(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public void SetHeight(double value)
    {
        _height = value;
    }

    public void SetWidth(double value)
    {
        _width = value;
    }

    public String GetHeight()
    {
        return _height.ToString();
    }
}