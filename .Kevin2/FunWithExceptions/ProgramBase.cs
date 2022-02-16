//public class ProgramBase
//{
//   // public static void Main(Args[] )
//    {

//        try
//        {
//            File.ReadAllLines("abc.txt");

//            //Divide(0);

//            throw new Exception("hehe");
//        }
//        catch (DivideByZeroException e)
//        {

//            Console.WriteLine("Division by zero");
//        }
//        //catch (Exception e)
//        catch (NullReferenceException e)
//        {
//            //Console.WriteLine("Some Exception");
//            Console.WriteLine("NullRefExcept");
//        }

//        catch (FileNotFoundException e)
//        {
//            Console.WriteLine(
//            $"Datei nicht gefunden: { e.FileName}");
//        }

//        finally
//        {
//            Console.WriteLine("Finally in Main");
//        }
//    }
//}