// BadCircle erbt von System.Object
// Dies geschieht automatisch und muss nicht
// explizit angegeben werden.
using System.Globalization;

public class BadCircle
{
    // Ein Instanzattribut für den Radius
    public double Radius;

    // Ein Default-Konstruktor wird
    // nur dann automatisch generiert,
    // wenn kein expliziter Konstruktor in der Klasse
    // definiert wird.
    public BadCircle()
    {

    }

    // Instanzmethode (Objektkontext vorhanden)
    public void Describe()
    {
        string description = 
            "Radius = {0:0.00}, Perimeter = {1:0.00}" +
            ", Area = {2:0.00}, Diameter = {3:0.00}";

        Console.WriteLine(description, 
            this.Radius, this.GetPerimeter(), 
            this.GetArea(), this.GetDiameter());
    }

    public double GetArea()
    {
        // A = pi * r * r
        // Math.Pow(this.Radius, 2) * Math.PI
        return this.Radius * this.Radius * Math.PI;
    }

    public double GetPerimeter()
    {
        // U = 2 * PI * r
        return 2 * Math.PI * this.Radius;
    }

    public double GetDiameter() => 2 * this.Radius;

    // Klassenmethode (_kein_ Objektkontext vorhanden)
    public static void PrintMetadata()
    {
        Console.WriteLine(
            "This is a very bad implementation of a circle.");
    }



}