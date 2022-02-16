public class Person
{
    // privates Instanzattribut (Feld / Field)
    private string? _Name;

    // Ein Property namens Name mit einem
    // privaten Setter und einem public Getter
    public string Name
    {
        private set
        {
            _Name = value;
        }
        get
        {
            return _Name ?? "";
        }
    }

    // Dieses Property kann nur im Constructor
    // einmalig initialisiert werden. Eine nachträgliche
    // Modifikation ist nicht mehr möglich.
    // (Weder außerhalb noch innerhalb der Klasse)
    public DateTime Birthdate  
    {
        get;
    }

    public int BirthYear
    {
        // Kurzform ist: get => Birthdate.Year;
        get
        {
            return Birthdate.Year;
        }
    }

    public string Nationality { get; }

    public Gender Gender { get; set; }

    public Address Address { get; }

    public void Describe()
    {
        string format = "Name = {0}\nGeburtsdatum = {1:d}\n" +
            "Staatsangehörigkeit = {2}\nGeschlecht = {3}";

        Console.WriteLine(format, this.Name, this.Birthdate,
            this.Nationality, this.Gender);

        this.Address.Describe(writeToConsole: true);
    }

    public Person(string name, DateTime birthday, string nationality)
        : this(name, birthday, nationality, new Address())
    {
    }

    public Person(string name, DateTime birthdate, string nationality, Address address)
    {
        this.Gender = Gender.Diverse;
        this.Name = name;
        this.Birthdate = birthdate;
        this.Nationality = nationality;
        this.Address = address;
    }
}