public class BookSample
{
    public Guid Id { get; }
    public string Title { get; }
    public int PageCount { get; }
    public string Field { get; }
    public string Isbn { get; }
    public BookMedium Medium { get; }
    public string[] Authors { get; }

    public BookSample Copy()
    {
        BookSample copy = new BookSample(
            this.Title, this.PageCount, this.Field,
            this.Isbn, this.Medium, this.Authors);

        return copy;
    }

    public void Describe()
    {
        string format =
            "Id={6} Titel={0} Seitenzahl={1} Sachgebiet={2}\n" +
            "ISBN={3} Medium={4} Authoren={5}";

        Console.WriteLine(format, this.Title, 
            this.PageCount, this.Field, this.Isbn, this.Medium,
            string.Join(", ", this.Authors), this.Id);
        

    }

    public BookSample(string title, int pageCount, string field, string isbn, BookMedium medium, string[] authors)
    {
        this.Id = Guid.NewGuid();
        this.Title = title;
        this.Field = field;
        this.Medium = medium;
        this.PageCount = pageCount;
        this.Title = title;
        this.Isbn = isbn;
        // Wir erzeugen eine Kopie der Authoren
        this.Authors = authors.ToArray();
    }
}