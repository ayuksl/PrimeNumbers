public class RasterImageFile : BaseFile
{
    
    public int PixelWidth { get; private set; }
    public int PixelHeight { get; private set;  }
    public ColorOptions Colorspace { get; private set; }
    public bool IsLossless { get; private set; }


    public RasterImageFile(string path, int pixelWidth, int pixelHeight, ColorOptions colorOptions) : base(path)
    {
        PixelWidth = pixelWidth;
        PixelHeight = pixelHeight;
        Colorspace = colorOptions;
        IsLossless = false;
    }
    public override string Describe()
    {
        string description = base.Describe();
        return $"{description}\nColorspace: {this.Colorspace} ";
    }




    //public RichTextFile(string path, string fontName) : base(path)
    //{
    //this.FontName = fontName;
    //this.Data.Add(0x10);
    //}

    //public override string Describe()
    //{
    //string description = base.Describe();
    //return $"{description}\nFontName: {FontName} ";
    //}
    //public override void Remove()
    //{
    //Console.WriteLine("Remove von RichTextFile");
    //}


    //}
}