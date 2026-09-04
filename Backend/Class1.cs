namespace GeometricFigure.Backend;

public abstract class GeometricFigure
{
    // Properties
    public string Name { 
        get => _name
        set => _name
    } = null!;

    // Methods public
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name}\n" +
               $"=> Area.....: {GetArea(),15:N5}\n" +
               $"   Perimeter: {GetPerimeter(),15:N5}\n";
    }
}



public class Circle : GeometricFigure
{
    // Fields
    private double _r;

    // Properties
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    // Constructors
    public Circle(string name, double r)
    {
        Name = name;
        R = r;
    }

    // Methods
    public override double GetArea()
    {
        return Math.PI * Math.Pow(R, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("El radio debe ser mayor a 0 // The radius must be greater than 0");
        }
        return r;
    }
}



public class Square : GeometricFigure
{
    // Fields
    private double _a;

    // Properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Constructors
    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    public Square() { }

    // Methods
    public override double GetArea()
    {
        return Math.Pow(A, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    protected double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new ArgumentException("El lado A debe ser mayor a 0 // Side A must be greater than 0");
        }
        return a;
    }
}



public class Rectangle : Square
{
    // Fields
    private double _b;

    // Properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    // Constructors
    public Square(string name, double b)
    {
        Name = name;
        B = b;
    }

    public Square() { }

    // Methods
    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    protected double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("El lado B debe ser mayor a 0 // Side B must be greater than 0");
        }
        return b;
    }
}