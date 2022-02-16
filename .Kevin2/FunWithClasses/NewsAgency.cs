public class NewsAgency
{
    public event NewsEventHandler? NewNews;
   


    public void GetInformedByWhistleBlower(string name, string report)
    {
      
        {
        string news = $"Informant: {name}\nNews: {report}";
            NewNews?.Invoke(news); //Informiere Abonnenten

        }

    }
    public NewsAgency()
    {

    }
}