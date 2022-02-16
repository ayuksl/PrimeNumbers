public class SecondProgram
{
    public static void Main(string[] arguments)
    {
        Console.WriteLine("Das zweite Programm");
        foreach (string argument in arguments)
        {
            Console.WriteLine(argument);
        }
    }
}

