//Filter bekommt ien Buchexemplar übergweben
//und gibt als ergebnis True zurück, wenn das Buch auf den Filter Zutrifft ansonsten False

//public bool FilterById(BookSample sample, Guid id)
//{
//    return sample.Id == id;
//}

public delegate bool BookSampleFilterDelegate(BookSample sample);






//public bool FilterByTitle(BookSample sample, string title)
//{
//    return sample.Title.Equals(title, StringComparison.CurrentCultureIgnoreCase);
//}
//public bool FilterByAuthor(BookSample sample,)