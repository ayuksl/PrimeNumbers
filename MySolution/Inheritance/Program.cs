public class Program
{
    public static void Main()
    {
        RichTextFile richFile = new RichTextFile("abc.txt", "Consolas");
        BaseFile baseFile = new BaseFile("uvw.txt");
        TextFile textFile = new TextFile("xyz.txt");

        //textFile.Move("blabla");

        List<BaseFile> files = new List<BaseFile>();
        files.Add(baseFile);
        files.Add(textFile);
        files.Add(richFile);
        PrintFiles(files);
    }

    public static void PrintFiles(IEnumerable<BaseFile> files)
    {
        // BaseFile ist hier der Kompilierzeit-Datentyp des Elementes
        // Der Laufzeit-Datentyp des Elementes kann aber eine beliebige
        // Unterklasse von BaseFile sein.
        foreach (BaseFile file in files)
        {
            // Es wird jeweils die Describe Methode aufgerufen,
            // die zum Datentyp gehört, der tatsächlich zur Laufzeit
            // von file referenziert wird (Polymorphie)
            Console.WriteLine(file.Describe());
            Console.WriteLine();
        }
    }
}