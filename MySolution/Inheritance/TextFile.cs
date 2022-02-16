// A : B bedeutet, dass A eine Unterklasse von B
// ist.

public class TextFile : BaseFile
{
    public int LineCount { get; private set; }

    // Bevor der Constructor von TextFile
    // ausgeführt werden kann, muss ein
    // Constructor der Basisklasse (Oberklasse)
    // ausgeführt werden.
    // Allgemein: Die Konstruktoren der Vorfahren
    // werden vor dem eigenen Konstruktor aufgerufen.
    public TextFile(string path) : base(path)
    {
        LineCount = 0;
        this.Data.Add(0xff);
    }

    public override string Describe()
    {
        string description = base.Describe();
        return $"{description}\nLineCount: {this.LineCount}";
    }

    public override void Remove()
    {
        Console.WriteLine("Remove von TextFile");
    }

    // Remove wird nicht überschrieben sondern lediglich
    // neu definiert.
    // Achtung: Dieses Remove überdeckt die Remove Methode der
    // Basisklasse. TextFile hat jetzt also zwei Remove Methoden.
    // Einmal die vererbte von BaseFile und dann die eigene.
    //public new void Remove()
    //{
    //    Console.Write("Remove von TextFile");
    //}
    //public new virtual void Rename(string newName)
    //{
    //    Console.WriteLine("Rename von TextFile");
    //}

}