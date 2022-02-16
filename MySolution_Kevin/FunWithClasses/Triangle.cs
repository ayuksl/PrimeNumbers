
public class Triangle
{
    private double LengthA;
    private double LengthB;
    private double LengthC;

    public Triangle(double a, double b, double c)
    {
        SetLengths(a, b, c);
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
            $"Area={GetArea()}, Perimeter={GetPerimeter()}, The triangle is right angled = {IsRightAngled()}");
    }
    public bool IsRightAngled()
    {
        double[]  Arr = new double[]
        {
            LengthA, LengthB, LengthC,
        };

        Array.Sort(Arr);

        if (Math.Pow(Arr[2], 2) == Math.Pow(Arr[1], 2) + Math.Pow(Arr[0], 2))
        {
            return true;
        }
        return false;
    }

    private bool IsValid(double a, double b, double c)
    {
        return (a + b > c)
            && (b + c > a)
            && (a + c > b);
    }

}