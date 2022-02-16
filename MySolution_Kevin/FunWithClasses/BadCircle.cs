//BadCircle erbt von System.Object
//dies geschieht automatisch und muss nicht explizit angegeben werden.
public class BadCircle : System.Object

{
    public double Radius;
    //Konstruktor
    //Ein Default-Konstruktor wird nur dann automatisch generiert,
    //wenn kein expliziter Konstruktor in der Klasse definiert wird.

    //


    public BadCircle()
    {

    }

    //Instanzmethode (Objektkontext vorhanden)
    public void Describe()
    {
        //string description = 
            //"Radius = {0:0.00}, Circumference = {1:0.00}" + 
            //""
        Console.WriteLine("My Radius is {0}", this.Radius);
        Console.WriteLine("My Diameter is {0}", this.GetDiameter());
        Console.WriteLine("My Area is {0}", this.GetArea());
        Console.WriteLine("My Circumference is {0}", this.GetPerimeter());
        Console.WriteLine("My Radius is {0: 0.00}; My Diameter is {1: 0.00}; My Area is {2: 0.00}; My Circumference is {3: 0.00}",
            this.Radius, this.GetDiameter(), this.GetArea(), this.GetPerimeter());


    }

    public double GetArea()
    {
        // A = pi*r*r
        return this.Radius * this.Radius * Math.PI;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }

    public double GetDiameter()
    {
        return 2 * this.Radius;
    }


    //Klassenmethode (kein Objektkontext vorhanden)
    public static void PrintMetadata()
    {

        Console.WriteLine("This is a very bad circle.");
    }




}