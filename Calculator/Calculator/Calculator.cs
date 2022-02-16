public class Calculator
{
    public static void Main(string[] arguments)
    {
        //if (arguments.Length != 2)
        //{
        //string message = $"Fehler: Zwei Argument erwartet, +" +
        //$"aber {arguments.Length} Argumente erhalten.";
        //Console.WriteLine(message);
        //return;
        //}

        //Wir gelengen nur an diese Stelle, wenn
        //die  argumentenzahl 2 beträgt.

        //Console.WriteLine("Ich berechne...");
        //int firstNumber = int.Parse(arguments[0]);
        //int secondNumber = int.Parse(arguments[1]);
        //string firstNumber = Console.ReadLine();
        //Console.WriteLine("Gib zweite zahl ein");
        //string secondNumber = Console.ReadLine();
        //Console.WriteLine("Gib eine zahl ein");



        //Console.WriteLine("Summe von {0} und {1} ist {2}", 
        //firstNumber, secondNumber, 
        //(int.Parse(firstNumber) + int.Parse(secondNumber)));
        //// string aAsWord = DigitAsWord(firstNumber);


        //Uebung03();


        Console.WriteLine("Gib eine zahl ein");
        string firstNumber = Console.ReadLine();
        //string s = firstNumber;
        //string[] subs = s.Split(" ");
        //Console.WriteLine("Summe von {0} und {1} ist {2}", 
        //    int.Parse(subs[0]), int.Parse(subs[1]), 
        //    (int.Parse(subs[0]) + int.Parse(subs[1])) );


        //if subs.Length != 0
        //{
        //Console.WriteLine("Summe von {0} und {1} ist {2}",
        //firstNumber, secondNumber,
        //(int.Parse(firstNumber) + int.Parse(secondNumber)));            Console.WriteLine()
        //}



        //string s = "You win some. You lose some.";

        //string[] subs = s.Split(' ');

        Console.WriteLine("Gib zweite zahl ein");
        string secondNumber = Console.ReadLine();

        Console.WriteLine("Summe von {0} und {1} ist {2}",
        firstNumber, secondNumber,
        (int.Parse(firstNumber) + int.Parse(secondNumber)));

        //string s = "You win some. You lose some.";

        //string[] subs = s.Split(' ');

        //foreach (var sub in subs)
        //{
        //    Console.WriteLine($"Substring: {sub}");
        //}

        // This example produces the following output:
        //
        // Substring: You
        // Substring: win
        // Substring: some.
        // Substring: You
        // Substring: lose
        // Substring: some.

       

    }

    //public static void Uebung02()
    //{
    //Console.WriteLine("Gib eine zahl ein");
    //string firstNumber = Console.ReadLine();
    //string s = firstNumber;
    //string[] subs = s.Split(" ");
    //Console.WriteLine("Summe von {0} und {1} ist {2}",
    //int.Parse(subs[0]), int.Parse(subs[1]),
    //(int.Parse(subs[0]) + int.Parse(subs[1])));
    //}

    //public static string DigitAsWord(int n)
    //
    //switch(n)
    //   {
    //case 1: return "eins";
    //case 2: return "zwei";
    //case 3: return "three";
    //       default: return "unknown";
    //             
    //   }
    //public static void Uebung03()
    //{
    //Console.WriteLine("Gib eine zahl ein");
    //string input = Console.ReadLine();

    //int sum = 0;
    //int length = input.Length;   

    //while (length > 0)
    //{
    //sum = sum + int.Parse(input[length - 1].ToString());
    //length--;
    //}

    //Console.WriteLine("Summe ist {0}", sum);

    //}

    public static void Uebung04()
    {
        Console.WriteLine("Gib eine zahl ein");
        string input = Console.ReadLine();

        int sum = 0;
        int length = input.Length;

        while (length > 0)
        {
            sum = sum + int.Parse(input[length - 1].ToString());
            length--;
        }

        Console.WriteLine("Summe ist {0}", sum);

    }


}