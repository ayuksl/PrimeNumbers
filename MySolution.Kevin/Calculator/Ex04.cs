using System.Text;

public class Ex04
{
    public static void Main()
    {
        Console.WriteLine(FromIntToString(0));
        Console.WriteLine(FromIntToString(1));
        Console.WriteLine(FromIntToString(10));
        Console.WriteLine(FromIntToString(11));
        Console.WriteLine(FromIntToString(101));
        Console.WriteLine(FromIntToString(1234));
    }

    public static string? FromIntToString(int n)
    {
        string[] digitStrings = { 
            "0", "1", "2", "3", "4", 
            "5", "6", "7", "8", "9" 
        };
        StringBuilder result = new StringBuilder();

        do
        {
            int digit = n % 10;
            n /= 10;
            result.Append(digitStrings[digit]);
        }
        while (n > 0);

        return string.Join("", result.ToString().Reverse());
    }

}