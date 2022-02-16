using System.Text;

public class BaseFile
{

    public string Path { get; private set; }
    public string Extension
    {
        get
        {
            int dotIndex = this.Path.LastIndexOf('.');
            return dotIndex < 0
                ? ""
                : Path.Substring(dotIndex);
        }
    }
    public int SizeInBytes => Data.Count;

    // Dieses Property ist für Unterklassen (subclass)
    // sichtbar, die die Klasse File als Vorfahre (ancestor)
    // besitzen.
    protected List<byte> Data { get; set; }

    public void Copy(string destinationPath)
    {
    }

    public void Rename(string newName)
    {
        Console.WriteLine("Rename von BaseFile");
    }

    public virtual void Remove()
    {
        Console.WriteLine("Remove von BaseFile");
    }

    public void Move(string newPath)
    {
        this.Copy(newPath);
        // Achtung: der Aufruf von Remove ist polymorph!!!
        this.Remove();
    }

    // virtual bedeutet, dass die Methode
    // in einer Unterklasse (Nachfahre) überschrieben
    // werden kann.
    public virtual string Describe()
    {
        StringBuilder builder = new StringBuilder();
        builder
            .AppendLine($"Path: {this.Path}")
            .AppendLine($"Size: {this.SizeInBytes} Bytes")
            .Append($"Extension: {this.Extension}");

        return builder.ToString();
    }

    // Constructor
    public BaseFile(string path)
    {
        this.Path = path;
        this.Data = new List<byte>();
    }


}
