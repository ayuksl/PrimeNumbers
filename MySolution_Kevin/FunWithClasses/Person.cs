using FunWithClasses;

public class Person
{
    private string _Name;
    //Ein Property namens Name
    public string Name
    {
        private set
        {
            _Name = value; //.ToUpper(); 
        }
        get
        {
            return _Name;
        }
    }

    public DateTime BirthDate
    {
        get;

    }
    public string Nationality
    {
        get;
    }
    public int BirthYear
    {
        get => BirthDate.Year;
    }

    
    public Gender Gender { get; set; }

    public Address Address { get; set; }


    // constructor.......................................
    public Person(string name, DateTime birth, string nationality, Gender gender, Address address)
    {
        this.Gender = gender;
        this._Name = name;
        this.BirthDate = birth;
        this.Nationality = nationality;
        this.Address = address;
    }

    public Person()
    {
        this.Gender = Gender.Diverse;
        this._Name = "Hans Häufig";
        this.BirthDate = DateTime.Today;
        this.Nationality = "Deutschland";
        this.Address = new Address();
        
    }

    public void Describe()
    {
        Console.WriteLine("My name is {0}; My birthdate is {1}; My nationality is {2} and My birthyear is {3}, {4} ",
            this._Name, this.BirthDate, this.Nationality, this.BirthYear, this.Address );
        this.Address.Describe();
        //Console.WriteLine(this.Address);

    }
    //public void AddrDescribe()
    //{
        //Console.WriteLine( "My street is {0}; My housenumber is {1}; My city is {2} and My country is {3}",
    //this.Address.Straße, this.Address.Hausnummer, this.Address.Wohnort, this.Address.Land);
    //}


}