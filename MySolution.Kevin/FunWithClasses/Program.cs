using Utilities;

public class Program
{
    public static void Main()
    {
        Person germanGuy = new Person(
            "Rainer Zufall", new DateTime(2000, 05, 20), "Deutsch")
        {
            Gender = Gender.Male
        };
        germanGuy.Describe();
        DoSomething(germanGuy);
        germanGuy.Describe();

        //germanGuy.Gender = Gender.Male;

        Person turkishGirl = new Person(
            "Ibrahim Tarkan", new DateTime(1990, 03, 25), "Türk");

        germanGuy.Describe();
        turkishGirl.Gender = Gender.Female;
        turkishGirl.Describe();

        Address a = new Address() 
        { 
            Street = "Ernst-Abbe-Str.",
            Country = "Germany",
        };

        Address b = new Address("Villa Kunterbunt", "2b", "Berlin", "Deutschland");
        Address c = new Address("Deutschland");

        b.Describe(); // entspricht Describe(false)
        b.Describe(true);
        b.Describe(false);

    }

    public static void DoSomething(Person p)
    {
        p.Address.Street = "Ernst-Abbe-Str.";
        p = new Person("", DateTime.Now, "");
    }


        public static void OldMain()
    {
        BadCircle? circle = null;
        circle = new BadCircle();
        BadCircle otherCircle = new BadCircle();
        // thirdCircle und otherCircle zeigen auf
        // dasselbe Objekt im Heap.
        BadCircle thirdCircle = otherCircle;

        // Ergibt True, da otherCircle und thirdCircle
        // auf dasselbe Objekt verweisen
        Console.WriteLine(otherCircle.Equals(thirdCircle));
        // Überprüfen der Objektreferenzen mit statischer
        // ReferenceEquals-Methode von Klasse System.Object.
        Console.WriteLine(Object.ReferenceEquals(otherCircle, thirdCircle));

        BadCircle.PrintMetadata();
        // Folgende Zeile führt zu einem Fehler,
        // da PrintMetadata eine Klassenmethode (statisch) ist.
        //thirdCircle.PrintMetadata(); 

        circle.Radius = 10;
        otherCircle.Radius = 5.25;
        //thirdCircle.Radius = 7; //Achtung: Hiermit würde 5.25 überschrieben werden.

        circle.Describe();
        otherCircle.Describe();
        thirdCircle.Describe();

        Console.WriteLine(circle.ToString());

        BadCircle newCircle = new BadCircle();
        newCircle.Describe();
        newCircle.Radius = -50; // Ooops! Negativer Radius?
        newCircle.Describe();

        BetterCircle betterCircle = new BetterCircle();
        betterCircle.SetRadius(10);
        betterCircle.Describe();
        betterCircle.SetRadius(1);
        Console.WriteLine(betterCircle.GetRadius());

        Rectangle? r = null;
        r = new Rectangle();
        r.Width = 10;
        r.Height = 10;
        r.Describe();

        Triangle t = new Triangle(10, 20, 15);
        t.Describe();
        t.SetLengths(10, 20, 12);
        t.Describe();

        t = Triangle.CreateRightAngled(10, 20);
        Console.WriteLine(t.IsRightAngled());
        t.Describe();

        // Objektreferenz.Instanzmethode(argumente)
        // Klassenname.Klassenmethode(argumente)
    }
}