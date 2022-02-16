public class BadBookLibrary
{
    // Das ? sagt dem Compiler, dass einige Elemente im Array
    // auch null sein können.
    private BookSample?[] bookCopies;
    //private int total;

    public int Capacity
    {
        get => bookCopies.Length;
    }

    public void AddBook(BookSample bookCopy)
    {
        // Enthält die Library bereits das Buchexemplar,
        // dann fügen wir es nicht erneut hinzu.
        if (FindBook(bookCopy.Id) is not null)
        {
            return;
        }

        for (int i = 0; i < bookCopies.Length; i++)
        {
            if (bookCopies[i] is null)
            {
                bookCopies[i] = bookCopy;
                return;
            }
        }

        // Wenn wir hier her gelangen, dann wurde kein
        // freier Platz im Array gefunden
        throw new Exception("No more capacity to store book");
    }

    public void RemoveBook(Guid id)
    {
        for (int i = 0; i < bookCopies.Length; ++i)
        {
            if (bookCopies[i]?.Id == id)
            {
                bookCopies[i] = null;
            }
        }
    }

    public BookSample? FindBook(Guid bookId)
    {
        foreach (BookSample? copy in this.bookCopies)
        {
            if (copy is null)
            {
                continue;
            }
            if (copy.Id == bookId)
            {
                return copy;
            }
        }

        return null;
    }

    public BookSample? FindBook(string title)
    {
        foreach (BookSample? copy in this.bookCopies)
        {
            if (copy is null)
            {
                continue;
            }
            if (copy.Title.Equals(
                title, StringComparison.OrdinalIgnoreCase))
            {
                return copy;
            }
        }

        return null;
    }

    public BadBookLibrary(int capacity)
    {
        bookCopies = new BookSample[capacity];
    }
    
    public int NumberofCopies()
    {
        int count = 0;
        foreach (BookSample? copy in this.bookCopies)
        {
            if (copy is not null)
            {

                count++;
            }
        }

        return count;
    }


}