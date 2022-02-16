public class Calculator
{
    public static void Main(string[] arguments)
    {
        if (arguments.Length != 2)
        {
            string message =
                "Fehler: Zwei Argumente erwartet, " +
                $"aber {arguments.Length} Argumente erhalten.";
            Console.WriteLine(message);
            return;
        }

        // Wir gelangen nur an diese Stelle, wenn
        // die Argumentanzahl 2 beträgt.
        Console.WriteLine("Ich berechne...");
        int firstNumber = int.Parse(arguments[0]);
        int secondNumber = int.Parse(arguments[1]);
        //Console.WriteLine("Summe von {0} und {1} ist {2}", 
        //    firstNumber, secondNumber, 
        //    firstNumber + secondNumber);
        Console.WriteLine(
            $"Summe von {firstNumber} " + 
            $"und {secondNumber} " +
            $"ist {firstNumber+secondNumber}");
    }
}