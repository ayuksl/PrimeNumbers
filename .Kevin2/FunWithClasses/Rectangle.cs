public class Rectangle : IShape
{
    public string Name => "Rectangle";
    

    public double Width;
    public double Height;

    //public string Name => throw new NotImplementedException();

    public double GetArea() => Width * Height;

    public double GetPerimeter()
    {
        return 2 * (this.Width + this.Height);
    }

    public bool IsSquare() => Width.Equals(Height);

    public void Describe()
    {
        Console.WriteLine(
            "Width={0}, Height={1}, Area={2:F2}, " + 
            "Perimeter={3:F2}, IsSquare={4}",
            this.Width, this.Height, 
            this.GetArea(), this.GetPerimeter(),
            this.IsSquare());
    }

}