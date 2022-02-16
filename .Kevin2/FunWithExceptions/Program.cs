public class Program
{

    public static void Main(string[] args)
    {
        Uebung35(args);


    }

    public static void Uebung35(string[] args)
    {

        if (args.Length < 1)
        {
            Console.WriteLine("Argument für den Dateipfad fehlt!");
            return;
        }
        //IEnumerable<string> lines = null;

        if (TryReadLines(args[0], out IEnumerable<string> lines))
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
        

    private static bool TryReadLines(string path, out IEnumerable<string> lines )
    {
        lines = new List<string>();

        try
        {
            lines =  File.ReadAllLines(path);
            return true;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Die Datei {path} konnte nicht gefunden werden.");
            Console.WriteLine("Stellen Sie sicher dass die Datei existiert.");
            return false;
        }
        //    //Divide(0);
            
        //    //throw new Exception("hehe");
        //}
        ////catch (Exception e)
        catch (UnauthorizedAccessException e)
        {
            //Console.WriteLine("Some Exception");
            Console.WriteLine($"Zugriff auf Datei {path} nicht möglich.");
            Console.WriteLine($"Details: {e.Message}");
            return false;
        }

        //catch (FileNotFoundException e)
        //{ 
        //    Console.WriteLine(
        //    $"Datei nicht gefunden: { e.FileName}");
        //}

        catch (Exception)
        {

            Console.WriteLine("Ein unerwarteter Fehler ist aufgetreten. ");
            throw;
        }
        finally
        {
            Console.WriteLine("Finally in Main");
        }
    }
    //public static void OldmainMain()
    //{
    //    try
    //    {
    //        IThrowSomeExceptions();
    //        Console.WriteLine("Hello");
    //        throw new Exception("bla bla ");
    //        MethodWhichCallsAnotherMethod();

    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine($"Exception: {e.Message}");
    //        Console.WriteLine("Program will exit");
    //        return;
    //    }
    //    finally
    //    {
    //        Console.WriteLine("finally in Main");
    //    }
    //    Console.WriteLine("Programmende");
    //}
    //public static void IThrowSomeExceptions()
    //{

    //    try
    //    {
    //        Console.WriteLine("Iwill throw an exception now");
    //        Exception e = new Exception("This is a message");
    //        throw e;

    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine( $"I catched the exception: {e.Message}");

            
    //        throw;
    //    }
    //    finally
    //    {
    //        Console.WriteLine("finally block executed");

    //    }
    //    Console.WriteLine("Exception thrown");
    //}
    //public static void AllTheOtherExeptions()
    //{
    //    Console.WriteLine("All The other exceptions");
    //}

    //public static void MethodWhichCallsAnotherMethod()
    //{
    //    Console.WriteLine("Before call");
    //    IThrowSomeExceptions();
    //    Console.WriteLine("After call");

    //}

    //public static void Divide(int n)
    //{
    //    if (n == 0)
    //    {
    //        throw new DivideByZeroException();
    //    }
    //    else
    //    {
    //        throw new Exception();
    //    }
    //}

}