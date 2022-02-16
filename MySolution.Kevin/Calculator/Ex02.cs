public class Ex02
{
    public static void Main()
    {
        string line = Console.ReadLine() ?? "";

        int sum = 0;
        string[] words = line.Split();

        //for (int i = 0; i < words.Length; ++i)
        //{
        //}

        foreach (string word in words) 
        {
            sum += int.Parse(word);
            //sum = sum + int.Parse(word);
        }

        Console.WriteLine($"Summe ist {sum}");
        
        // Fehler: Hier werden Strings aneinander gehangen!
        // Console.WriteLine($"Summe ist {words[0] + words[1]}");
    }
}