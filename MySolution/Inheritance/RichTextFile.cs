public class RichTextFile : TextFile
{
    public string FontName { get;  private set; }

    public RichTextFile(string path, string fontName) : base(path)
    {
        this.FontName = fontName;
        this.Data.Add(0x10);
    }

    public override string Describe()
    {
        string description = base.Describe();
        return $"{description}\nFontName: {FontName} ";
    }
    public override void Remove()
    {
        Console.WriteLine("Remove von RichTextFile");
    }


}