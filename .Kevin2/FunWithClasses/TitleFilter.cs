//diese klasse implementiert die schnitstelle
//IBookSampleFilter d.h. sie implementiert
//eine methgode namens matches.
public class TitleFilter : IBookSampleFilter
{
    public string Title { get; set; }
    public TitleFilter(string title)
    {
        this.Title = title;
    }
    public bool Matches(BookSample sample)
    {
        return sample.Title.Equals(
            Title, StringComparison.OrdinalIgnoreCase);
    }
}
