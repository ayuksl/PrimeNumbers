public class Ex05
{
    public static void Main()
    {
        Console.WriteLine(FromStringToInt("0"));
        Console.WriteLine(FromStringToInt("1"));
        Console.WriteLine(FromStringToInt("10"));
        Console.WriteLine(FromStringToInt("123"));
        Console.WriteLine(FromStringToInt("12349"));
    }

    public static int FromCharToInt(char aChar)
    {
        char[] digitChars = { 
            '0', '1', '2', '3', '4', 
            '5', '6', '7', '8', '9' 
        };

        for (int i = 0; i < digitChars.Length; ++i)
        {
            if (digitChars[i] == aChar) return i;
        }

        throw new ArgumentException(
            $"{aChar} is not a digit");
    }

    public static int FromStringToInt(string aString)
    {
        int sum = 0;

        foreach (char aChar in aString)
        {
            sum *= 10;
            sum += FromCharToInt(aChar);
        }

        return sum;
    }

}