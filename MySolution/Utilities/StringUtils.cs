using System;
using System.Linq;


namespace Utilities
{
    // Eine statische Klasse kann nicht inztanziiert werden (d.h.
    // es können keine objekte davon erzeugt werden)
    public static class StringUtils
    {
        public static string Reverse(string s)
        {
            return new string(s.Reverse().ToArray());
        }
        public static bool IsPalindrome(string s)
        {
            return s.Equals(
                 Reverse(s),
                 StringComparison.OrdinalIgnoreCase);
        }

        public static int CountVowels(string s)  
        {
            //zähle die a,e,i,o,u
            Console.WriteLine("Enter your word");
            var word = Console.ReadLine();

            var vowelCount = word.Count("aeiouAEIOU".Contains);

            return( vowelCount);


        }
        public static string ReplaceUmlauts(string s)
        {

            //ü, ä ö ->
         Console.WriteLine("Enter your word");
         var l = Console.ReadLine();
         String t = l;
         t = t.Replace("ä", "ae");
         t = t.Replace("ö", "oe");
         t = t.Replace("ü", "ue");
         t = t.Replace("Ä", "Ae");
         t = t.Replace("Ö", "Oe");
         t = t.Replace("Ü", "Ue");
         t = t.Replace("ß", "ss");
         return t;
            

        }
    }
}


