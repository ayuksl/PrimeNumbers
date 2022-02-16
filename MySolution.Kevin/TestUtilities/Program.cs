using Utilities;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string s = StringUtils.Reverse("abcd");
        Console.WriteLine(s);
        s = "the quick fox jumps";
        Console.WriteLine(StringUtils.CountVowels(s));
        s = "Özgür Ülübößa";
        Console.WriteLine(StringUtils.ReplaceUmlauts(s));
    }
}
