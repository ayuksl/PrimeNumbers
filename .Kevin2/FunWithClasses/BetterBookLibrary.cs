public class BetterBookLibrary
{
    // Das ? sagt dem Compiler, dass einige Elemente im Array
    // auch null sein können.
    //using list  
    //  

    private readonly List<BookSample> bookCollection;

    //private int total;

    public void AddBook(BookSample bookCopy)
    {
        // Enthält die Library bereits das Buchexemplar,
        // dann fügen wir es nicht erneut hinzu.
        if (FindBook(bookCopy.Id) is not null)
        {
            return;
        }

        bookCollection.Add(bookCopy);
    }

    public void RemoveBook(Guid id)
    {
        //BookCopy? bookToDelete = null;

        //foreach (BookCopy b in bookCollection)
        //{
            //if (b.Id == id)
            //{
                //bookToDelete = b;
                //break;
            //}
        //}

        //if (bookToDelete is not null)
        //{
            //bookCollection.Remove(bookToDelete);
        //}


    


        BookSample? bookToDelete = FindBook(id);
        if (bookToDelete is not null)
        {
            bookCollection.Remove(bookToDelete);
        }

    }

    public BookSample? FindBook(BookSampleFilterDelegate filter)
    {
        foreach (BookSample sample in bookCollection)
        {
            if (filter(sample) == true)
            {
                return sample;
            }
        }
        return null;
    }
    public BookSample? FindBook(IBookSampleFilter filter)
    {
        foreach (BookSample sample in bookCollection)
        {
            if (filter.Matches(sample) )
            {
                return sample;
            }
        }
        return null;
    }

    public void PrintBooks()
    {
        foreach(BookSample sample in bookCollection)
        {
            Console.WriteLine();
        }
    }
    public BookSample? FindBook(Guid id)
    {
        foreach (BookSample? bookCopy in this.bookCollection)
        {
            if (bookCopy is null)
            {
                continue;
            }
            if (bookCopy.Id == id)
            {
                return bookCopy;
            }
        }

        return null;
    }
    public BookSample? FindBook(string title)
    {
        foreach (BookSample? bookCopy in this.bookCollection)
        {
            if (bookCopy is null)
            {
                continue;
            }
            if (bookCopy.Title.Equals(
                title, StringComparison.OrdinalIgnoreCase))
            {
                return bookCopy;
            }
        }

        return null;
    }
    public int NumberofCopies()
    {
        return bookCollection.Count;
    }
    //Constructor.......
    public BetterBookLibrary()
    {
        this.bookCollection = new List<BookSample>();
    }

}