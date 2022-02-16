using System;
using System.Linq;

namespace Utilities
{
    // Eine statische Klasse kann nicht
    // instanziiert werden (d.h. es können
    // keine Objekte davon erzeugt werden)
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
            // zähle die a,e,i,o,u
            // "abcea" -> 3
            string vowels = "aeiouAEIOU";
            int count = 0;
            foreach (char c in s)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }

        public static string ReplaceUmlauts(string s)
        {
            // ü -> ue, ä -> ae, ö -> oe
            return s
                .Replace("ä", "ae")
                .Replace("ö", "oe")
                .Replace("ü", "ue")
                .Replace("Ä", "Ae")
                .Replace("Ö", "Oe")
                .Replace("Ü", "Ue")
                .Replace("ß", "ss");
        }
    }

}
