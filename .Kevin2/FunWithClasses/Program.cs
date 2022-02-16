using DocumentFormat.OpenXml.Wordprocessing;
using NetTopologySuite.Geometries;
using Utilities;

public class Program
{
    public static void Main()
    {
        //Program.BooksAndLibraries();
        //List<string> names = new List<string> { "max", "ulli", "felix"};
        //HashSet<string> animals = new HashSet<string> { "tiger", "cat", "dog" };
        //SortedSet<string> subjects = new SortedSet<string> { "deutsch", "english", "maths" };
        //WriteCollections(new ICollection<string>[] {names, animals, subjects});

        //BooksAndLibraries();
        //List<IShape> shapes = new List<IShape>();
        //BetterCircle acircle = new BetterCircle();
        //acircle.SetRadius(10);
        //shapes.Add(acircle);
        //shapes.Add(new Triangle(5));
        //shapes.Add(new Rectangle() { Width = 10, Height = 5 });
        //GeoShapes(shapes);
        FunWithDelegates();

        //Queries();


    }
    public static void FunWithDelegates()

    {
        BookSampleFilterDelegate? filter = DoSomeFiltering;
        filter = filter + FilterByAudioBook;

        BookSample csharpBook = new BookSample(
        "C# mit VS 2019", 1480, "Programmierung",
        "978-3-8362-6458-7", BookMedium.Hardcover,
        new string[] { "Andreas Kühnel", "Max Muster" });

        BookSample csharpBook2 = new BookSample(
        "Einstieg in C# mit VS 2019", 555, "Programmierung",
        "978-3-8362-7044-1", BookMedium.Softcover,
        new string[] { "Ali Gel", "Max Muster" });

        bool? result = filter(csharpBook);
        BetterBookLibrary library = new();
        library.AddBook(csharpBook);
        library.AddBook(csharpBook2);
        BookSample? foundBook = library.FindBook(DoSomeFiltering);
        foundBook = library.FindBook(FilterByAudioBook);
        foundBook = library.FindBook(sample => sample.Field == "Programmierung");

        Func<string> lambda = () => "Hello";
        Console.WriteLine(lambda());

    }

    //public static void Queries()

    //{

        //var queryx = from lines

    //}

        public static bool FilterByAudioBook(BookSample sample)
    {
        return sample.Medium == BookMedium.AudioBook;
    }

    public static bool DoSomeFiltering(BookSample s)
    {
        return s.Field == "Programmierung";
    }
    public static void DoSomething(Person p)
    {
        p.Address.Street = "Ernst-Abbe-Str.";
        p = new Person("", DateTime.Now, "");
    }

    public static void WriteCollections(ICollection<string>[] collections)
    {
        foreach (ICollection<string> c in collections)
        {
            Console.WriteLine(c.Count);
            c.Add("Ein neues Element");
        }
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

    ////public static void AddressesAndPersons()
    //{
    //Person germanGuy = new Person(
    //"Rainer Zufall", new DateTime(2000, 05, 20), "Deutsch")
    //{
    //Gender = Gender.Male
    //};
    //germanGuy.Describe();
    //DoSomething(germanGuy);
    //germanGuy.Describe();

    ////germanGuy.Gender = Gender.Male;

    //Person turkishGirl = new Person(
    //"Ibrahim Tarkan", new DateTime(1990, 03, 25), "Türk");

    //germanGuy.Describe();
    //turkishGirl.Gender = Gender.Female;
    //turkishGirl.Describe();

    //Address a = new Address()
    //{
    //Street = "Ernst-Abbe-Str.",
    //Country = "Germany",
    //};

    //Address b = new Address("Villa Kunterbunt", "2b", "Berlin", "Deutschland");
    //Address c = new Address("Deutschland");

    //b.Describe(); // entspricht Describe(false)
    //b.Describe(true);
    //b.Describe(false);
    //}

    //public static void BooksAndLibraries()
    //{
    //BookSample csharpBook = new BookSample(
    //"C# mit VS 2019", 1480, "Programmierung",
    //"978-3-8362-6458-7", BookMedium.Hardcover,
    //new string[] { "Andreas Kühnel", "Max Muster" });

    //BookSample csharpBook2 = new BookSample(
    //"Einstieg in C# mit VS 2019", 555, "Programmierung",
    //"978-3-8362-7044-1", BookMedium.Softcover,
    //new string[] { "Ali Gel", "Max Muster" });

    ////csharpBook.Describe();
    //BookSample copy = csharpBook.Copy();
    ////copy.Describe();

    //BetterBookLibrary library = new();
    //library.AddBook(csharpBook);
    //library.AddBook(csharpBook2);
    ////library.AddBook(csharpBook.Copy());


    ////Console.WriteLine(library.Capacity);
    ////Console.WriteLine(library.NumberofCopies());
    ////Console.WriteLine(library.NumberofCopies());
    ////library.RemoveBook(Guid )

    //TitleFilter titleFilter = new TitleFilter("C# mit VS 2019");
    //library.FindBook(titleFilter)?.Describe();



    //FunWithClasses.AuthorFilter authorfilter = new("Andreas Kühnel");
    //foundbook = library.FindBook;




    //}

    public static void GeoShapes(ICollection<IShape> shapes)
    {
        foreach (IShape shape in shapes)
        {
            Console.WriteLine(
            $"N={shape.Name} A={shape.GetArea():N2}" +
            $"p={shape.GetPerimeter():N2}");
        }
    }
}
