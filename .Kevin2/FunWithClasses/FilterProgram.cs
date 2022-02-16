using System.Linq;

public class FilterProgramm
{
    public static void Main()
    {
        //Uebung31();
        Queries();
    }

    public static void Queries()
    {
        string[] lines = File.ReadAllLines(@"data\wortliste.txt");

        //var query32_1 = from l in lines
        //where l.ToLower().StartsWith("x") || l.ToLower().StartsWith("y")
        //orderby l.Length
        //select l;
        //foreach (var was in query32_1)
        //{
        //Console.WriteLine(was);
        //}

        //var query32_2 = from l in lines
        //where l.ToLower().StartsWith("x") 
        //orderby l.Length descending
        //select l;
        //foreach (var was2 in query32_2)
        //{
        //Console.WriteLine(was2);
        //}


        //foreach (string l in lines.Where(s => s.ToLower().StartsWith("ß")))
        //var query32_3 = from l in lines
        //where l.ToLower().StartsWith("x")
        //select string.Join("", l.Reverse());

        //foreach (var l in query32_3)
        //Console.WriteLine(l);

        //var query32_4 = from l in lines
        //where l.ToLower().StartsWith("x")
        //select new
        //{
        //FirstLetter = l.First(),
        //LastLetter = l.Last(),
        //};

        //foreach (var l in query32_4)
        //Console.WriteLine(l);


        //var query32_5 = from l in lines
        //group l by l.ToLower().Last() into lineGroup

        //select new
        //{
        //Letter = lineGroup.Key,
        //LineCount = lineGroup.Count() ,
        //AverageLineLength = lineGroup.Average(l => l.Length)
        //};

        //foreach (var l in query32_5)
        //Console.WriteLine(l);

        //var query32_6 = from l in lines
                        //where lines.Length >= 2
                        //join l2 in lines on 
                        //string.Join("", l.Take(2)) equals 
                        //string.Join("", l2.TakeLast(2)) into lineJoin


                        //select new
                        //{
                            //Line = line,

                            //AssociatedLines = lineJoin
                        //};

        //foreach (var mapping in query32_6)
        //{
            //Console.WriteLine(mapping.Line);
            //foreach (string associatedLine in mapping.AssociatedLines)
            //{
                //Console.WriteLine(associatedLine);
            //}


        //}





        //Console.Write("Lütfen bir metin giriniz");
        //string metin = Console.ReadLine();
        ////metin.Length "-1" deme sebebimiz diziler
        ////diziler "0". indisden başlamaktır
        //Console.WriteLine("Metnimizin ters hali");
        //for (int i = metin.Length - 1; i >= 0; i--)
        //{
        //Console.Write(metin[i]);
        //}

        //{
        //string cumle = "Bu örnek cümledeki kelimeleri ters olarak sıralıyor ";
        //string[] metin = cumle.Split(' ');
        //Array.Reverse(metin);
        //Console.Write(string.Join(" ", metin));
        //Console.ReadKey();

        //}
    }
}
    //public static void Uebung31()
    //{
        //Console.WriteLine("FilterProgramm");
        //string[] lines = File.ReadAllLines(@"data\wortliste.txt");
        //Console.WriteLine(lines.Length);
        //for (int i = 0; i < 15; i++)
        //{
            //Console.Write(lines[i] + ',' + ' ');
        //}
        //Console.WriteLine();
        //Console.WriteLine(lines.Count());
        //foreach (string line in lines.Take(15))
        //{
            //Console.WriteLine(line);
        //}
        //// Enumerable.Take(lines, 15); in wahrheit ist das aufgerufen...

        //foreach (string line in lines.TakeLast(15))
        //{
            //Console.WriteLine(line);
        //}
        //// Func<string, bool> ist ein Delegate-Typ der methoden kapselt die als
        //// Eingabeparameter einen string erwarten und als ausgabe einen bool-Wert liefern.
        //foreach (string line in lines.Where(FilterByX))
        //{
            //Console.WriteLine(line);
        //}
        //foreach (string l in lines.Where(s => s.ToLower().StartsWith("ß")))

        //{
            //Console.WriteLine(l);
        //}
        //Console.WriteLine(lines.Any(s => s.Length >= 15));
        //string word = lines.Last(s => s.Length >= 15);
        //Console.WriteLine(word);
        //IEnumerable<string> query =
            //lines.Take(10).Select(line => line.ToUpper());

        //List<string> results = query.ToList();
        //results.ForEach(s => Console.WriteLine(s));

        //Console.WriteLine("Merhaba.........................................");

        //query
            //.OrderByDescending(x => x)
            //.ToList()
            //.ForEach(Console.WriteLine);
        ////Ex31.1
        //Console.WriteLine("Ex31.1..................................");
        //foreach (string l in lines.Where(s => s.ToLower().StartsWith("b")))

        //{
            //Console.WriteLine(l);
        //}
        ////Ex31.2
        //Console.WriteLine("Ex31.2..................................");
        //foreach (string l in lines.Where(s => s.Length >= 10))

        //{
            //Console.WriteLine(l);
        //}
        ////Ex31.3
        //Console.WriteLine("Ex31.3..................................");
        //foreach (string line in lines.TakeLast(5))
        //{
            //Console.WriteLine(line.ToLower());
        //}
        ////Ex31.4
        //Console.WriteLine("Ex31.4..................................");
        //foreach (string line in lines.Skip(10).Take(10))
        //{
            //Console.WriteLine(line.ToLower());
        //}

        ////Ex31.5
        //Console.WriteLine("Ex31.5..................................");
        //foreach (string l in lines.Where(s =>
        //s.ToLower().Contains('a')
        //|| s.ToLower().Contains('e')
        //|| s.ToLower().Contains('o')
        //|| s.ToLower().Contains('o') && s.ToLower().Contains('e')
        //|| s.ToLower().Contains('u') && s.ToLower().Contains('e')
        //|| s.ToLower().Contains('u')
        //|| s.ToLower().Contains('a') && s.ToLower().Contains('e')
        //|| s.ToLower().Contains('e')))
        //{
            //Console.WriteLine(l);
        //}

        //Console.WriteLine(lines.Where(l => l.ToLower().Any(c => "aeiou".Contains(c))));

        ////31.5.5
        //lines.Where(l => l.ToLower().FirstOrDefault('_')))

        ////Ex31.6
        //Console.WriteLine("Ex31.6..................................");
        //foreach (string l in lines)
        //{
            //Console.WriteLine("The Word is {0} and The length of the Word is {1}", l, l.Length);
        //}

        ////Ex31.7
        //Console.WriteLine("Ex31.7..................................");
        //foreach (string l in lines.Where(s =>
        //s.ToUpper().StartsWith('B') && s.ToLower().EndsWith('e')))
        //{
            //Console.WriteLine(l);
        //}

        //lines
            //.Where
            //(s => s.ToLower()
            //.StartsWith("z"))
            //.OrderBy(s => s.Length)
            //.ToList()
            //.ForEach
            //(s => Console.WriteLine(s));

        //lines
            //.Where
            //(s => s.StartsWith("a")
            //|| s.StartsWith("e")
            //|| s.StartsWith("i")
            //|| s.StartsWith("o")
            //|| s.StartsWith("u"))
            //.ToList()
            //.ForEach
            //(s => Console.WriteLine(s));

        //foreach (s => Console.WriteLine(s.lines.ToList().Where(s => s.StartsWith("a")
            //.Union(lines.ToList().Where(s => s.StartsWith("e"))
            //.Union(lines.ToList().Where(s => s.StartsWith("i"))
            //.Union(lines.ToList().Where(s => s.StartsWith("o"))
            //.Union(lines.ToList().Where(s => s.StartsWith("u"))))))));


        //foreach (string line in lines.OrderBy(s => s.Length).ToList())
        //{
            //Console.WriteLine("{},{}", line, line.Length - 1);
        //}

        //Console.WriteLine
            //(lines.Select
            //(s => s.Length)
            //.ToList()
            //.Sum());

        //lines.Where(
            //s => s.Distinct()
            //.ToArray()
            //.Count() >= 5)
            //.ToList()
            //.ForEach(
            //s => Console.WriteLine(s));
    //}
    //public static bool FilterByX(string s)
    //{
        //return s.ToLower().StartsWith("x");
    //}

