namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{
    //Fields
    private string _name = null!;

    // Properties
    public string Name { 
        get => _name;
        set => _name = value;
    }

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
    public Rectangle(string name, double a, double b)
    {
        Name = name;
        A = a;
        B = b;
    }

    public Rectangle() { }

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




public class Rhombus : Square
{
    // Fields
    private double _d1;
    private double _d2;

    // Properties
    public double D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }

    public double D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }


    // Constructors
    public Rhombus(string name, double a, double d1, double d2)
    {
        Name = name;
        A = a;
        D1 = d1;
        D2 = d2;
    }

    public Rhombus() { }

    // Methods
    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 4 * A ;
    }

    private double ValidateD1(double d1)
    {
        if (d1 <= 0)
        {
            throw new ArgumentException("El lado D1 debe ser mayor a 0 // Side D1 must be greater than 0");
        }
        return d1;
    }

    private double ValidateD2(double d2)
    {
        if (d2 <= 0)
        {
            throw new ArgumentException("El lado D2 debe ser mayor a 0 // Side D2 must be greater than 0");
        }
        return d2;
    }
}



public class Kite : Rhombus
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
    public Kite(string name, double a, double b, double d1, double d2 )
    {
        Name = name;
        A = a;
        B = b;
        D1 = d1;
        D2 = d2;
    }

    public Kite() { }

    // Methods
    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("El lado B debe ser mayor a 0 // Side B must be greater than 0");
        }
        return b;
    }
}


public class Parallelogram : Rectangle
{
    // Fields
    private double _h;

    // Properties
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Constructors
    public Parallelogram(string name, double a, double b, double h )
    {
        Name = name;
        A = a;
        B = b;
        H = h;
    }

    public Parallelogram() { }

    // Methods
    public override double GetArea()
    {
        return B * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("El lado H debe ser mayor a 0 // Side H must be greater than 0");
        }
        return h;
    }
}



public class Trapeze : Triangle
{
    // Fields
    private double _d;

    // Properties
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    // Constructors
    public Trapeze(string name, double a, double b, double c, double d, double h )
    {
        Name = name;
        A = a;
        B = b;
        C = c;
        D = d;
        H = h;
    }

    public Trapeze() { }

    // Methods
    public override double GetArea()
    {
        return ((B + D) * H ) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }

    private double ValidateD(double d)
    {
        if (d <= 0)
        {
            throw new ArgumentException("El lado D debe ser mayor a 0 // Side D must be greater than 0");
        }
        return d;
    }

}
