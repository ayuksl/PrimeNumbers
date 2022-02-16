using System;

// Eine Klasse, die als internal deklariert wird,
// ist nur innerhalb der Assembly sichtbar.
// Eine Klasse, die als public deklariert wird,
// ist auch für andere Assemblies sichtbar.
public class CalculatorExercise
{
    // Eine Methode, die als public deklariert wird,
    // ist für alle Klassen innerhalb der Assembly
    // sichtbar.
    public static void Main(string[] args)
    {
        Console.Write("Gib eine Zahl ein: ");
        string a = Console.ReadLine();
        Console.Write("Gib eine Zahl ein: ");
        string b = Console.ReadLine();
        int numberA = Convert.ToInt32(a);
        int numberB = Convert.ToInt32(b);
        Console.WriteLine(numberA + numberB);

        string aAsWord = DigitAsWord(numberA);
        Console.WriteLine(aAsWord);
    }

    public static string DigitAsWord(int n)
    {
        switch (n)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            default: return "unknown";
        }
    }
}


