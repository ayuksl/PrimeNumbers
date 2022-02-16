using FunWithClasses;



public class Program
{
    public static void Main()
    {
        Address myAddress = new Address("Villa Kunterbunt", "123a", "Berlin", "Deutschland");

        Person p = new Person("Rainer Zufall", DateTime.Today, nationality: "German", Gender.Male, myAddress);
        Console.WriteLine(p.Name);
        //p.Name = "Claire Grube";
        Console.WriteLine(p.Name);
        Console.WriteLine(p.BirthDate);
        p.Describe();
        Person  germanGuy = new Person();
        Person d = new Person();
        d.Address = myAddress;
        d.Describe();
        
        Address a = new Address()
        {
            Straße = "aaa",
            Land = "Deutschland",
            Hausnummer = "255"

        };
        germanGuy.Address.Straße  = "ali gel";
        germanGuy.Describe();


        

        Buchexemplar book = new Buchexemplar(
             "C#",  { "ali", "veli", "49", "50", "1" }, 1480,);






        Buchexemplar copybuch = new Copy(book);


        Console.WriteLine(copybuch.Titel);
        Console.WriteLine(copybuch.Seitenanzahl);






    }
    public static void OldMain()
    {
        BadCircle? circle = null;
        circle = new BadCircle();
        BadCircle otherCircle = new BadCircle();
        //thirdCircle und otherCircle zeigen auf
        //dasselbe Objekt in HEAP.
        BadCircle thirdCircle = otherCircle;
        //ergibt true, da 
        //int? zahl = null;
        //string? name = null;
        
        Console.WriteLine(circle.Equals(thirdCircle));
        //Überprüfen
        Console.WriteLine(Object.Equals(otherCircle, thirdCircle));

        BadCircle.PrintMetadata();
        //thirdCircle.PrintDetails();

        circle.Radius = 10;
        otherCircle.Radius = 5.25;
        thirdCircle.Radius = 7; //Fehler/Achtung: Hiermit würde überschrieben ayni kayit bölgesini isaret ettigi icin.
        circle.Describe();
        otherCircle.Describe();
        thirdCircle.Describe();
        Console.WriteLine(circle.ToString());

        BadCircle newcircle = new BadCircle();
        newcircle.Describe();
        newcircle.Radius = -50; //Ne negatif yaricap mi?
        newcircle.Describe();

        BetterCircle betterCircle = new BetterCircle();
        betterCircle.SetRadius(10);
        betterCircle.Describe();
        Console.WriteLine(betterCircle.GetRadius());
        Rectangle rectangle = new Rectangle();
        rectangle.SetHeight(20);
        rectangle.SetWidth(10);
        rectangle.Describe(   );
        Triangle t = new Triangle(3, 4, 5);
        t.Describe();



    }


}