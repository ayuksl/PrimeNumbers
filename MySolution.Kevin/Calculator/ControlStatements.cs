public class ControlStatements
{

    public static void Main(string[] args)
    {
        ForTest();
    }

    public static string DigitToWord(int digit)
    {
        if (digit == 1)
        {
            //return "eins";
        }
        else if (digit == 2)
        {
            return "zwei";
        }
        else if (digit == 3)
        {
            return "drei";
        }
        else
        {
            return "unbekannt";
        }

        int errorCode = 3;
        switch (errorCode)
        {
            case 1:
            case 3:
                Console.WriteLine("Fehler ist 1 oder 3");
                break;
            default:
                Console.WriteLine("Unbekannter Fehler");
                break;
        }

        return "";

        // Anweisungen

        //if (digit == 1)
        //{
        //    return "eins";
        //}
        //else
        //{
        //    if (digit == 2)
        //    {
        //        return "zwei";
        //    }
        //    else
        //    {
        //        if (digit == 3)
        //        {
        //            return "drei";
        //        }
        //        else
        //        {
        //            if (digit == 4)
         //           {
         //               return "vier";
         //           }
        //            else
        //            {
        //                return "unbekannt";
        //            }
        //        }
        //    }
        //}
    }

    public static void ForTest()
    {
        int i = 0;
        
        for (; ;)
        {
            if (i == 4)
            {
                break;
            }

            i++;
        }
        // Anweisung
        i *= 2;

    }
}