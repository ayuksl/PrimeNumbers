public class Program
{
    public static void Main()
    {
        Console.WriteLine("Reference and Value Types");

        string s = "Hello";
        string t = s;
        Console.WriteLine(object.ReferenceEquals(t, s));
        int i = 2;
        int j = i;
        Guid guid = Guid.NewGuid();
        Guid guid2 = guid;// echte Kopie


        Guid result = SomeMethod(guid, guid2);

        //Guid? id = null;
        //int? wert = null;
        //if (wert.HasValue) ;
        //if (wert != null)
        //{

        //}
        Size mySize = new Size(100,300);
        Size otherSize = mySize;
        mySize.Set(10, 10);

        Console.WriteLine(  mySize.Width );//, mySize.Height

        Console.WriteLine(otherSize.Width);//, otherSize.Height

    }

    public static  Guid SomeMethod(Guid guid1, Guid guid2)
    {
        return guid1;
    }
}