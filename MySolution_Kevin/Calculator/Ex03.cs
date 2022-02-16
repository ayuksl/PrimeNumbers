using System;

public class Ex03
{
    public static void Main()
    {
        string line = Console.ReadLine();
        int summe = Ex03.Quersumme(int.Parse(line));
        Console.WriteLine($"Quersumme ist {summe}");
    }

    public static int Quersumme(int number)
    {
        int sum = 0;
        string s = number.ToString();

        foreach (char c in s)
        {
            sum += int.Parse(c.ToString());
        }

        return sum;
    }
}
