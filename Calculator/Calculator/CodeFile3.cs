using System;
public class ReverseStringExample
{

    public static void Main(string[] args)

    {
        Console.WriteLine("Bitte ein wort einfügen");
        string word = Console.ReadLine();
        //string reversedString = ReverseString(word);
        ReverseString(word);
        
        //reversedString = ReverseString("uvw");
        ////public static string ReverseString(string s)
        //    Console.WriteLine("Bitte ein Wort einfügen:");
        //    string s = Console.ReadLine();
        //    string bb = new string(s.Reverse().ToArray());
        //
        //for (int i = s.Length; i > 0; --i )
        //
        //    {
        //        Console.WriteLine(a[i]);
        //        
        //
        //
        //    }




    }
    public static void ReverseString(string s)
    {
        //string bb = new string(s.Reverse().ToArray());
        for (int i = s.Length;i > 0;i--)
        {
            Console.Write(s.Substring(i - 1, 1));
        }
       
    }
    //Console.WriteLine(bb); 
    //public static string?
}



//using System;
//using System.Linq;
//namespace centuryyearsminutes
//{
//class Program
//{
//static void Main(string[] args)
//{
//string aa = "Hello World!";
//string bb = aa.Reverse();
//Console.WriteLine(bb);
//}
//}
//
//
//string bb = new string(aa.Reverse().ToArray());
//}