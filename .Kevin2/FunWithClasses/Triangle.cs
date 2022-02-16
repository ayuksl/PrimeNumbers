using FunWithClasses;

public class Triangle : IShape
{
    // Fields / Instanzattribut
    private double LengthA;
    private double LengthB;
    private double LengthC;

    public string Name  { get => "Triangle";  }    

    
    //public Triangle (string name)
    //{
        //this.Name = name;
    //}

    public Triangle(double length)
    {
        SetLengths(length, length, length);
    }

    public Triangle(double a, double b, double c)
    {
        SetLengths(a, b, c);
    }

    // Diese Methode ist eine Überladung (Overload) der
    // Methode SetLengths.
    public void SetLengths(double length)
    {
        SetLengths(length, length, length);
    }

    public void SetLengths(double a, double b, double c)
    {
        if (!IsValid(a, b, c))
        {
            throw new ArgumentException("Invalid triangle");
        }

        LengthA = a;
        LengthB = b;
        LengthC = c;
    }

    public double GetPerimeter() => LengthA + LengthB + LengthC;

    public double GetArea()
    {
        double s = 0.5 * GetPerimeter();
        double area = Math.Sqrt(
            s * (s - LengthA) * (s - LengthB) * (s - LengthC));

        return area;
    }

    public void Describe()
    {
        Console.WriteLine(
            $"A={LengthA}, B={LengthB}, C={LengthC}, " + 
            $"Area={GetArea()}, Perimeter={GetPerimeter()}");
    }

    private static bool IsValid(double a, double b, double c)
    {
        return (a + b > c)
            && (b + c > a)
            && (a + c > b);
    }

    public bool IsRightAngled()
    {
        double[] sides = new double[] 
        {
            this.LengthA, this.LengthB, this.LengthC
        };
        
        Array.Sort(sides);

        // if (Math.Po...) { return true; } else { return false; }

        double left = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        double right = Math.Pow(sides[2], 2);

        // Aufgrund von Rundungsfehlern kann ein direkter
        // Wertevergleich zu einem falschen Ergebnis führen.
        // Wir betrachten zwei Werte a und b als gleich, wenn sie
        // sich um weniger als 
        return Math.Abs(left - right) < (1 / Math.Pow(10, -6));
    }

    public static Triangle CreateRightAngled(double a, double b)
    {
        double c = Math.Sqrt(a * a + b * b);
        return new Triangle(a, b, c);
    }

}