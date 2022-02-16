public class NewsProgram
{
    public static void Main()
    {
        Console.WriteLine("news Program");

        NewsAgency agency = new NewsAgency();
        
        
        agency.NewNews += SubscriberOne;

        
        agency.NewNews += SubscriberTwo;

        agency.GetInformedByWhistleBlower(
            "Edward Snowden",
            "Turkey wants to conquer the whole world");


        //agency.NewNews("Corona Pandemic finally ends");
        //agency.NewNews("Java is dead. Long live C#");
    }

    public static void SubscriberOne(string news)
    {
        Console.WriteLine("One: Thanks for the news");
        Console.Write(news);
        Console.WriteLine();
    }
    public static void SubscriberTwo(string news)
    {
        Console.WriteLine("Two: Holy Shit What Happpens");
    }
}