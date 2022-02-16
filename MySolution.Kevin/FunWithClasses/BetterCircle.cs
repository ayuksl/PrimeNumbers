public class BetterCircle
{
    // Ein Instanzattribut für den Radius
    private double _Radius;

    // Ein Default-Konstruktor wird
    // nur dann automatisch generiert,
    // wenn kein expliziter Konstruktor in der Klasse
    // definiert wird.
    public BetterCircle()
    {

    }

    // Da _Radius private ist, hat anderer Code keinen
    // Zugriff auf dieses Attribut. Also benötigen wir
    // eine separate public Getter-Methode.
    public double GetRadius()
    {
        return this._Radius;
    }

    // Da _Radius private ist, benötigen wir eine separate
    // Setter-Methode, die den Radius ändern kann.
    public void SetRadius(double value)
    {
        if (value > 0)
        {
            this._Radius = value;
        }
        else
        {
            throw new ArgumentException(
                "Radius must be greater than zero.");
        }
    }


    // Instanzmethode (Objektkontext vorhanden)
    public void Describe()
    {
        string description = 
            "Radius = {0:0.00}, Circumference = {1:0.00}" +
            ", Area = {2:0.00}, Diameter = {3:0.00}";

        Console.WriteLine(description, 
            this._Radius, this.GetCircumference(), 
            this.GetArea(), this.GetDiameter());
    }

    public double GetArea()
    {
        // A = pi * r * r
        // Math.Pow(this.Radius, 2) * Math.PI
        return this._Radius * this._Radius * Math.PI;
    }

    public double GetCircumference()
    {
        // U = 2 * PI * r
        return 2 * Math.PI * this._Radius;
    }

    public double GetDiameter() => 2 * this._Radius;

    // Klassenmethode (_kein_ Objektkontext vorhanden)
    // Hier gibt es kein 'this'.
    public static void PrintMetadata()
    {
        Console.WriteLine(
            "This is a better implementation of a circle.");
    }



}