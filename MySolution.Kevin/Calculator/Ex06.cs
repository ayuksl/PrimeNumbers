public class Ex06
{
    public static void Main()
    {
        string input = Console.ReadLine()!;
        string reversed = Ex06.ReverseString(input);
        Console.WriteLine(reversed);
        Console.WriteLine("Ist ein Palindrom: {0}",
            IsPalindrome(input));
    }

    public static string ReverseString(string s)
    {
        string result = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            result += s[i];
        }

        return result;
        //return new string(s.Reverse().ToArray());
    }

    public static bool IsPalindrome(string s)
    {
        string reversed = ReverseString(s);
        StringComparison compareMode = StringComparison.CurrentCultureIgnoreCase;
        
        if (s.Equals(reversed, compareMode))
        {
            return true;
        }

        return false;
    }



}