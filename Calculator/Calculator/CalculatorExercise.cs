using System; 
    //Eine Klasse, die als internal deklariert wird,
    //ist nur innerhalb der Assembly sichtbsr.
    //Eine klasse, die als public deklariert wird
    // ist auch für Andere Assemblies sichtbar.
internal class CalculatorExercise
{
    //Eine Methode, die als public deklariert wird, 
    //ist für alle Klassen innerhalb der Assembly sichtbar.
    public static void Main(string[] args)
    {
        Console.WriteLine("Please give the first number: ");
        string firstInput = Console.ReadLine();
        Console.WriteLine("Please give the second number: ");
        string secondInput = Console.ReadLine();
        int firstnumber = Convert.ToInt32(firstInput);
        int secondnumber = Convert.ToInt32(secondInput);
        int sum = firstnumber + secondnumber;
        Console.WriteLine("");
    }
}

