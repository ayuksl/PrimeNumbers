using System;

public class EX02
{
    public static void  Main()
    {
        string line = Console.ReadLine();
        string[] words = line.Split();
        int first = int.Parse(words[0]);
        int second = int.Parse(words[1]);   
        int sum = first + second;
        Console.WriteLine("The sum is {0}", sum);
    }
}