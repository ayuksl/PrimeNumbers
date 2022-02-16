public struct Size
{
    public int Width { get; private set; }
    public int Height { get; private set; }


    //public Size()
    //{
    //    this.Width = 0;
    //    this.Height = 0;
    //}

    public Size(int width, int height)
    {
        this.Width = this.Height = 0;
        this.Set(width, height);
    }
    public void Set(int width, int height)
    {
        this.Width = Math.Abs(width);
        this.Height = Math.Abs(height);
    }
}