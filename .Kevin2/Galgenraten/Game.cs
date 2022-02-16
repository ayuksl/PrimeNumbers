using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgenraten
{
    public class Game
    {
        public string Word { get; }
        private int maxTrials;
        private int numTrials;
        private LogData logData;

        public bool Prs(string v)
        {
            return (int.TryParse(v, out int y));
        }

        public string GetTheWord(string path)
        {
            int n = 0;
            Console.WriteLine("Please give a number between 1 and 100000:");

            string v = Console.ReadLine();

            if (Prs(v))
            {
                n = int.Parse(v);


                string[] lines = File.ReadAllLines(path);

                string wort = lines[n];


                return wort;

                //public static string? n = 
            }
            else
            {
                Console.WriteLine("It is not a number");
                return null;

                GetTheWord(path);

            }
        }

        public void Run()
        {

            //Game game = new Game(@".\wortliste.txt", 10, 0);
            char[] contr = new char[Word.Length];
            int counter = Word.Length;
            int counter2 = 0;
            //
            Console.WriteLine("cntr {0} word {1}", counter, Word);
            for (int i = 0; i < counter; i++)
            {
                contr[i] = '_';
            }
            if (counter > 0 )//&& this.maxTrials >= counter2
            {

                for (int i = 0; i < Word.Length; ++i)
                {
                    Console.WriteLine("Please give a letter");
                    string input = Console.ReadLine() ?? "";
                    counter2 += 1;

                    char letter = char.ToUpper(input[0]);
                   
                    if (Word.Contains(input, StringComparison.OrdinalIgnoreCase) && contr[i] != letter)
                    {
                        contr[i] = letter;
                    }
                    Console.Write(contr);



                }
                //for (int i = 0; i < contr.Length; ++i)
                
                    //counter--;
                
               

                Console.WriteLine();
            Console.WriteLine(" Congratulations!!! You have succeeded!!!");
            Console.WriteLine(" The number of trials you made: {0}", counter2);
            LogDataItem logItem = new LogDataItem(Word, true, counter2, DateTime.Now);
            this.logData.AddLog(logItem);
            this.logData.Save();
            RunMenu();
            }
            else
            {
                if (this.maxTrials < counter2)
                {
                    Console.WriteLine(" You have reached the maximum allowed number of trials bye");
                    LogDataItem item = new LogDataItem(Word, false, counter2, DateTime.Now);
                    this.logData.AddLog(item);
                    this.logData.Save();
                    RunMenu();
                }
            }



            Console.WriteLine("Would you like to make another run?(y/n)");
            string answer = Console.ReadLine() ?? "";
            if (answer == "y")
            {
                Run();
            }
            else
            {
                RunMenu();

            }


            this.numTrials = counter2;
        }


        public bool RunMenu()
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1) New Game");
            Console.WriteLine("2) See The Log Data");
            Console.WriteLine("3) Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        //Game game2 = new Game(@".\wortliste.txt", 10, 0);
                        Run();
                        return true;
                    }


                case "2":
                    {
                        this.logData.PrintItems();
                        return true;
                    }

                case "3":
                    EndGame();
                    return true;

                default:
                    return false;


            }
        }

        //public Game Sampler()
        //{
        //    Game gameSample = new Game(
        //        this.Id , this.Word, this.TimeStamp,
        //        this.numTrials, this.maxTrials);

        //    return gameSample;
        //}
        //public void GetLog()
        //{
        //    //int IdCounter = 0;
        //    string keyword = this.Word;
        //    string id = this.Id;
        //    int numTrials = this.numTrials;
        //    DateTime timeStamp = GetTimestamp(DateTime.Today);
        //    int maxTrials = this.maxTrials;

        //    Game gameSample = new Game(
        //         keyword, id, timeStamp,
        //        this.numTrials, this.maxTrials);


        //    return gameSample;

        //}
        public bool EndGame()
        {
            while (false)
            {
                //Game game = new Game(@".\wortliste.txt", 10, 0);
                Run();
            }
            return true;

        }
        public string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssfff");
        }
        public Game(string path, int maxTrials, int numTrials)
        {
            this.Word = GetTheWord(path);
            this.maxTrials = Word.Distinct().Count() + 5;
            this.numTrials = 0;
            this.logData = new LogData("log.txt");
            logData.Read();
        }
    }
}













          


        