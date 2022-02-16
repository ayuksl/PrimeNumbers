namespace Galgenraten
{
    public class LogDataItem
    {
        public DateTime Timestamp { get; set; }
        public string Searchword { get; set; }
        public bool IsSuccessful { get; set; }
        public int NumberOfTries { get; set; }

        public LogDataItem(string searchWord, bool isSuccessful, int numberOfTries, DateTime timestamp)
        {
            this.Searchword = searchWord;
            this.IsSuccessful = isSuccessful;
            this.NumberOfTries = numberOfTries;
            this.Timestamp = timestamp;
        }

        public override string? ToString()
        {
            return $"{Timestamp} {Searchword} {IsSuccessful} {NumberOfTries}";
        }

        public string ToCsv()
        {
            return string.Join(";", Timestamp, Searchword, IsSuccessful, NumberOfTries);
        }
    }

}
