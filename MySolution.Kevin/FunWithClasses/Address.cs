public class Address
{
    private const string Unknown = "unbekannt";

    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public Address(string name, string number, string city, string country)
    {
        this.Street = name;
        this.StreetNumber = number;
        this.City = city;
        this.Country = country;
    }

    public Address(string country) 
        : this(Unknown, Unknown, Unknown, country)
    {
    }

    // Dieser Konstruktor ruft den obigen Konstruktor mit 4 Parametern auf
    // (Constructor Delegation)
    public Address() 
        : this(Unknown, Unknown, Unknown, Unknown)
    {
    }

    // Für den Parameter writeToConsole wurde ein Default-Wert
    // festgelegt, d.h. dass dieser Parameter optional ist!!
    public string Describe(bool writeToConsole = false)
    {
        string format = 
            "Straße = {0}\nNummer= {1}\nStadt = {2}\nLand = {3}";

        string description = string.Format(format,
            this.Street, this.StreetNumber,
            this.City, this.Country);

        if (writeToConsole == true)
        {
            Console.WriteLine(description);
        }

        return description;
    }
}