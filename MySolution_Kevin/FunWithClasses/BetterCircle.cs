//BadCircle erbt von System.Object
//dies geschieht automatisch und muss nicht explizit angegeben werden.
public class BetterCircle : System.Object

{
    private double _Radius;
    //Konstruktor
    //Ein Default-Konstruktor wird nur dann automatisch generiert,
    //wenn kein expliziter Konstruktor in der Klasse definiert wird.

    //


    public BetterCircle()
    {

    }

    public double GetRadius()
    {
        return this._Radius;

    }
    public void SetRadius(double value)
    {
        if (value > 0)
        {
            this._Radius = value;

        }
        else
        {
            throw new ArgumentException("Radius must be greater than zero.");
        }
    }

    //Instanzmethode (Objektkontext vorhanden)
    public void Describe()
    {
        Console.WriteLine("My Radius is {0}", this._Radius);
        Console.WriteLine("My Diameter is {0}", this.GetDiameter());
        Console.WriteLine("My Area is {0}", this.GetArea());
        Console.WriteLine("My Circumference is {0}", this.GetPerimeter());
        Console.WriteLine("My Radius is {0: 0.00}; My Diameter is {1: 0.00}; My Area is {2: 0.00}; My Circumference is {3: 0.00}",
            this._Radius, this.GetDiameter(), this.GetArea(), this.GetPerimeter());


    }

    public double GetArea()
    {
        // A = pi*r*r
        return this._Radius * this._Radius * Math.PI;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * this._Radius;
    }

    public double GetDiameter()
    {
        return 2 * this._Radius;
    }


    //Klassenmethode (kein Objektkontext vorhanden)
    public static void PrintMetadata()
    {

        Console.WriteLine("This is a better implementation of a circle.");
    }




}